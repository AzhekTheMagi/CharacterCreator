using CharacterCreator.Decorator;
using CharacterCreator.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace CharacterCreator
{
    public partial class Form1 : Form
    {
        string serializationFile = Path.Combine(@"E:\Desktop", "Character.bin");
        ICharacterFactory characterFactory = new CharacterFactory();
        List<IEquipment> equipmentList = new List<IEquipment>();
        BindingList<Character> characters = new BindingList<Character>();

        public Form1()
        {
            InitializeComponent();

            characterProfileListView.ShowItemToolTips = true;
            characterEquipmentListView.ShowItemToolTips = true;

            MessageBox.Show("Select character in character listing to add equipment, see profile, and refresh character equipment inventory.");

            //Binds character list to character listbox.
            characterListBox.DataSource = characters;
        }

        private void addEquipmentButton_Click(object sender, EventArgs e)
        {
            try
            {
                string equipmentType = InputBox.ShowDialog("Enter Type: Longbow, BattleAxe, Staff", "Item Type");
                string name = InputBox.ShowDialog("Enter Item Name", "Item Name");

                IEquipment equipment = characterFactory.createEquipment(equipmentType);
                equipment.setName(name);

                characters[characterListBox.SelectedIndex].addEquipment(equipment);
            }
            catch (ArgumentNullException)
            {
                MessageBox.Show("Must create character first before adding equipment!");
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Must create character first before adding equipment!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {  
            try
            {
                string name = InputBox.ShowDialog("Enter Character Name", "Name");
                string race = this.raceComboBox.GetItemText(this.raceComboBox.SelectedItem);
                string characterClass = this.characterClassComboBox.GetItemText(this.characterClassComboBox.SelectedItem);

                IRace characterRace = characterFactory.createRace(race);
                ICharacterClass charClass = characterFactory.createCharacterClass(characterClass);
                
                Character tmpCharacter = new Character(name, characterRace, charClass);
                characters.Add(tmpCharacter);
            }
            catch (System.ArgumentNullException)
            {
                MessageBox.Show("Must select race and class to create character.");
            }
        }

        private void characterListBox_Click(object sender, EventArgs e)
        {
            characterProfileListView.Items.Clear();
            characterEquipmentListView.Items.Clear();

            try
            {
                string characterRace = characters[characterListBox.SelectedIndex].getRace().ToString();
                string characterName = characters[characterListBox.SelectedIndex].getName();
                string characterBio = characters[characterListBox.SelectedIndex].getRace().getDescription();

                var characterItem = new ListViewItem(new[] { characterRace, characterName, characterBio });
                characterProfileListView.Items.Add(characterItem);

                if (characters[characterListBox.SelectedIndex].getEquipmentList().Count != 0)
                {
                    foreach (IEquipment equipmentItem in characters[characterListBox.SelectedIndex].getEquipmentList())
                    {
                        string equipmentName = equipmentItem.getName();
                        string equipmentType = equipmentItem.ToString();

                        var magicType = typeof(MagicTraitDecorator);
                        var equipItem = new ListViewItem();

                        if (!magicType.IsInstanceOfType(equipmentItem))
                        {
                            equipItem = new ListViewItem(new[] { equipmentType, equipmentName, "None" });
                        }
                        else
                        {
                            MagicTraitDecorator tmpDecorator = (MagicTraitDecorator)equipmentItem;
                            equipItem = new ListViewItem(new[] { equipmentType, equipmentName, tmpDecorator.getMagicTrait() });
                        }

                        characterEquipmentListView.Items.Add(equipItem);
                    }
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                //Do nothing
            }
        }

        private void addMagicTraitEquipment_Click(object sender, EventArgs e)
        {
            try
            {
                string equipmentName = characterEquipmentListView.SelectedItems[0].SubItems[1].Text;
                int index = characters[characterListBox.SelectedIndex].getEquipmentList().FindIndex(x => x.getName() == equipmentName);

                foreach (IEquipment equipmentItem in characters[characterListBox.SelectedIndex].getEquipmentList())
                {
                    if (equipmentItem.getName().Contains(equipmentName))
                    {
                        MagicTraitDecorator decorated = new MagicTraitDecorator(equipmentItem);
                        decorated.setMagicTrait(InputBox.ShowDialog("Enter magic trait, e.g. Ghost Site", "Trait"));
                        decorated.setType(equipmentItem.ToString());
                        characters[characterListBox.SelectedIndex].getEquipmentList().IndexOf(equipmentItem);
                        characters[characterListBox.SelectedIndex].getEquipmentList().Remove(equipmentItem);
                        characters[characterListBox.SelectedIndex].getEquipmentList().Add(decorated);

                        break;
                    }
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Must select weapon prior to adding magic trait.");
            }
        }

        private void equipPartyInventoryButton_Click(object sender, EventArgs e)
        {
            
        }

        private void saveCharacterButton_Click(object sender, EventArgs e)
        {
            using (Stream stream = File.Open(serializationFile, FileMode.Create))
            {
                var bformatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();

                bformatter.Serialize(stream, characters);
            }
        }

        private void loadCharacterListButton_Click(object sender, EventArgs e)
        {
            characters.Clear();

            BindingList<Character> tmpCharacters;
            PopUp popupForm = new PopUp();
            popupForm.setSerializationFileName(serializationFile);

            popupForm.ShowDialog();
            tmpCharacters = popupForm.getFilteredList();
/*
            BindingList<Character> tmpCharacters;
            using (Stream stream = File.Open(serializationFile, FileMode.Open))
            {
                var bformatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();

                tmpCharacters = (BindingList <Character>)bformatter.Deserialize(stream);
            }
*/
            //Required since characters list in databinded to characterlistbox
            if (tmpCharacters == null)
            {
                MessageBox.Show("List does not contain selected character option.");
            }
            else
            {
                foreach (Character character in tmpCharacters)
                {
                    characters.Add(character);
                }
            }
        }
    }
}
