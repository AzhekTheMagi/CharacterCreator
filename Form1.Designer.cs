
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
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.characterProfileListView = new System.Windows.Forms.ListView();
            this.columnRace = new System.Windows.Forms.ColumnHeader();
            this.columnName = new System.Windows.Forms.ColumnHeader();
            this.columnDescription = new System.Windows.Forms.ColumnHeader();
            this.RaceLabel = new System.Windows.Forms.Label();
            this.ClassLabel = new System.Windows.Forms.Label();
            this.raceComboBox = new System.Windows.Forms.ComboBox();
            this.characterClassComboBox = new System.Windows.Forms.ComboBox();
            this.characterEquipmentLabel = new System.Windows.Forms.Label();
            this.characterListBox = new System.Windows.Forms.ListBox();
            this.partyInventoryListBox = new System.Windows.Forms.ListBox();
            this.characterEquipmentListView = new System.Windows.Forms.ListView();
            this.columnEquipmentType = new System.Windows.Forms.ColumnHeader();
            this.columnEquipmentName = new System.Windows.Forms.ColumnHeader();
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
            this.label3.Location = new System.Drawing.Point(597, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Party Inventory";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(252, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "Character Profile";
            // 
            // characterProfileListView
            // 
            this.characterProfileListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnRace,
            this.columnName,
            this.columnDescription});
            this.characterProfileListView.HideSelection = false;
            this.characterProfileListView.Location = new System.Drawing.Point(252, 41);
            this.characterProfileListView.Name = "characterProfileListView";
            this.characterProfileListView.Size = new System.Drawing.Size(527, 146);
            this.characterProfileListView.TabIndex = 11;
            this.characterProfileListView.UseCompatibleStateImageBehavior = false;
            this.characterProfileListView.View = System.Windows.Forms.View.Details;
            // 
            // columnRace
            // 
            this.columnRace.Text = "Race";
            // 
            // columnName
            // 
            this.columnName.Text = "Name";
            this.columnName.Width = 120;
            // 
            // columnDescription
            // 
            this.columnDescription.Text = "Description";
            this.columnDescription.Width = 340;
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
            this.characterEquipmentLabel.Location = new System.Drawing.Point(252, 205);
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
            this.characterListBox.Click += new System.EventHandler(this.characterListBox_Click);
            // 
            // partyInventoryListBox
            // 
            this.partyInventoryListBox.FormattingEnabled = true;
            this.partyInventoryListBox.ItemHeight = 25;
            this.partyInventoryListBox.Location = new System.Drawing.Point(597, 234);
            this.partyInventoryListBox.Name = "partyInventoryListBox";
            this.partyInventoryListBox.Size = new System.Drawing.Size(180, 129);
            this.partyInventoryListBox.TabIndex = 20;
            // 
            // characterEquipmentListView
            // 
            this.characterEquipmentListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnEquipmentType,
            this.columnEquipmentName});
            this.characterEquipmentListView.HideSelection = false;
            this.characterEquipmentListView.Location = new System.Drawing.Point(252, 234);
            this.characterEquipmentListView.Name = "characterEquipmentListView";
            this.characterEquipmentListView.Size = new System.Drawing.Size(224, 129);
            this.characterEquipmentListView.TabIndex = 21;
            this.characterEquipmentListView.UseCompatibleStateImageBehavior = false;
            this.characterEquipmentListView.View = System.Windows.Forms.View.Details;
            // 
            // columnEquipmentType
            // 
            this.columnEquipmentType.Text = "Type";
            this.columnEquipmentType.Width = 100;
            // 
            // columnEquipmentName
            // 
            this.columnEquipmentName.Text = "Name";
            this.columnEquipmentName.Width = 100;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 463);
            this.Controls.Add(this.characterEquipmentListView);
            this.Controls.Add(this.partyInventoryListBox);
            this.Controls.Add(this.characterListBox);
            this.Controls.Add(this.characterEquipmentLabel);
            this.Controls.Add(this.characterClassComboBox);
            this.Controls.Add(this.raceComboBox);
            this.Controls.Add(this.ClassLabel);
            this.Controls.Add(this.RaceLabel);
            this.Controls.Add(this.characterProfileListView);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.addEquipmentButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addEquipmentButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView characterProfileListView;
        private System.Windows.Forms.Label RaceLabel;
        private System.Windows.Forms.Label ClassLabel;
        private System.Windows.Forms.ComboBox raceComboBox;
        private System.Windows.Forms.ComboBox characterClassComboBox;
        private System.Windows.Forms.Label characterEquipmentLabel;
        private System.Windows.Forms.ListBox characterListBox;
        private System.Windows.Forms.ColumnHeader columnRace;
        private System.Windows.Forms.ColumnHeader columnName;
        private System.Windows.Forms.ColumnHeader columnDescription;
        private System.Windows.Forms.ListBox partyInventoryListBox;
        private System.Windows.Forms.ListView characterEquipmentListView;
        private System.Windows.Forms.ColumnHeader columnEquipmentType;
        private System.Windows.Forms.ColumnHeader columnEquipmentName;
    }
}

