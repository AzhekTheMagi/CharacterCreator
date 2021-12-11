using CharacterCreator.Utilities;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CharacterCreator
{
    public partial class Form1 : Form
    {
        string race;
        string characterClass;
        ICharacterFactory characterFactory = new CharacterFactory();
        List<Character> characters = new List<Character>();
        List<IEquipment> equipmentList = new List<IEquipment>();

        public Form1()
        {
            InitializeComponent();
        }

        private void raceComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            race = this.raceComboBox.GetItemText(this.raceComboBox.SelectedItem);
        }

        private void characterClassComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            characterClass = this.characterClassComboBox.GetItemText(this.characterClassComboBox.SelectedItem);
        }

        private void addEquipmentButton_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                IRace characterRace = characterFactory.createRace(race);
                ICharacterClass charClass = characterFactory.createCharacterClass(characterClass);

                string name = InputBox.ShowDialog("Enter Character Name", "Name");
                Character tmpCharacter = new Character(name, characterRace, charClass);
                characters.Add(tmpCharacter);

                characterListBox.Items.Add(tmpCharacter);
            }
            catch (System.ArgumentNullException)
            {
                MessageBox.Show("Must select race and class to create character.");
            }
        }
    }
}
