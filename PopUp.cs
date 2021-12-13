using CharacterCreator.Filter;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace CharacterCreator
{
    public partial class PopUp : Form
    {
        private string serializationFile;
        private BindingList<Character> filteredCharacterList;

        public PopUp()
        {
            InitializeComponent();
        }

        public void setSerializationFileName(string fileName)
        {
            this.serializationFile = fileName;
        }

        public BindingList<Character> getFilteredList()
        { 
            if (filteredCharacterList.Count != 0)
            {
                return this.filteredCharacterList;
            }
            else
            {
                return null;
            }
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            BindingList<Character> tmpCharacters;

            using (Stream stream = File.Open(serializationFile, FileMode.Open))
            {
                var bformatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();

                tmpCharacters = (BindingList<Character>)bformatter.Deserialize(stream);
            }

            if (filterCheckedListBox.SelectedIndex == 0)
            {
                MagicCriteria magicCriteria = new MagicCriteria();
                filteredCharacterList = magicCriteria.meetCriteria(tmpCharacters);
            }
            else if (filterCheckedListBox.SelectedIndex == 1)
            {
                OrcCriteria orcCriteria = new OrcCriteria();
                filteredCharacterList = orcCriteria.meetCriteria(tmpCharacters);
            }
            else
            {
                filteredCharacterList = tmpCharacters;
            }          

            this.Close();
        }
    }
}
