using CharacterCreator.Decorator;
using CharacterCreator.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace CharacterCreator
{
    public partial class Form1 : Form
    {
        ICharacterFactory characterFactory = new CharacterFactory();
        List<IEquipment> equipmentList = new List<IEquipment>();

        BindingList<Character> characters = new BindingList<Character>();

        public Form1()
        {
            InitializeComponent();

            characterProfileListView.ShowItemToolTips = true;
            characterEquipmentListView.ShowItemToolTips = true;

            MessageBox.Show("Select character in the Character listing to add equipment or see profile");

            //Binds character list to character listbox.
            characterListBox.DataSource = characters;
        }

        private void addEquipmentButton_Click(object sender, EventArgs e)
        {
            string equipmentType = InputBox.ShowDialog("Enter Type: Longbow, BattleAxe, Staff", "Item Type");
            string name = InputBox.ShowDialog("Enter Item Name", "Item Name");

            IEquipment equipment = characterFactory.createEquipment(equipmentType);
            equipment.setName(name);

            characters[characterListBox.SelectedIndex].addEquipment(equipment);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string name = InputBox.ShowDialog("Enter Character Name", "Name");
            string race = this.raceComboBox.GetItemText(this.raceComboBox.SelectedItem);
            string characterClass = this.characterClassComboBox.GetItemText(this.characterClassComboBox.SelectedItem);
            
            try
            {
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

            string characterRace = characters[characterListBox.SelectedIndex].getRace().ToString();
            string characterName = characters[characterListBox.SelectedIndex].getName();
            string characterBio  = characters[characterListBox.SelectedIndex].getRace().getDescription();

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

        private void addMagicTraitEquipment_Click(object sender, EventArgs e)
        {
            string magicTrait = InputBox.ShowDialog("Enter magic trait, e.g. Ghost Site", "Trait");
            string equipmentName = characterEquipmentListView.SelectedItems[0].SubItems[1].Text;
            int index = characters[characterListBox.SelectedIndex].getEquipmentList().FindIndex(x => x.getName() == equipmentName);

            foreach (IEquipment equipmentItem in characters[characterListBox.SelectedIndex].getEquipmentList())
            {
                if (equipmentItem.getName().Contains(equipmentName))
                {
                    MagicTraitDecorator decorated = new MagicTraitDecorator(equipmentItem);
                    decorated.setMagicTrait(magicTrait);
                    decorated.setType(equipmentItem.ToString());
                    characters[characterListBox.SelectedIndex].getEquipmentList().IndexOf(equipmentItem);
                    characters[characterListBox.SelectedIndex].getEquipmentList().Remove(equipmentItem);
                    characters[characterListBox.SelectedIndex].getEquipmentList().Add(decorated);

                    break;
                }
            }
        }
    }
}
