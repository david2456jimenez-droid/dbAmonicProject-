namespace FormCountries
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureAmonic = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            textUsername = new TextBox();
            textPassword = new TextBox();
            btnLogin = new Button();
            btnExit = new Button();
            labelsegundos = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pictureAmonic).BeginInit();
            SuspendLayout();
            // 
            // pictureAmonic
            // 
            pictureAmonic.Image = (Image)resources.GetObject("pictureAmonic.Image");
            pictureAmonic.Location = new Point(190, 44);
            pictureAmonic.Name = "pictureAmonic";
            pictureAmonic.Size = new Size(624, 209);
            pictureAmonic.TabIndex = 0;
            pictureAmonic.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(153, 292);
            label1.Name = "label1";
            label1.Size = new Size(148, 38);
            label1.TabIndex = 1;
            label1.Text = "Username:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(153, 385);
            label2.Name = "label2";
            label2.Size = new Size(138, 38);
            label2.TabIndex = 2;
            label2.Text = "Password:";
            // 
            // textUsername
            // 
            textUsername.Location = new Point(307, 292);
            textUsername.Multiline = true;
            textUsername.Name = "textUsername";
            textUsername.Size = new Size(507, 49);
            textUsername.TabIndex = 3;
            // 
            // textPassword
            // 
            textPassword.Location = new Point(307, 385);
            textPassword.Multiline = true;
            textPassword.Name = "textPassword";
            textPassword.Size = new Size(507, 49);
            textPassword.TabIndex = 4;
            textPassword.TextChanged += textPassword_TextChanged;
            // 
            // btnLogin
            // 
            btnLogin.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.Location = new Point(362, 460);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(161, 43);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExit.Location = new Point(575, 460);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(159, 43);
            btnExit.TabIndex = 6;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // labelsegundos
            // 
            labelsegundos.AutoSize = true;
            labelsegundos.BackColor = SystemColors.Control;
            labelsegundos.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelsegundos.ForeColor = SystemColors.Highlight;
            labelsegundos.Location = new Point(153, 483);
            labelsegundos.Name = "labelsegundos";
            labelsegundos.Size = new Size(0, 25);
            labelsegundos.TabIndex = 7;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(930, 543);
            Controls.Add(labelsegundos);
            Controls.Add(btnExit);
            Controls.Add(btnLogin);
            Controls.Add(textPassword);
            Controls.Add(textUsername);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureAmonic);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureAmonic).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureAmonic;
        private Label label1;
        private Label label2;
        private TextBox textUsername;
        private TextBox textPassword;
        private Button btnLogin;
        private Button btnExit;
        private Label labelsegundos;
        private System.Windows.Forms.Timer timer1;
    }
}
