namespace DataTableLesson
{
    partial class MainWindow
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
            tableLayoutPanel1 = new TableLayoutPanel();
            tablesBox = new ComboBox();
            dbDataGridView = new DataGridView();
            panel1 = new Panel();
            addBtn = new Button();
            deleteBtn = new Button();
            SaveBtn = new Button();
            getAllDatabtn = new Button();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dbDataGridView).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(tablesBox, 0, 0);
            tableLayoutPanel1.Controls.Add(dbDataGridView, 0, 1);
            tableLayoutPanel1.Controls.Add(panel1, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 7.55555534F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 92.44444F));
            tableLayoutPanel1.Size = new Size(800, 450);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tablesBox
            // 
            tablesBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tablesBox.FormattingEnabled = true;
            tablesBox.Location = new Point(3, 5);
            tablesBox.Name = "tablesBox";
            tablesBox.Size = new Size(394, 23);
            tablesBox.TabIndex = 0;
            // 
            // dbDataGridView
            // 
            dbDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tableLayoutPanel1.SetColumnSpan(dbDataGridView, 2);
            dbDataGridView.Dock = DockStyle.Fill;
            dbDataGridView.Location = new Point(3, 37);
            dbDataGridView.Name = "dbDataGridView";
            dbDataGridView.RowTemplate.Height = 25;
            dbDataGridView.Size = new Size(794, 410);
            dbDataGridView.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.Controls.Add(addBtn);
            panel1.Controls.Add(deleteBtn);
            panel1.Controls.Add(SaveBtn);
            panel1.Controls.Add(getAllDatabtn);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(403, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(394, 28);
            panel1.TabIndex = 2;
            // 
            // addBtn
            // 
            addBtn.Dock = DockStyle.Left;
            addBtn.Location = new Point(253, 0);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(75, 28);
            addBtn.TabIndex = 3;
            addBtn.Text = "Add";
            addBtn.UseVisualStyleBackColor = true;
            // 
            // deleteBtn
            // 
            deleteBtn.Dock = DockStyle.Left;
            deleteBtn.Location = new Point(178, 0);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(75, 28);
            deleteBtn.TabIndex = 2;
            deleteBtn.Text = "Delete";
            deleteBtn.UseVisualStyleBackColor = true;
            // 
            // SaveBtn
            // 
            SaveBtn.Dock = DockStyle.Left;
            SaveBtn.Location = new Point(103, 0);
            SaveBtn.Name = "SaveBtn";
            SaveBtn.Size = new Size(75, 28);
            SaveBtn.TabIndex = 1;
            SaveBtn.Text = "Save";
            SaveBtn.UseVisualStyleBackColor = true;
            SaveBtn.Click += SaveBtn_Click;
            // 
            // getAllDatabtn
            // 
            getAllDatabtn.Dock = DockStyle.Left;
            getAllDatabtn.Location = new Point(0, 0);
            getAllDatabtn.Name = "getAllDatabtn";
            getAllDatabtn.Size = new Size(103, 28);
            getAllDatabtn.TabIndex = 0;
            getAllDatabtn.Text = "Get All Data";
            getAllDatabtn.UseVisualStyleBackColor = true;
            getAllDatabtn.Click += getAllDatabtn_Click;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            Name = "MainWindow";
            Text = "MainWindow";
            Load += MainWindow_Load;
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dbDataGridView).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private ComboBox tablesBox;
        private DataGridView dbDataGridView;
        private Panel panel1;
        private Button addBtn;
        private Button deleteBtn;
        private Button SaveBtn;
        private Button getAllDatabtn;
    }
}