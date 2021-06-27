namespace Client
{
    partial class frmBrowser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBrowser));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.cmdMinimizeProgram = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lblBRPClient = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.brpWebBrowser = new System.Windows.Forms.WebBrowser();
            this.txtBrowserUrl = new System.Windows.Forms.TextBox();
            this.btnGo = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnForward = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Black;
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1203, 29);
            this.pictureBox2.TabIndex = 334;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            this.pictureBox2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox2_MouseDown);
            this.pictureBox2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox2_MouseMove);
            this.pictureBox2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox2_MouseUp);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Black;
            this.pictureBox3.Image = global::Client.Properties.Resources.badge1;
            this.pictureBox3.Location = new System.Drawing.Point(2, 5);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(24, 21);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 345;
            this.pictureBox3.TabStop = false;
            // 
            // cmdMinimizeProgram
            // 
            this.cmdMinimizeProgram.BackColor = System.Drawing.Color.Black;
            this.cmdMinimizeProgram.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.cmdMinimizeProgram.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cmdMinimizeProgram.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdMinimizeProgram.Font = new System.Drawing.Font("Copperplate Gothic Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdMinimizeProgram.ForeColor = System.Drawing.Color.DodgerBlue;
            this.cmdMinimizeProgram.Location = new System.Drawing.Point(1159, 3);
            this.cmdMinimizeProgram.Name = "cmdMinimizeProgram";
            this.cmdMinimizeProgram.Size = new System.Drawing.Size(21, 24);
            this.cmdMinimizeProgram.TabIndex = 344;
            this.cmdMinimizeProgram.Text = "_";
            this.cmdMinimizeProgram.UseVisualStyleBackColor = false;
            this.cmdMinimizeProgram.Click += new System.EventHandler(this.cmdMinimizeProgram_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Copperplate Gothic Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.button2.Location = new System.Drawing.Point(1181, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(21, 24);
            this.button2.TabIndex = 343;
            this.button2.Text = "X";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblBRPClient
            // 
            this.lblBRPClient.AutoSize = true;
            this.lblBRPClient.BackColor = System.Drawing.Color.Black;
            this.lblBRPClient.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBRPClient.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblBRPClient.Location = new System.Drawing.Point(361, 6);
            this.lblBRPClient.Name = "lblBRPClient";
            this.lblBRPClient.Size = new System.Drawing.Size(387, 21);
            this.lblBRPClient.TabIndex = 342;
            this.lblBRPClient.Text = "BLACKRAPTOR PROTECTIVE - Web Browser";
            this.lblBRPClient.Click += new System.EventHandler(this.lblBRPClient_Click);
            this.lblBRPClient.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblBRPClient_MouseDown);
            this.lblBRPClient.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblBRPClient_MouseMove);
            this.lblBRPClient.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lblBRPClient_MouseUp);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(0, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1203, 665);
            this.panel1.TabIndex = 346;
            // 
            // brpWebBrowser
            // 
            this.brpWebBrowser.Location = new System.Drawing.Point(12, 116);
            this.brpWebBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.brpWebBrowser.Name = "brpWebBrowser";
            this.brpWebBrowser.Size = new System.Drawing.Size(1181, 568);
            this.brpWebBrowser.TabIndex = 0;
            this.brpWebBrowser.Url = new System.Uri("http://www.brprotective.com/", System.UriKind.Absolute);
            this.brpWebBrowser.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            this.brpWebBrowser.Navigated += new System.Windows.Forms.WebBrowserNavigatedEventHandler(this.brpWebBrowser_Navigated);
            // 
            // txtBrowserUrl
            // 
            this.txtBrowserUrl.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtBrowserUrl.Location = new System.Drawing.Point(61, 95);
            this.txtBrowserUrl.Name = "txtBrowserUrl";
            this.txtBrowserUrl.Size = new System.Drawing.Size(715, 20);
            this.txtBrowserUrl.TabIndex = 1;
            this.txtBrowserUrl.TextChanged += new System.EventHandler(this.txtBrowserUrl_TextChanged);
            // 
            // btnGo
            // 
            this.btnGo.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnGo.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnGo.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnGo.FlatAppearance.BorderSize = 2;
            this.btnGo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnGo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnGo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGo.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnGo.Location = new System.Drawing.Point(779, 89);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(39, 26);
            this.btnGo.TabIndex = 34;
            this.btnGo.Text = "G&o";
            this.btnGo.UseVisualStyleBackColor = false;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnBack.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnBack.FlatAppearance.BorderSize = 2;
            this.btnBack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnBack.Location = new System.Drawing.Point(952, 87);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(47, 27);
            this.btnBack.TabIndex = 35;
            this.btnBack.Text = "B&ack";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnForward
            // 
            this.btnForward.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnForward.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnForward.FlatAppearance.BorderSize = 2;
            this.btnForward.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnForward.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnForward.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnForward.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnForward.Location = new System.Drawing.Point(997, 87);
            this.btnForward.Name = "btnForward";
            this.btnForward.Size = new System.Drawing.Size(69, 27);
            this.btnForward.TabIndex = 36;
            this.btnForward.Text = "F&orward";
            this.btnForward.UseVisualStyleBackColor = false;
            this.btnForward.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnStop.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnStop.FlatAppearance.BorderSize = 2;
            this.btnStop.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnStop.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStop.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnStop.Location = new System.Drawing.Point(1064, 87);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(44, 27);
            this.btnStop.TabIndex = 37;
            this.btnStop.Text = "S&top";
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnRefresh.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnRefresh.FlatAppearance.BorderSize = 2;
            this.btnRefresh.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnRefresh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnRefresh.Location = new System.Drawing.Point(1105, 87);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(69, 27);
            this.btnRefresh.TabIndex = 38;
            this.btnRefresh.Text = "R&efresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Copperplate Gothic Light", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 15);
            this.label4.TabIndex = 171;
            this.label4.Text = "URL :";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Desktop;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.button1.Location = new System.Drawing.Point(881, 87);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(73, 27);
            this.button1.TabIndex = 172;
            this.button1.Text = "BRP H&ome";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_3);
            // 
            // frmBrowser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1203, 694);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.cmdMinimizeProgram);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lblBRPClient);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnForward);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.txtBrowserUrl);
            this.Controls.Add(this.brpWebBrowser);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmBrowser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmBrowser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button cmdMinimizeProgram;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblBRPClient;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.WebBrowser brpWebBrowser;
        private System.Windows.Forms.TextBox txtBrowserUrl;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnForward;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
    }
}