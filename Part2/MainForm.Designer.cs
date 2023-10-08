namespace Part2
{
    partial class MainForm
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
            FormPanel = new TableLayoutPanel();
            surnameTextBox = new TextBox();
            imageLabel = new Label();
            birtdateLabel = new Label();
            surnameLabel = new Label();
            nameLabel = new Label();
            addButton = new Button();
            button2 = new Button();
            browseButton = new Button();
            nameTextBox = new TextBox();
            birthDatePicker = new DateTimePicker();
            rightPanel = new Panel();
            rightDownPanel = new Panel();
            peopleListBox = new ListBox();
            rightUpPanel = new Panel();
            personPictureBox = new PictureBox();
            FormPanel.SuspendLayout();
            rightPanel.SuspendLayout();
            rightDownPanel.SuspendLayout();
            rightUpPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)personPictureBox).BeginInit();
            SuspendLayout();
            // 
            // FormPanel
            // 
            FormPanel.ColumnCount = 2;
            FormPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            FormPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            FormPanel.Controls.Add(surnameTextBox, 1, 1);
            FormPanel.Controls.Add(imageLabel, 0, 3);
            FormPanel.Controls.Add(birtdateLabel, 0, 2);
            FormPanel.Controls.Add(surnameLabel, 0, 1);
            FormPanel.Controls.Add(nameLabel, 0, 0);
            FormPanel.Controls.Add(addButton, 0, 4);
            FormPanel.Controls.Add(button2, 1, 4);
            FormPanel.Controls.Add(browseButton, 1, 3);
            FormPanel.Controls.Add(nameTextBox, 1, 0);
            FormPanel.Controls.Add(birthDatePicker, 1, 2);
            FormPanel.Dock = DockStyle.Left;
            FormPanel.Location = new Point(0, 0);
            FormPanel.Name = "FormPanel";
            FormPanel.RowCount = 6;
            FormPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50.25641F));
            FormPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 49.74359F));
            FormPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 84F));
            FormPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 51F));
            FormPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 70F));
            FormPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 137F));
            FormPanel.Size = new Size(335, 478);
            FormPanel.TabIndex = 0;
            // 
            // surnameTextBox
            // 
            surnameTextBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            surnameTextBox.Location = new Point(170, 88);
            surnameTextBox.Name = "surnameTextBox";
            surnameTextBox.Size = new Size(162, 27);
            surnameTextBox.TabIndex = 13;
            // 
            // imageLabel
            // 
            imageLabel.Anchor = AnchorStyles.None;
            imageLabel.AutoSize = true;
            imageLabel.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            imageLabel.Location = new Point(38, 226);
            imageLabel.Name = "imageLabel";
            imageLabel.Size = new Size(91, 37);
            imageLabel.TabIndex = 12;
            imageLabel.Text = "Image";
            // 
            // birtdateLabel
            // 
            birtdateLabel.Anchor = AnchorStyles.None;
            birtdateLabel.AutoSize = true;
            birtdateLabel.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            birtdateLabel.Location = new Point(19, 158);
            birtdateLabel.Name = "birtdateLabel";
            birtdateLabel.Size = new Size(128, 37);
            birtdateLabel.TabIndex = 11;
            birtdateLabel.Text = "BirthDate";
            // 
            // surnameLabel
            // 
            surnameLabel.Anchor = AnchorStyles.None;
            surnameLabel.AutoSize = true;
            surnameLabel.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            surnameLabel.Location = new Point(23, 83);
            surnameLabel.Name = "surnameLabel";
            surnameLabel.Size = new Size(121, 37);
            surnameLabel.TabIndex = 10;
            surnameLabel.Text = "Surname";
            // 
            // nameLabel
            // 
            nameLabel.Anchor = AnchorStyles.None;
            nameLabel.AutoSize = true;
            nameLabel.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            nameLabel.Location = new Point(39, 15);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(88, 37);
            nameLabel.TabIndex = 0;
            nameLabel.Text = "Name";
            // 
            // addButton
            // 
            addButton.Dock = DockStyle.Fill;
            addButton.Location = new Point(3, 273);
            addButton.Name = "addButton";
            addButton.Size = new Size(161, 64);
            addButton.TabIndex = 4;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // button2
            // 
            button2.Dock = DockStyle.Fill;
            button2.Location = new Point(170, 273);
            button2.Name = "button2";
            button2.Size = new Size(162, 64);
            button2.TabIndex = 5;
            button2.Text = "Delete";
            button2.UseVisualStyleBackColor = true;
            // 
            // browseButton
            // 
            browseButton.Dock = DockStyle.Fill;
            browseButton.Location = new Point(170, 222);
            browseButton.Name = "browseButton";
            browseButton.Size = new Size(162, 45);
            browseButton.TabIndex = 6;
            browseButton.Text = "Browse";
            browseButton.UseVisualStyleBackColor = true;
            browseButton.Click += browseButton_Click;
            // 
            // nameTextBox
            // 
            nameTextBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            nameTextBox.Location = new Point(170, 20);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(162, 27);
            nameTextBox.TabIndex = 7;
            // 
            // birthDatePicker
            // 
            birthDatePicker.Anchor = AnchorStyles.None;
            birthDatePicker.CustomFormat = "dd/mm/yyyy";
            birthDatePicker.Format = DateTimePickerFormat.Custom;
            birthDatePicker.Location = new Point(170, 163);
            birthDatePicker.Name = "birthDatePicker";
            birthDatePicker.Size = new Size(162, 27);
            birthDatePicker.TabIndex = 14;
            birthDatePicker.Value = new DateTime(2023, 10, 5, 17, 51, 43, 0);
            // 
            // rightPanel
            // 
            rightPanel.Controls.Add(rightDownPanel);
            rightPanel.Controls.Add(rightUpPanel);
            rightPanel.Dock = DockStyle.Fill;
            rightPanel.Location = new Point(335, 0);
            rightPanel.Name = "rightPanel";
            rightPanel.Size = new Size(548, 478);
            rightPanel.TabIndex = 1;
            // 
            // rightDownPanel
            // 
            rightDownPanel.Controls.Add(peopleListBox);
            rightDownPanel.Dock = DockStyle.Fill;
            rightDownPanel.Location = new Point(0, 192);
            rightDownPanel.Name = "rightDownPanel";
            rightDownPanel.Size = new Size(548, 286);
            rightDownPanel.TabIndex = 1;
            // 
            // peopleListBox
            // 
            peopleListBox.Dock = DockStyle.Fill;
            peopleListBox.FormattingEnabled = true;
            peopleListBox.ItemHeight = 20;
            peopleListBox.Location = new Point(0, 0);
            peopleListBox.Name = "peopleListBox";
            peopleListBox.Size = new Size(548, 286);
            peopleListBox.TabIndex = 0;
            peopleListBox.SelectedIndexChanged += peopleListBox_SelectedIndexChanged;
            // 
            // rightUpPanel
            // 
            rightUpPanel.Controls.Add(personPictureBox);
            rightUpPanel.Dock = DockStyle.Top;
            rightUpPanel.Location = new Point(0, 0);
            rightUpPanel.Name = "rightUpPanel";
            rightUpPanel.Size = new Size(548, 192);
            rightUpPanel.TabIndex = 0;
            // 
            // personPictureBox
            // 
            personPictureBox.Dock = DockStyle.Fill;
            personPictureBox.Location = new Point(0, 0);
            personPictureBox.Name = "personPictureBox";
            personPictureBox.Size = new Size(548, 192);
            personPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            personPictureBox.TabIndex = 0;
            personPictureBox.TabStop = false;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(883, 478);
            Controls.Add(rightPanel);
            Controls.Add(FormPanel);
            Name = "MainForm";
            Text = "MainForm";
            FormPanel.ResumeLayout(false);
            FormPanel.PerformLayout();
            rightPanel.ResumeLayout(false);
            rightDownPanel.ResumeLayout(false);
            rightUpPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)personPictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel FormPanel;
        private Label nameLabel;
        private Button addButton;
        private Button button2;
        private Button browseButton;
        private TextBox nameTextBox;
        private Panel rightPanel;
        private Panel rightDownPanel;
        private Panel rightUpPanel;
        private PictureBox personPictureBox;
        private Label imageLabel;
        private Label birtdateLabel;
        private Label surnameLabel;
        private TextBox surnameTextBox;
        private DateTimePicker birthDatePicker;
        private ListBox peopleListBox;
    }
}