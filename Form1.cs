using CharacterCreator.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    }
}
