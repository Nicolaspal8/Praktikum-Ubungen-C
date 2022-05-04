
namespace Tetris
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
            this.components = new System.ComponentModel.Container();
            this.CmdLinks = new System.Windows.Forms.Button();
            this.CmdRechts = new System.Windows.Forms.Button();
            this.CmdUnten = new System.Windows.Forms.Button();
            this.CmdPause = new System.Windows.Forms.Button();
            this.TimTetris = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // CmdLinks
            // 
            this.CmdLinks.Location = new System.Drawing.Point(70, 23);
            this.CmdLinks.Name = "CmdLinks";
            this.CmdLinks.Size = new System.Drawing.Size(75, 23);
            this.CmdLinks.TabIndex = 0;
            this.CmdLinks.Text = "<<";
            this.CmdLinks.UseVisualStyleBackColor = true;
            this.CmdLinks.Click += new System.EventHandler(this.CmdLinks_Click);
            // 
            // CmdRechts
            // 
            this.CmdRechts.Location = new System.Drawing.Point(151, 23);
            this.CmdRechts.Name = "CmdRechts";
            this.CmdRechts.Size = new System.Drawing.Size(75, 23);
            this.CmdRechts.TabIndex = 0;
            this.CmdRechts.Text = ">>";
            this.CmdRechts.UseVisualStyleBackColor = true;
            this.CmdRechts.Click += new System.EventHandler(this.CmdRechts_Click);
            // 
            // CmdUnten
            // 
            this.CmdUnten.Location = new System.Drawing.Point(108, 52);
            this.CmdUnten.Name = "CmdUnten";
            this.CmdUnten.Size = new System.Drawing.Size(75, 23);
            this.CmdUnten.TabIndex = 0;
            this.CmdUnten.Text = "W";
            this.CmdUnten.UseVisualStyleBackColor = true;
            this.CmdUnten.Click += new System.EventHandler(this.CmdUnten_Click);
            // 
            // CmdPause
            // 
            this.CmdPause.Location = new System.Drawing.Point(108, 352);
            this.CmdPause.Name = "CmdPause";
            this.CmdPause.Size = new System.Drawing.Size(75, 23);
            this.CmdPause.TabIndex = 1;
            this.CmdPause.Text = "I I";
            this.CmdPause.UseVisualStyleBackColor = true;
            this.CmdPause.Click += new System.EventHandler(this.CmdPause_Click);
            // 
            // TimTetris
            // 
            this.TimTetris.Enabled = true;
            this.TimTetris.Tick += new System.EventHandler(this.TimTetris_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(315, 403);
            this.Controls.Add(this.CmdPause);
            this.Controls.Add(this.CmdUnten);
            this.Controls.Add(this.CmdRechts);
            this.Controls.Add(this.CmdLinks);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion

   
        private System.Windows.Forms.Button CmdLinks;
        private System.Windows.Forms.Button CmdRechts;
        private System.Windows.Forms.Button CmdUnten;
        private System.Windows.Forms.Button CmdPause;
        private System.Windows.Forms.Timer TimTetris;
    }
}

