
namespace CharacterCreator
{
    partial class PopUp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.characterListSelectionLabel = new System.Windows.Forms.Label();
            this.okButton = new System.Windows.Forms.Button();
            this.filterCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // characterListSelectionLabel
            // 
            this.characterListSelectionLabel.AutoSize = true;
            this.characterListSelectionLabel.Location = new System.Drawing.Point(22, 43);
            this.characterListSelectionLabel.Name = "characterListSelectionLabel";
            this.characterListSelectionLabel.Size = new System.Drawing.Size(215, 25);
            this.characterListSelectionLabel.TabIndex = 0;
            this.characterListSelectionLabel.Text = "Character List Return Type";
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(55, 231);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(112, 34);
            this.okButton.TabIndex = 1;
            this.okButton.Text = "Ok";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // filterCheckedListBox
            // 
            this.filterCheckedListBox.FormattingEnabled = true;
            this.filterCheckedListBox.Items.AddRange(new object[] {
            "Magic Characters",
            "Orc Characters",
            "All Characters"});
            this.filterCheckedListBox.Location = new System.Drawing.Point(22, 71);
            this.filterCheckedListBox.Name = "filterCheckedListBox";
            this.filterCheckedListBox.Size = new System.Drawing.Size(180, 144);
            this.filterCheckedListBox.TabIndex = 5;
            // 
            // PopUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 289);
            this.Controls.Add(this.filterCheckedListBox);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.characterListSelectionLabel);
            this.Name = "PopUp";
            this.Text = "Select Character Type to Load";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label characterListSelectionLabel;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.CheckedListBox filterCheckedListBox;
    }
}