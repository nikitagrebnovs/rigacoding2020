namespace FirstWindowsApp
{
    partial class reigsterForm
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
            this.userpassField = new System.Windows.Forms.TextBox();
            this.userloginField = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.UserSurnameField = new System.Windows.Forms.TextBox();
            this.userNameField = new System.Windows.Forms.TextBox();
            this.regbotton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.exit = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // userpassField
            // 
            this.userpassField.Font = new System.Drawing.Font("Times New Roman", 26.29565F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userpassField.ForeColor = System.Drawing.Color.Gray;
            this.userpassField.Location = new System.Drawing.Point(483, 237);
            this.userpassField.MaxLength = 14;
            this.userpassField.Name = "userpassField";
            this.userpassField.Size = new System.Drawing.Size(293, 56);
            this.userpassField.TabIndex = 4;
            this.userpassField.TextChanged += new System.EventHandler(this.userpassField_TextChanged);
            this.userpassField.Enter += new System.EventHandler(this.userpassField_Enter);
            this.userpassField.Leave += new System.EventHandler(this.userpassField_Leave);
            // 
            // userloginField
            // 
            this.userloginField.Font = new System.Drawing.Font("Times New Roman", 26.29565F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userloginField.ForeColor = System.Drawing.Color.Gray;
            this.userloginField.Location = new System.Drawing.Point(84, 237);
            this.userloginField.Multiline = true;
            this.userloginField.Name = "userloginField";
            this.userloginField.Size = new System.Drawing.Size(293, 64);
            this.userloginField.TabIndex = 2;
            this.userloginField.Enter += new System.EventHandler(this.userloginField_Enter);
            this.userloginField.Leave += new System.EventHandler(this.userloginField_Leave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SlateBlue;
            this.panel1.Controls.Add(this.UserSurnameField);
            this.panel1.Controls.Add(this.userNameField);
            this.panel1.Controls.Add(this.regbotton);
            this.panel1.Controls.Add(this.userpassField);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.userloginField);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 1;
            // 
            // UserSurnameField
            // 
            this.UserSurnameField.Font = new System.Drawing.Font("Times New Roman", 26.29565F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserSurnameField.ForeColor = System.Drawing.Color.Gray;
            this.UserSurnameField.Location = new System.Drawing.Point(483, 143);
            this.UserSurnameField.Multiline = true;
            this.UserSurnameField.Name = "UserSurnameField";
            this.UserSurnameField.Size = new System.Drawing.Size(293, 64);
            this.UserSurnameField.TabIndex = 7;
            this.UserSurnameField.Enter += new System.EventHandler(this.UserSurnameField_Enter);
            this.UserSurnameField.Leave += new System.EventHandler(this.UserSurnameField_Leave);
            // 
            // userNameField
            // 
            this.userNameField.Font = new System.Drawing.Font("Times New Roman", 26.29565F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameField.ForeColor = System.Drawing.Color.Gray;
            this.userNameField.Location = new System.Drawing.Point(84, 143);
            this.userNameField.Multiline = true;
            this.userNameField.Name = "userNameField";
            this.userNameField.Size = new System.Drawing.Size(293, 64);
            this.userNameField.TabIndex = 6;
            this.userNameField.Enter += new System.EventHandler(this.userNameField_Enter);
            this.userNameField.Leave += new System.EventHandler(this.userNameField_Leave);
            // 
            // regbotton
            // 
            this.regbotton.BackColor = System.Drawing.Color.LimeGreen;
            this.regbotton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.regbotton.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.regbotton.FlatAppearance.BorderSize = 0;
            this.regbotton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Brown;
            this.regbotton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.regbotton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.regbotton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.77391F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regbotton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.regbotton.Location = new System.Drawing.Point(263, 331);
            this.regbotton.Name = "regbotton";
            this.regbotton.Size = new System.Drawing.Size(281, 58);
            this.regbotton.TabIndex = 5;
            this.regbotton.Text = "Registration";
            this.regbotton.UseVisualStyleBackColor = false;
            this.regbotton.Click += new System.EventHandler(this.regbotton_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Coral;
            this.panel2.Controls.Add(this.exit);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 100);
            this.panel2.TabIndex = 0;
            // 
            // exit
            // 
            this.exit.AutoSize = true;
            this.exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit.Dock = System.Windows.Forms.DockStyle.Right;
            this.exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.89565F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.Location = new System.Drawing.Point(775, 0);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(25, 24);
            this.exit.TabIndex = 1;
            this.exit.Text = "X";
            this.exit.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 23.7913F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(800, 100);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registration";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.SlateBlue;
            this.pictureBox2.Image = global::FirstWindowsApp.Properties.Resources._lock;
            this.pictureBox2.Location = new System.Drawing.Point(413, 237);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(64, 64);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.SlateBlue;
            this.pictureBox1.Image = global::FirstWindowsApp.Properties.Resources.user;
            this.pictureBox1.Location = new System.Drawing.Point(14, 237);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // reigsterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "reigsterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "reigsterForm";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.reigsterForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.reigsterForm_MouseMove);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox userpassField;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox userloginField;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button regbotton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label exit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox UserSurnameField;
        private System.Windows.Forms.TextBox userNameField;
    }
}