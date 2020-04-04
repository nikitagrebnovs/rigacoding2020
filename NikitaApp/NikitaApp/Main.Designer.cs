namespace NikitaApp
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonGallery = new System.Windows.Forms.Button();
            this.buttonAddObject = new System.Windows.Forms.Button();
            this.buttonView = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.menu21 = new NikitaApp.Menu2();
            this.addObject1 = new NikitaApp.AddObject();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(72)))));
            this.panel1.Controls.Add(this.buttonGallery);
            this.panel1.Controls.Add(this.buttonAddObject);
            this.panel1.Controls.Add(this.buttonView);
            this.panel1.Controls.Add(this.panelLogo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(176, 625);
            this.panel1.TabIndex = 0;
            // 
            // buttonGallery
            // 
            this.buttonGallery.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(72)))));
            this.buttonGallery.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonGallery.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonGallery.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonGallery.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonGallery.FlatAppearance.BorderSize = 0;
            this.buttonGallery.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGallery.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGallery.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonGallery.Image = ((System.Drawing.Image)(resources.GetObject("buttonGallery.Image")));
            this.buttonGallery.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonGallery.Location = new System.Drawing.Point(0, 249);
            this.buttonGallery.Name = "buttonGallery";
            this.buttonGallery.Size = new System.Drawing.Size(176, 83);
            this.buttonGallery.TabIndex = 4;
            this.buttonGallery.Text = "Galerija";
            this.buttonGallery.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonGallery.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonGallery.UseVisualStyleBackColor = false;
            // 
            // buttonAddObject
            // 
            this.buttonAddObject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(72)))));
            this.buttonAddObject.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonAddObject.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAddObject.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonAddObject.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonAddObject.FlatAppearance.BorderSize = 0;
            this.buttonAddObject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddObject.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddObject.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonAddObject.Image = ((System.Drawing.Image)(resources.GetObject("buttonAddObject.Image")));
            this.buttonAddObject.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAddObject.Location = new System.Drawing.Point(0, 166);
            this.buttonAddObject.Name = "buttonAddObject";
            this.buttonAddObject.Size = new System.Drawing.Size(176, 83);
            this.buttonAddObject.TabIndex = 3;
            this.buttonAddObject.Text = "Jauns objekts";
            this.buttonAddObject.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAddObject.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonAddObject.UseVisualStyleBackColor = false;
            this.buttonAddObject.Click += new System.EventHandler(this.buttonAddObject_Click);
            // 
            // buttonView
            // 
            this.buttonView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(72)))));
            this.buttonView.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonView.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonView.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonView.FlatAppearance.BorderSize = 0;
            this.buttonView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonView.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonView.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonView.Image = ((System.Drawing.Image)(resources.GetObject("buttonView.Image")));
            this.buttonView.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonView.Location = new System.Drawing.Point(0, 83);
            this.buttonView.Name = "buttonView";
            this.buttonView.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonView.Size = new System.Drawing.Size(176, 83);
            this.buttonView.TabIndex = 2;
            this.buttonView.Text = "Pārskats";
            this.buttonView.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonView.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonView.UseVisualStyleBackColor = false;
            this.buttonView.Click += new System.EventHandler(this.button1_Click);
            this.buttonView.MouseHover += new System.EventHandler(this.button1_MouseHover);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(50)))), ((int)(((byte)(57)))));
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(176, 83);
            this.panelLogo.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(50)))), ((int)(((byte)(57)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(176, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(673, 83);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.menu21);
            this.panel3.Controls.Add(this.addObject1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(176, 83);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(673, 542);
            this.panel3.TabIndex = 2;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // menu21
            // 
            this.menu21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(242)))), ((int)(((byte)(247)))));
            this.menu21.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menu21.Location = new System.Drawing.Point(0, 0);
            this.menu21.Name = "menu21";
            this.menu21.Size = new System.Drawing.Size(673, 542);
            this.menu21.TabIndex = 2;
            this.menu21.Load += new System.EventHandler(this.menu21_Load);
            // 
            // addObject1
            // 
            this.addObject1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addObject1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.addObject1.Location = new System.Drawing.Point(0, 0);
            this.addObject1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addObject1.Name = "addObject1";
            this.addObject1.Size = new System.Drawing.Size(673, 542);
            this.addObject1.TabIndex = 1;
            this.addObject1.Load += new System.EventHandler(this.addObject1_Load_1);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(849, 625);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.Opacity = 0.98D;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button buttonAddObject;
        private System.Windows.Forms.Button buttonGallery;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private AddObject addObject1;
        private Menu2 menu21;
        private System.Windows.Forms.Button buttonView;
    }
}