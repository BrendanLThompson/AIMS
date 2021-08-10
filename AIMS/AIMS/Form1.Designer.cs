
namespace AIMS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btns = new System.Windows.Forms.Panel();
            this.pnlNAV = new System.Windows.Forms.Panel();
            this.MyInvent = new System.Windows.Forms.Button();
            this.MyShop = new System.Windows.Forms.Button();
            this.Warehouse = new System.Windows.Forms.Button();
            this.AddItem = new System.Windows.Forms.Button();
            this.pnlFormLoader = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Label = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.btns.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btns
            // 
            this.btns.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(125)))), ((int)(((byte)(159)))));
            this.btns.Controls.Add(this.pnlNAV);
            this.btns.Controls.Add(this.MyInvent);
            this.btns.Controls.Add(this.MyShop);
            this.btns.Controls.Add(this.Warehouse);
            this.btns.Controls.Add(this.AddItem);
            this.btns.Dock = System.Windows.Forms.DockStyle.Top;
            this.btns.Location = new System.Drawing.Point(0, 34);
            this.btns.Name = "btns";
            this.btns.Size = new System.Drawing.Size(1190, 108);
            this.btns.TabIndex = 0;
            this.btns.Paint += new System.Windows.Forms.PaintEventHandler(this.btns_Paint);
            // 
            // pnlNAV
            // 
            this.pnlNAV.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pnlNAV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(88)))), ((int)(((byte)(116)))));
            this.pnlNAV.Location = new System.Drawing.Point(330, 6);
            this.pnlNAV.Name = "pnlNAV";
            this.pnlNAV.Size = new System.Drawing.Size(261, 11);
            this.pnlNAV.TabIndex = 1;
            this.pnlNAV.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlNAV_Paint);
            // 
            // MyInvent
            // 
            this.MyInvent.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.MyInvent.FlatAppearance.BorderSize = 0;
            this.MyInvent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MyInvent.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MyInvent.Image = ((System.Drawing.Image)(resources.GetObject("MyInvent.Image")));
            this.MyInvent.Location = new System.Drawing.Point(861, 0);
            this.MyInvent.Name = "MyInvent";
            this.MyInvent.Size = new System.Drawing.Size(261, 119);
            this.MyInvent.TabIndex = 4;
            this.MyInvent.Text = "My Orders";
            this.MyInvent.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.MyInvent.UseVisualStyleBackColor = true;
            this.MyInvent.Click += new System.EventHandler(this.MyInvent_Click);
            this.MyInvent.Leave += new System.EventHandler(this.MyInvent_Leave);
            // 
            // MyShop
            // 
            this.MyShop.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.MyShop.FlatAppearance.BorderSize = 0;
            this.MyShop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MyShop.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MyShop.Image = ((System.Drawing.Image)(resources.GetObject("MyShop.Image")));
            this.MyShop.Location = new System.Drawing.Point(594, 0);
            this.MyShop.Name = "MyShop";
            this.MyShop.Size = new System.Drawing.Size(261, 119);
            this.MyShop.TabIndex = 3;
            this.MyShop.Text = "My Shop";
            this.MyShop.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.MyShop.UseVisualStyleBackColor = true;
            this.MyShop.Click += new System.EventHandler(this.MyShop_Click);
            this.MyShop.Leave += new System.EventHandler(this.MyShop_Leave);
            // 
            // Warehouse
            // 
            this.Warehouse.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Warehouse.FlatAppearance.BorderSize = 0;
            this.Warehouse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Warehouse.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Warehouse.Image = ((System.Drawing.Image)(resources.GetObject("Warehouse.Image")));
            this.Warehouse.Location = new System.Drawing.Point(330, 0);
            this.Warehouse.Name = "Warehouse";
            this.Warehouse.Size = new System.Drawing.Size(258, 119);
            this.Warehouse.TabIndex = 2;
            this.Warehouse.Text = "My Warehouse";
            this.Warehouse.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Warehouse.UseVisualStyleBackColor = true;
            this.Warehouse.Click += new System.EventHandler(this.Warehouse_Click);
            this.Warehouse.Leave += new System.EventHandler(this.Warehouse_Leave);
            // 
            // AddItem
            // 
            this.AddItem.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.AddItem.FlatAppearance.BorderSize = 0;
            this.AddItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddItem.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddItem.Image = ((System.Drawing.Image)(resources.GetObject("AddItem.Image")));
            this.AddItem.Location = new System.Drawing.Point(63, 0);
            this.AddItem.Name = "AddItem";
            this.AddItem.Size = new System.Drawing.Size(261, 119);
            this.AddItem.TabIndex = 1;
            this.AddItem.Text = "Add Album";
            this.AddItem.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.AddItem.UseVisualStyleBackColor = true;
            this.AddItem.Click += new System.EventHandler(this.button1_Click);
            this.AddItem.Leave += new System.EventHandler(this.AddItem_Leave);
            // 
            // pnlFormLoader
            // 
            this.pnlFormLoader.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlFormLoader.Location = new System.Drawing.Point(3, 154);
            this.pnlFormLoader.Name = "pnlFormLoader";
            this.pnlFormLoader.Size = new System.Drawing.Size(1187, 497);
            this.pnlFormLoader.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(58)))), ((int)(((byte)(86)))));
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.Label);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.Exit);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1190, 34);
            this.panel3.TabIndex = 1;
            this.panel3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseDown);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(27, 28);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Label
            // 
            this.Label.AutoSize = true;
            this.Label.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(166)))), ((int)(((byte)(187)))));
            this.Label.Location = new System.Drawing.Point(36, 9);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(63, 20);
            this.Label.TabIndex = 2;
            this.Label.Text = " A.I.M.S";
            this.Label.Click += new System.EventHandler(this.Label_Click);
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Right;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Verdana", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(166)))), ((int)(((byte)(187)))));
            this.button1.Location = new System.Drawing.Point(1128, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(29, 34);
            this.button1.TabIndex = 1;
            this.button1.Text = "-";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Exit
            // 
            this.Exit.Dock = System.Windows.Forms.DockStyle.Right;
            this.Exit.FlatAppearance.BorderSize = 0;
            this.Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Exit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(166)))), ((int)(((byte)(187)))));
            this.Exit.Location = new System.Drawing.Point(1157, 0);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(33, 34);
            this.Exit.TabIndex = 0;
            this.Exit.Text = "X";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(166)))), ((int)(((byte)(187)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1190, 651);
            this.ControlBox = false;
            this.Controls.Add(this.btns);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pnlFormLoader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "A.I.M.S";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.btns.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel btns;
        private System.Windows.Forms.Button MyInvent;
        private System.Windows.Forms.Button MyShop;
        private System.Windows.Forms.Button Warehouse;
        private System.Windows.Forms.Button AddItem;
        private System.Windows.Forms.Panel pnlNAV;
        private System.Windows.Forms.Panel pnlFormLoader;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Label;
    }
}

