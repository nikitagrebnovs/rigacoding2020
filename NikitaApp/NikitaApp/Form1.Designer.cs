namespace NikitaApp
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonGallery = new System.Windows.Forms.Button();
            this.buttonAddObject = new System.Windows.Forms.Button();
            this.buttonView = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.addObject1 = new NikitaApp.AddObject();
            this.parskats1 = new NikitaApp.Parskats();
            this.panel1.SuspendLayout();
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
            this.panel1.Location = new System.Drawing.Point(0, 42);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(155, 537);
            this.panel1.TabIndex = 3;
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
            this.buttonGallery.Location = new System.Drawing.Point(0, 153);
            this.buttonGallery.Name = "buttonGallery";
            this.buttonGallery.Size = new System.Drawing.Size(155, 70);
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
            this.buttonAddObject.Location = new System.Drawing.Point(0, 83);
            this.buttonAddObject.Name = "buttonAddObject";
            this.buttonAddObject.Size = new System.Drawing.Size(155, 70);
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
            this.buttonView.Location = new System.Drawing.Point(0, 13);
            this.buttonView.Name = "buttonView";
            this.buttonView.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonView.Size = new System.Drawing.Size(155, 70);
            this.buttonView.TabIndex = 2;
            this.buttonView.Text = "Pārskats";
            this.buttonView.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonView.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonView.UseVisualStyleBackColor = false;
            this.buttonView.Click += new System.EventHandler(this.buttonView_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(72)))));
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(155, 13);
            this.panelLogo.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(50)))), ((int)(((byte)(57)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(817, 42);
            this.panel2.TabIndex = 4;
            // 
            // addObject1
            // 
            this.addObject1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.addObject1.Location = new System.Drawing.Point(152, 42);
            this.addObject1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addObject1.Name = "addObject1";
            this.addObject1.Size = new System.Drawing.Size(670, 542);
            this.addObject1.TabIndex = 5;
            // 
            // parskats1
            // 
            this.parskats1.Location = new System.Drawing.Point(152, 42);
            this.parskats1.Name = "parskats1";
            this.parskats1.Size = new System.Drawing.Size(673, 537);
            this.parskats1.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 579);
            this.Controls.Add(this.parskats1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.addObject1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonGallery;
        private System.Windows.Forms.Button buttonAddObject;
        private System.Windows.Forms.Button buttonView;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelLogo;
        private AddObject addObject1;
        private Parskats parskats1;
    }
}