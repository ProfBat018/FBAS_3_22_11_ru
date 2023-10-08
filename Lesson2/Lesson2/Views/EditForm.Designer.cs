namespace Lesson2.Views
{
    partial class EditForm
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
            taskPictureBox = new PictureBox();
            leftPanel = new TableLayoutPanel();
            makeLabel = new Label();
            nameTextBox = new TextBox();
            productionLabel = new Label();
            duePicker = new DateTimePicker();
            editButton = new Button();
            mainPanel = new Panel();
            ((System.ComponentModel.ISupportInitialize)taskPictureBox).BeginInit();
            leftPanel.SuspendLayout();
            mainPanel.SuspendLayout();
            SuspendLayout();
            // 
            // taskPictureBox
            // 
            leftPanel.SetColumnSpan(taskPictureBox, 2);
            taskPictureBox.Cursor = Cursors.Hand;
            taskPictureBox.Dock = DockStyle.Fill;
            taskPictureBox.Location = new Point(3, 129);
            taskPictureBox.Name = "taskPictureBox";
            taskPictureBox.Size = new Size(433, 303);
            taskPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            taskPictureBox.TabIndex = 10;
            taskPictureBox.TabStop = false;
            // 
            // leftPanel
            // 
            leftPanel.ColumnCount = 2;
            leftPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 192F));
            leftPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 8F));
            leftPanel.Controls.Add(makeLabel, 0, 0);
            leftPanel.Controls.Add(nameTextBox, 1, 0);
            leftPanel.Controls.Add(productionLabel, 0, 1);
            leftPanel.Controls.Add(duePicker, 1, 1);
            leftPanel.Controls.Add(editButton, 1, 2);
            leftPanel.Controls.Add(taskPictureBox, 0, 2);
            leftPanel.Dock = DockStyle.Fill;
            leftPanel.Location = new Point(0, 0);
            leftPanel.Name = "leftPanel";
            leftPanel.RowCount = 3;
            leftPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 72F));
            leftPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 54F));
            leftPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 309F));
            leftPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 8F));
            leftPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            leftPanel.Size = new Size(439, 523);
            leftPanel.TabIndex = 0;
            // 
            // makeLabel
            // 
            makeLabel.Anchor = AnchorStyles.None;
            makeLabel.AutoSize = true;
            makeLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            makeLabel.Location = new Point(47, 15);
            makeLabel.Name = "makeLabel";
            makeLabel.Size = new Size(97, 41);
            makeLabel.TabIndex = 0;
            makeLabel.Text = "Name";
            // 
            // nameTextBox
            // 
            nameTextBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            nameTextBox.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            nameTextBox.Location = new Point(195, 14);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(241, 43);
            nameTextBox.TabIndex = 4;
            // 
            // productionLabel
            // 
            productionLabel.Anchor = AnchorStyles.None;
            productionLabel.AutoSize = true;
            productionLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            productionLabel.Location = new Point(60, 78);
            productionLabel.Name = "productionLabel";
            productionLabel.Size = new Size(72, 41);
            productionLabel.TabIndex = 3;
            productionLabel.Text = "Due";
            // 
            // duePicker
            // 
            duePicker.CustomFormat = "dd/mm/yyyy";
            duePicker.Dock = DockStyle.Fill;
            duePicker.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            duePicker.Format = DateTimePickerFormat.Custom;
            duePicker.Location = new Point(195, 75);
            duePicker.Name = "duePicker";
            duePicker.Size = new Size(241, 43);
            duePicker.TabIndex = 9;
            // 
            // editButton
            // 
            leftPanel.SetColumnSpan(editButton, 2);
            editButton.Dock = DockStyle.Fill;
            editButton.Location = new Point(3, 438);
            editButton.Name = "editButton";
            editButton.Size = new Size(433, 82);
            editButton.TabIndex = 7;
            editButton.Text = "Edit";
            editButton.UseVisualStyleBackColor = true;
            // 
            // mainPanel
            // 
            mainPanel.Controls.Add(leftPanel);
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Location = new Point(0, 0);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(439, 523);
            mainPanel.TabIndex = 3;
            // 
            // EditForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(439, 523);
            Controls.Add(mainPanel);
            Name = "EditForm";
            Text = "EditForm";
            ((System.ComponentModel.ISupportInitialize)taskPictureBox).EndInit();
            leftPanel.ResumeLayout(false);
            leftPanel.PerformLayout();
            mainPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private PictureBox taskPictureBox;
        private TableLayoutPanel leftPanel;
        private Label makeLabel;
        private TextBox nameTextBox;
        private Label productionLabel;
        private DateTimePicker duePicker;
        private Button editButton;
        private Panel mainPanel;
    }
}