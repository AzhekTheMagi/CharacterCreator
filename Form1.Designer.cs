
namespace CharacterCreator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.addEquipmentButton = new System.Windows.Forms.Button();
            this.characterEquipmentList = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.listView2 = new System.Windows.Forms.ListView();
            this.label4 = new System.Windows.Forms.Label();
            this.listView3 = new System.Windows.Forms.ListView();
            this.RaceLabel = new System.Windows.Forms.Label();
            this.ClassLabel = new System.Windows.Forms.Label();
            this.raceComboBox = new System.Windows.Forms.ComboBox();
            this.characterClassComboBox = new System.Windows.Forms.ComboBox();
            this.characterEquipmentLabel = new System.Windows.Forms.Label();
            this.characterListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // addEquipmentButton
            // 
            this.addEquipmentButton.Location = new System.Drawing.Point(25, 380);
            this.addEquipmentButton.Name = "addEquipmentButton";
            this.addEquipmentButton.Size = new System.Drawing.Size(182, 34);
            this.addEquipmentButton.TabIndex = 0;
            this.addEquipmentButton.Text = "Add Equipment";
            this.addEquipmentButton.UseVisualStyleBackColor = true;
            this.addEquipmentButton.Click += new System.EventHandler(this.addEquipmentButton_Click);
            // 
            // characterEquipmentList
            // 
            this.characterEquipmentList.FormattingEnabled = true;
            this.characterEquipmentList.ItemHeight = 25;
            this.characterEquipmentList.Location = new System.Drawing.Point(473, 41);
            this.characterEquipmentList.Name = "characterEquipmentList";
            this.characterEquipmentList.Size = new System.Drawing.Size(182, 129);
            this.characterEquipmentList.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(25, 153);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(182, 34);
            this.button2.TabIndex = 5;
            this.button2.Text = "Create Character";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Character List";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(310, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Party Inventory";
            // 
            // listView2
            // 
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(310, 247);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(182, 146);
            this.listView2.TabIndex = 9;
            this.listView2.UseCompatibleStateImageBehavior = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(509, 256);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "Character Profile";
            // 
            // listView3
            // 
            this.listView3.HideSelection = false;
            this.listView3.Location = new System.Drawing.Point(509, 296);
            this.listView3.Name = "listView3";
            this.listView3.Size = new System.Drawing.Size(182, 146);
            this.listView3.TabIndex = 11;
            this.listView3.UseCompatibleStateImageBehavior = false;
            // 
            // RaceLabel
            // 
            this.RaceLabel.AutoSize = true;
            this.RaceLabel.Location = new System.Drawing.Point(25, 13);
            this.RaceLabel.Name = "RaceLabel";
            this.RaceLabel.Size = new System.Drawing.Size(128, 25);
            this.RaceLabel.TabIndex = 12;
            this.RaceLabel.Text = "Character Race";
            // 
            // ClassLabel
            // 
            this.ClassLabel.AutoSize = true;
            this.ClassLabel.Location = new System.Drawing.Point(25, 77);
            this.ClassLabel.Name = "ClassLabel";
            this.ClassLabel.Size = new System.Drawing.Size(131, 25);
            this.ClassLabel.TabIndex = 13;
            this.ClassLabel.Text = "Character Class";
            // 
            // raceComboBox
            // 
            this.raceComboBox.FormattingEnabled = true;
            this.raceComboBox.Items.AddRange(new object[] {
            "Elf",
            "Orc"});
            this.raceComboBox.Location = new System.Drawing.Point(25, 41);
            this.raceComboBox.Name = "raceComboBox";
            this.raceComboBox.Size = new System.Drawing.Size(182, 33);
            this.raceComboBox.TabIndex = 16;
            // 
            // characterClassComboBox
            // 
            this.characterClassComboBox.FormattingEnabled = true;
            this.characterClassComboBox.Items.AddRange(new object[] {
            "Sorcerer",
            "Ranger",
            "Barbarian"});
            this.characterClassComboBox.Location = new System.Drawing.Point(25, 105);
            this.characterClassComboBox.Name = "characterClassComboBox";
            this.characterClassComboBox.Size = new System.Drawing.Size(182, 33);
            this.characterClassComboBox.TabIndex = 17;
            // 
            // characterEquipmentLabel
            // 
            this.characterEquipmentLabel.AutoSize = true;
            this.characterEquipmentLabel.Location = new System.Drawing.Point(473, 13);
            this.characterEquipmentLabel.Name = "characterEquipmentLabel";
            this.characterEquipmentLabel.Size = new System.Drawing.Size(177, 25);
            this.characterEquipmentLabel.TabIndex = 18;
            this.characterEquipmentLabel.Text = "Character Equipment";
            // 
            // characterListBox
            // 
            this.characterListBox.FormattingEnabled = true;
            this.characterListBox.HorizontalScrollbar = true;
            this.characterListBox.ItemHeight = 25;
            this.characterListBox.Location = new System.Drawing.Point(25, 233);
            this.characterListBox.Name = "characterListBox";
            this.characterListBox.Size = new System.Drawing.Size(180, 129);
            this.characterListBox.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 463);
            this.Controls.Add(this.characterListBox);
            this.Controls.Add(this.characterEquipmentLabel);
            this.Controls.Add(this.characterClassComboBox);
            this.Controls.Add(this.raceComboBox);
            this.Controls.Add(this.ClassLabel);
            this.Controls.Add(this.RaceLabel);
            this.Controls.Add(this.listView3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.characterEquipmentList);
            this.Controls.Add(this.addEquipmentButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addEquipmentButton;
        private System.Windows.Forms.ListBox characterEquipmentList;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView listView3;
        private System.Windows.Forms.Label RaceLabel;
        private System.Windows.Forms.Label ClassLabel;
        private System.Windows.Forms.ComboBox raceComboBox;
        private System.Windows.Forms.ComboBox characterClassComboBox;
        private System.Windows.Forms.Label characterEquipmentLabel;
        private System.Windows.Forms.ListBox characterListBox;
    }
}

