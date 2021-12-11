using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CharacterCreator
{
    public partial class Form1 : Form
    {
        string race;
        string characterClass;

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
            MessageBox.Show(characterClass);
        }
    }
}
