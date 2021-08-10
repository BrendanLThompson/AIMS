
namespace AIMS
{
    partial class dash
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
            this.Artist = new System.Windows.Forms.TextBox();
            this.Album = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Search = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Artist
            // 
            this.Artist.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.Artist.Location = new System.Drawing.Point(436, 237);
            this.Artist.Name = "Artist";
            this.Artist.Size = new System.Drawing.Size(275, 23);
            this.Artist.TabIndex = 0;
            this.Artist.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Artist.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Album
            // 
            this.Album.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.Album.Location = new System.Drawing.Point(436, 176);
            this.Album.Name = "Album";
            this.Album.Size = new System.Drawing.Size(275, 23);
            this.Album.TabIndex = 1;
            this.Album.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Album.TextChanged += new System.EventHandler(this.Album_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(536, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Album Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(537, 219);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = " Artist Name ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Search
            // 
            this.Search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(125)))), ((int)(((byte)(159)))));
            this.Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Search.Location = new System.Drawing.Point(536, 286);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(74, 24);
            this.Search.TabIndex = 5;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = false;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // dash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(166)))), ((int)(((byte)(187)))));
            this.ClientSize = new System.Drawing.Size(1166, 514);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Album);
            this.Controls.Add(this.Artist);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "dash";
            this.Text = "Add Album";
            this.Load += new System.EventHandler(this.dash_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Artist;
        private System.Windows.Forms.TextBox Album;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Search;
    }
}