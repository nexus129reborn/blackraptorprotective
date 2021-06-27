namespace Client
{
    partial class frmCheckForUpdate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCheckForUpdate));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.cmdMinimizeProgram = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lblBRPClient = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
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
            this.pictureBox2.Size = new System.Drawing.Size(743, 29);
            this.pictureBox2.TabIndex = 334;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            this.pictureBox2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox2_MouseDown);
            this.pictureBox2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox2_MouseMove);
            this.pictureBox2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox2_MouseUp);
            // 
            // cmdMinimizeProgram
            // 
            this.cmdMinimizeProgram.BackColor = System.Drawing.Color.Black;
            this.cmdMinimizeProgram.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.cmdMinimizeProgram.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cmdMinimizeProgram.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdMinimizeProgram.Font = new System.Drawing.Font("Copperplate Gothic Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdMinimizeProgram.ForeColor = System.Drawing.Color.DodgerBlue;
            this.cmdMinimizeProgram.Location = new System.Drawing.Point(698, 3);
            this.cmdMinimizeProgram.Name = "cmdMinimizeProgram";
            this.cmdMinimizeProgram.Size = new System.Drawing.Size(21, 24);
            this.cmdMinimizeProgram.TabIndex = 340;
            this.cmdMinimizeProgram.Text = "_";
            this.cmdMinimizeProgram.UseVisualStyleBackColor = false;
            this.cmdMinimizeProgram.Click += new System.EventHandler(this.cmdMinimizeProgram_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Copperplate Gothic Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.button1.Location = new System.Drawing.Point(720, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(21, 24);
            this.button1.TabIndex = 339;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblBRPClient
            // 
            this.lblBRPClient.AutoSize = true;
            this.lblBRPClient.BackColor = System.Drawing.Color.Black;
            this.lblBRPClient.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBRPClient.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblBRPClient.Location = new System.Drawing.Point(145, 6);
            this.lblBRPClient.Name = "lblBRPClient";
            this.lblBRPClient.Size = new System.Drawing.Size(432, 21);
            this.lblBRPClient.TabIndex = 338;
            this.lblBRPClient.Text = "BLACKRAPTOR PROTECTIVE - Check For Updates";
            this.lblBRPClient.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblBRPClient_MouseDown);
            this.lblBRPClient.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblBRPClient_MouseMove);
            this.lblBRPClient.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lblBRPClient_MouseUp);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Black;
            this.pictureBox3.Image = global::Client.Properties.Resources.badge1;
            this.pictureBox3.Location = new System.Drawing.Point(4, 4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(24, 21);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 341;
            this.pictureBox3.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(0, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(743, 356);
            this.panel1.TabIndex = 342;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // frmCheckForUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(743, 386);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.cmdMinimizeProgram);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblBRPClient);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCheckForUpdate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Blackraptor Protective - Check For Updates";
            this.Load += new System.EventHandler(this.frmCheckForUpdate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button cmdMinimizeProgram;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblBRPClient;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel1;
    }
}