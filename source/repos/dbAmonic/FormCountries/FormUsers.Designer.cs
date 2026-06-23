namespace FormCountries
{
    partial class Amonic
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
            dataUsers = new DataGridView();
            comboOffices = new ComboBox();
            label1 = new Label();
            menuStrip1 = new MenuStrip();
            addUsersToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataUsers).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dataUsers
            // 
            dataUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataUsers.Location = new Point(12, 99);
            dataUsers.Name = "dataUsers";
            dataUsers.RowHeadersWidth = 51;
            dataUsers.Size = new Size(759, 362);
            dataUsers.TabIndex = 0;
            // 
            // comboOffices
            // 
            comboOffices.DropDownStyle = ComboBoxStyle.DropDownList;
            comboOffices.FormattingEnabled = true;
            comboOffices.Location = new Point(95, 45);
            comboOffices.Name = "comboOffices";
            comboOffices.Size = new Size(151, 28);
            comboOffices.TabIndex = 1;
            comboOffices.SelectedIndexChanged += comboOffices_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 45);
            label1.Name = "label1";
            label1.Size = new Size(67, 25);
            label1.TabIndex = 2;
            label1.Text = "Offices";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { addUsersToolStripMenuItem, exitToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "menuStrip1";
            // 
            // addUsersToolStripMenuItem
            // 
            addUsersToolStripMenuItem.Name = "addUsersToolStripMenuItem";
            addUsersToolStripMenuItem.Size = new Size(90, 24);
            addUsersToolStripMenuItem.Text = "Add Users";
            addUsersToolStripMenuItem.Click += addUsersToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(47, 24);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // button1
            // 
            button1.Location = new Point(16, 489);
            button1.Name = "button1";
            button1.Size = new Size(154, 29);
            button1.TabIndex = 4;
            button1.Text = "Change Role";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(197, 489);
            button2.Name = "button2";
            button2.Size = new Size(161, 29);
            button2.TabIndex = 5;
            button2.Text = "Enable/Disable Login";
            button2.UseVisualStyleBackColor = true;
            // 
            // Amonic
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 598);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(comboOffices);
            Controls.Add(dataUsers);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Amonic";
            Text = "FormUsers";
            Load += Amonic_Load;
            ((System.ComponentModel.ISupportInitialize)dataUsers).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataUsers;
        private ComboBox comboOffices;
        private Label label1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem addUsersToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private Button button1;
        private Button button2;
    }
}