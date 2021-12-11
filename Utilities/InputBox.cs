using System.Windows.Forms;

namespace CharacterCreator.Utilities
{
    public class InputBox
    {
        public static string ShowDialog(string message, string title)
        {
            Form prompt = new Form()
            {
                Width = 500,
                Height = 180,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = title,
                StartPosition = FormStartPosition.CenterScreen
            };
            Label textLabel = new Label() { Left = 50, Top = 20, Text = message };
            textLabel.AutoSize = true;
            TextBox textBox = new TextBox() { Left = 50, Top = 50, Width = 400 };
            Button confirmation = new Button() { Text = "Ok", Left = 350, Width = 100, Height = 40, Top = 80, DialogResult = DialogResult.OK };
            confirmation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            confirmation.Click += (sender, e) => { prompt.Close(); };
            prompt.Controls.Add(textBox);
            prompt.Controls.Add(confirmation);
            prompt.Controls.Add(textLabel);
            prompt.AcceptButton = confirmation;

            return prompt.ShowDialog() == DialogResult.OK ? textBox.Text : "";
        }
    }
}
