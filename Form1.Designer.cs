namespace Media
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
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.btnHelp = new System.Windows.Forms.Button();
            this.panelToolSubmenu = new System.Windows.Forms.Panel();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.btnLight = new System.Windows.Forms.Button();
            this.btnTool = new System.Windows.Forms.Button();
            this.panelFindSubmenu = new System.Windows.Forms.Panel();
            this.btnFindA = new System.Windows.Forms.Button();
            this.btnFindS = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            this.panelMediaSubmenu = new System.Windows.Forms.Panel();
            this.btnSong3 = new System.Windows.Forms.Button();
            this.btnSong2 = new System.Windows.Forms.Button();
            this.btnSong1 = new System.Windows.Forms.Button();
            this.btnMedia = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panelPlayer = new System.Windows.Forms.Panel();
            this.panelSideMenu.SuspendLayout();
            this.panelToolSubmenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.panelFindSubmenu.SuspendLayout();
            this.panelMediaSubmenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.AutoScroll = true;
            this.panelSideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.panelSideMenu.Controls.Add(this.btnHelp);
            this.panelSideMenu.Controls.Add(this.panelToolSubmenu);
            this.panelSideMenu.Controls.Add(this.btnTool);
            this.panelSideMenu.Controls.Add(this.panelFindSubmenu);
            this.panelSideMenu.Controls.Add(this.btnFind);
            this.panelSideMenu.Controls.Add(this.panelMediaSubmenu);
            this.panelSideMenu.Controls.Add(this.btnMedia);
            this.panelSideMenu.Controls.Add(this.panelLogo);
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.Location = new System.Drawing.Point(0, 0);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(250, 553);
            this.panelSideMenu.TabIndex = 0;
            // 
            // btnHelp
            // 
            this.btnHelp.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHelp.FlatAppearance.BorderSize = 0;
            this.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHelp.ForeColor = System.Drawing.Color.LightGray;
            this.btnHelp.Location = new System.Drawing.Point(0, 521);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnHelp.Size = new System.Drawing.Size(229, 45);
            this.btnHelp.TabIndex = 11;
            this.btnHelp.Text = "Help";
            this.btnHelp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHelp.UseVisualStyleBackColor = true;
            // 
            // panelToolSubmenu
            // 
            this.panelToolSubmenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.panelToolSubmenu.Controls.Add(this.trackBar1);
            this.panelToolSubmenu.Controls.Add(this.btnLight);
            this.panelToolSubmenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelToolSubmenu.Location = new System.Drawing.Point(0, 439);
            this.panelToolSubmenu.Name = "panelToolSubmenu";
            this.panelToolSubmenu.Size = new System.Drawing.Size(229, 82);
            this.panelToolSubmenu.TabIndex = 8;
            // 
            // trackBar1
            // 
            this.trackBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.trackBar1.LargeChange = 1;
            this.trackBar1.Location = new System.Drawing.Point(0, 40);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(229, 56);
            this.trackBar1.TabIndex = 0;
            this.trackBar1.Scroll += new System.EventHandler(this.TrackBar1_Scroll);
            // 
            // btnLight
            // 
            this.btnLight.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLight.FlatAppearance.BorderSize = 0;
            this.btnLight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLight.ForeColor = System.Drawing.Color.LightGray;
            this.btnLight.Location = new System.Drawing.Point(0, 0);
            this.btnLight.Name = "btnLight";
            this.btnLight.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnLight.Size = new System.Drawing.Size(229, 40);
            this.btnLight.TabIndex = 9;
            this.btnLight.Text = "Light";
            this.btnLight.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLight.UseVisualStyleBackColor = true;
            this.btnLight.Click += new System.EventHandler(this.BtnLight_Click);
            // 
            // btnTool
            // 
            this.btnTool.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTool.FlatAppearance.BorderSize = 0;
            this.btnTool.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTool.ForeColor = System.Drawing.Color.LightGray;
            this.btnTool.Location = new System.Drawing.Point(0, 394);
            this.btnTool.Name = "btnTool";
            this.btnTool.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnTool.Size = new System.Drawing.Size(229, 45);
            this.btnTool.TabIndex = 7;
            this.btnTool.Text = "Tool";
            this.btnTool.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTool.UseVisualStyleBackColor = true;
            this.btnTool.Click += new System.EventHandler(this.BtnTool_Click);
            // 
            // panelFindSubmenu
            // 
            this.panelFindSubmenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.panelFindSubmenu.Controls.Add(this.btnFindA);
            this.panelFindSubmenu.Controls.Add(this.btnFindS);
            this.panelFindSubmenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFindSubmenu.Location = new System.Drawing.Point(0, 312);
            this.panelFindSubmenu.Name = "panelFindSubmenu";
            this.panelFindSubmenu.Size = new System.Drawing.Size(229, 82);
            this.panelFindSubmenu.TabIndex = 4;
            // 
            // btnFindA
            // 
            this.btnFindA.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFindA.FlatAppearance.BorderSize = 0;
            this.btnFindA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFindA.ForeColor = System.Drawing.Color.LightGray;
            this.btnFindA.Location = new System.Drawing.Point(0, 40);
            this.btnFindA.Name = "btnFindA";
            this.btnFindA.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnFindA.Size = new System.Drawing.Size(229, 40);
            this.btnFindA.TabIndex = 5;
            this.btnFindA.Text = "Author";
            this.btnFindA.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFindA.UseVisualStyleBackColor = true;
            this.btnFindA.Click += new System.EventHandler(this.BtnFindA_Click);
            // 
            // btnFindS
            // 
            this.btnFindS.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFindS.FlatAppearance.BorderSize = 0;
            this.btnFindS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFindS.ForeColor = System.Drawing.Color.LightGray;
            this.btnFindS.Location = new System.Drawing.Point(0, 0);
            this.btnFindS.Name = "btnFindS";
            this.btnFindS.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnFindS.Size = new System.Drawing.Size(229, 40);
            this.btnFindS.TabIndex = 4;
            this.btnFindS.Text = "Singer";
            this.btnFindS.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFindS.UseVisualStyleBackColor = true;
            this.btnFindS.Click += new System.EventHandler(this.BtnFindS_Click);
            // 
            // btnFind
            // 
            this.btnFind.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFind.FlatAppearance.BorderSize = 0;
            this.btnFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFind.ForeColor = System.Drawing.Color.LightGray;
            this.btnFind.Location = new System.Drawing.Point(0, 267);
            this.btnFind.Name = "btnFind";
            this.btnFind.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnFind.Size = new System.Drawing.Size(229, 45);
            this.btnFind.TabIndex = 3;
            this.btnFind.Text = "Find";
            this.btnFind.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.BtnFind_Click);
            // 
            // panelMediaSubmenu
            // 
            this.panelMediaSubmenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.panelMediaSubmenu.Controls.Add(this.btnSong3);
            this.panelMediaSubmenu.Controls.Add(this.btnSong2);
            this.panelMediaSubmenu.Controls.Add(this.btnSong1);
            this.panelMediaSubmenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMediaSubmenu.Location = new System.Drawing.Point(0, 145);
            this.panelMediaSubmenu.Name = "panelMediaSubmenu";
            this.panelMediaSubmenu.Size = new System.Drawing.Size(229, 122);
            this.panelMediaSubmenu.TabIndex = 2;
            // 
            // btnSong3
            // 
            this.btnSong3.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSong3.FlatAppearance.BorderSize = 0;
            this.btnSong3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSong3.ForeColor = System.Drawing.Color.LightGray;
            this.btnSong3.Location = new System.Drawing.Point(0, 80);
            this.btnSong3.Name = "btnSong3";
            this.btnSong3.Padding = new System.Windows.Forms.Padding(39, 0, 0, 0);
            this.btnSong3.Size = new System.Drawing.Size(229, 40);
            this.btnSong3.TabIndex = 3;
            this.btnSong3.Text = "Song 3";
            this.btnSong3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSong3.UseVisualStyleBackColor = true;
            this.btnSong3.Click += new System.EventHandler(this.BtnSong3_Click);
            // 
            // btnSong2
            // 
            this.btnSong2.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSong2.FlatAppearance.BorderSize = 0;
            this.btnSong2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSong2.ForeColor = System.Drawing.Color.LightGray;
            this.btnSong2.Location = new System.Drawing.Point(0, 40);
            this.btnSong2.Name = "btnSong2";
            this.btnSong2.Padding = new System.Windows.Forms.Padding(39, 0, 0, 0);
            this.btnSong2.Size = new System.Drawing.Size(229, 40);
            this.btnSong2.TabIndex = 2;
            this.btnSong2.Text = "Song 2";
            this.btnSong2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSong2.UseVisualStyleBackColor = true;
            this.btnSong2.Click += new System.EventHandler(this.BtnSong2_Click);
            // 
            // btnSong1
            // 
            this.btnSong1.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSong1.FlatAppearance.BorderSize = 0;
            this.btnSong1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSong1.ForeColor = System.Drawing.Color.LightGray;
            this.btnSong1.Location = new System.Drawing.Point(0, 0);
            this.btnSong1.Name = "btnSong1";
            this.btnSong1.Padding = new System.Windows.Forms.Padding(39, 0, 0, 0);
            this.btnSong1.Size = new System.Drawing.Size(229, 40);
            this.btnSong1.TabIndex = 1;
            this.btnSong1.Text = "Song 1";
            this.btnSong1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSong1.UseVisualStyleBackColor = true;
            this.btnSong1.Click += new System.EventHandler(this.BtnSong1_Click);
            // 
            // btnMedia
            // 
            this.btnMedia.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMedia.FlatAppearance.BorderSize = 0;
            this.btnMedia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMedia.ForeColor = System.Drawing.Color.LightGray;
            this.btnMedia.Location = new System.Drawing.Point(0, 100);
            this.btnMedia.Name = "btnMedia";
            this.btnMedia.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.btnMedia.Size = new System.Drawing.Size(229, 45);
            this.btnMedia.TabIndex = 1;
            this.btnMedia.Text = "Media";
            this.btnMedia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMedia.UseVisualStyleBackColor = true;
            this.btnMedia.Click += new System.EventHandler(this.BtnMedia_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.pictureBox2);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(229, 100);
            this.panelLogo.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(229, 100);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // panelPlayer
            // 
            this.panelPlayer.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panelPlayer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelPlayer.BackgroundImage")));
            this.panelPlayer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelPlayer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPlayer.Location = new System.Drawing.Point(250, 0);
            this.panelPlayer.Name = "panelPlayer";
            this.panelPlayer.Size = new System.Drawing.Size(682, 553);
            this.panelPlayer.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 553);
            this.Controls.Add(this.panelPlayer);
            this.Controls.Add(this.panelSideMenu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(950, 600);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panelSideMenu.ResumeLayout(false);
            this.panelToolSubmenu.ResumeLayout(false);
            this.panelToolSubmenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.panelFindSubmenu.ResumeLayout(false);
            this.panelMediaSubmenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSideMenu;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Panel panelToolSubmenu;
        private System.Windows.Forms.Button btnLight;
        private System.Windows.Forms.Button btnTool;
        private System.Windows.Forms.Panel panelFindSubmenu;
        private System.Windows.Forms.Button btnFindA;
        private System.Windows.Forms.Button btnFindS;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Panel panelMediaSubmenu;
        private System.Windows.Forms.Button btnSong3;
        private System.Windows.Forms.Button btnSong2;
        private System.Windows.Forms.Button btnSong1;
        private System.Windows.Forms.Button btnMedia;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Panel panelPlayer;
    }
}

