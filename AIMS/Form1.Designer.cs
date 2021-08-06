
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlFormLoader = new System.Windows.Forms.Panel();
            this.btns.SuspendLayout();
            this.panel2.SuspendLayout();
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
            this.btns.Controls.Add(this.panel2);
            this.btns.Dock = System.Windows.Forms.DockStyle.Top;
            this.btns.Location = new System.Drawing.Point(0, 0);
            this.btns.Name = "btns";
            this.btns.Size = new System.Drawing.Size(1190, 119);
            this.btns.TabIndex = 0;
            // 
            // pnlNAV
            // 
            this.pnlNAV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(88)))), ((int)(((byte)(116)))));
            this.pnlNAV.Location = new System.Drawing.Point(667, 0);
            this.pnlNAV.Name = "pnlNAV";
            this.pnlNAV.Size = new System.Drawing.Size(261, 11);
            this.pnlNAV.TabIndex = 1;
            // 
            // MyInvent
            // 
            this.MyInvent.Dock = System.Windows.Forms.DockStyle.Left;
            this.MyInvent.FlatAppearance.BorderSize = 0;
            this.MyInvent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MyInvent.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MyInvent.Image = ((System.Drawing.Image)(resources.GetObject("MyInvent.Image")));
            this.MyInvent.Location = new System.Drawing.Point(928, 0);
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
            this.MyShop.Dock = System.Windows.Forms.DockStyle.Left;
            this.MyShop.FlatAppearance.BorderSize = 0;
            this.MyShop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MyShop.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MyShop.Image = ((System.Drawing.Image)(resources.GetObject("MyShop.Image")));
            this.MyShop.Location = new System.Drawing.Point(667, 0);
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
            this.Warehouse.Dock = System.Windows.Forms.DockStyle.Left;
            this.Warehouse.FlatAppearance.BorderSize = 0;
            this.Warehouse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Warehouse.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Warehouse.Image = ((System.Drawing.Image)(resources.GetObject("Warehouse.Image")));
            this.Warehouse.Location = new System.Drawing.Point(406, 0);
            this.Warehouse.Name = "Warehouse";
            this.Warehouse.Size = new System.Drawing.Size(261, 119);
            this.Warehouse.TabIndex = 2;
            this.Warehouse.Text = "My Warehouse";
            this.Warehouse.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Warehouse.UseVisualStyleBackColor = true;
            this.Warehouse.Click += new System.EventHandler(this.Warehouse_Click);
            this.Warehouse.Leave += new System.EventHandler(this.Warehouse_Leave);
            // 
            // AddItem
            // 
            this.AddItem.Dock = System.Windows.Forms.DockStyle.Left;
            this.AddItem.FlatAppearance.BorderSize = 0;
            this.AddItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddItem.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddItem.Image = ((System.Drawing.Image)(resources.GetObject("AddItem.Image")));
            this.AddItem.Location = new System.Drawing.Point(145, 0);
            this.AddItem.Name = "AddItem";
            this.AddItem.Size = new System.Drawing.Size(261, 119);
            this.AddItem.TabIndex = 1;
            this.AddItem.Text = "Add Album";
            this.AddItem.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.AddItem.UseVisualStyleBackColor = true;
            this.AddItem.Click += new System.EventHandler(this.button1_Click);
            this.AddItem.Leave += new System.EventHandler(this.AddItem_Leave);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(145, 119);
            this.panel2.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(145, 119);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pnlFormLoader
            // 
            this.pnlFormLoader.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFormLoader.Location = new System.Drawing.Point(0, 125);
            this.pnlFormLoader.Name = "pnlFormLoader";
            this.pnlFormLoader.Size = new System.Drawing.Size(1190, 526);
            this.pnlFormLoader.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(166)))), ((int)(((byte)(187)))));
            this.ClientSize = new System.Drawing.Size(1190, 651);
            this.Controls.Add(this.pnlFormLoader);
            this.Controls.Add(this.btns);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "A.I.M.S";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.btns.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel btns;
        private System.Windows.Forms.Button MyInvent;
        private System.Windows.Forms.Button MyShop;
        private System.Windows.Forms.Button Warehouse;
        private System.Windows.Forms.Button AddItem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnlNAV;
        private System.Windows.Forms.Panel pnlFormLoader;
    }
}

