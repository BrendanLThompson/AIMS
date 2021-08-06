using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AIMS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            pnlNAV.Width = AddItem.Width;
            pnlNAV.Top = AddItem.Top;
            pnlNAV.Left = AddItem.Left;
            AddItem.BackColor = Color.FromArgb(148, 166, 187);

            this.pnlFormLoader.Controls.Clear();
            dash dash_Vrb = new dash() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            dash_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(dash_Vrb);
            dash_Vrb.Show();


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            pnlNAV.Width = AddItem.Width;
            pnlNAV.Top = AddItem.Top;
            pnlNAV.Left = AddItem.Left;
            AddItem.BackColor = Color.FromArgb(148, 166, 187);


            this.pnlFormLoader.Controls.Clear();
            dash dash_Vrb = new dash() { Dock = DockStyle.Fill, TopLevel = false, TopMost = false };
            dash_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(dash_Vrb);
            dash_Vrb.Show();

        }

        private void Warehouse_Click(object sender, EventArgs e)
        {
            pnlNAV.Width = Warehouse.Width;
            pnlNAV.Top = Warehouse.Top;
            pnlNAV.Left = Warehouse.Left;
            Warehouse.BackColor = Color.FromArgb(148, 166, 187);

            this.pnlFormLoader.Controls.Clear();
            dash1 dash1_Vrb = new dash1() { Dock = DockStyle.Fill, TopLevel = false, TopMost = false };
            dash1_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(dash1_Vrb);
            dash1_Vrb.Show();

        }

        private void MyShop_Click(object sender, EventArgs e)
        {
            pnlNAV.Width = MyShop.Width;
            pnlNAV.Top = MyShop.Top;
            pnlNAV.Left = MyShop.Left;
            MyShop.BackColor = Color.FromArgb(148, 166, 187);

            this.pnlFormLoader.Controls.Clear();
            dash2 dash2_Vrb = new dash2() { Dock = DockStyle.Fill, TopLevel = false, TopMost = false };
            dash2_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(dash2_Vrb);
            dash2_Vrb.Show();
        }

        private void MyInvent_Click(object sender, EventArgs e)
        {
            pnlNAV.Width = MyInvent.Width;
            pnlNAV.Top = MyInvent.Top;
            pnlNAV.Left = MyInvent.Left;
            MyInvent.BackColor = Color.FromArgb(148, 166, 187);

            this.pnlFormLoader.Controls.Clear();
            dash3 dash3_Vrb = new dash3() { Dock = DockStyle.Fill, TopLevel = false, TopMost = false };
            dash3_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(dash3_Vrb);
            dash3_Vrb.Show();
        }

        private void AddItem_Leave(object sender, EventArgs e)
        {
            AddItem.BackColor = Color.FromArgb(90, 125, 159);
        }

        private void Warehouse_Leave(object sender, EventArgs e)
        {
            Warehouse.BackColor = Color.FromArgb(90, 125, 159);
        }

        private void MyShop_Leave(object sender, EventArgs e)
        {
            MyShop.BackColor = Color.FromArgb(90, 125, 159);
        }

        private void MyInvent_Leave(object sender, EventArgs e)
        {
            MyInvent.BackColor = Color.FromArgb(90, 125, 159);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
