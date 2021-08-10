using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
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

            this.Text = String.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;

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
            Warehouse.BackColor = Color.FromArgb(90, 125, 159);
            MyShop.BackColor = Color.FromArgb(90, 125, 159);
            MyInvent.BackColor = Color.FromArgb(90, 125, 159);


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
            AddItem.BackColor = Color.FromArgb(90, 125, 159);
            Warehouse.BackColor = Color.FromArgb(148, 166, 187);
            MyShop.BackColor = Color.FromArgb(90, 125, 159);
            MyInvent.BackColor = Color.FromArgb(90, 125, 159);

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
            AddItem.BackColor = Color.FromArgb(90, 125, 159);
            Warehouse.BackColor = Color.FromArgb(90, 125, 159);
            MyShop.BackColor = Color.FromArgb(148, 166, 187);
            MyInvent.BackColor = Color.FromArgb(90, 125, 159);

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
            AddItem.BackColor = Color.FromArgb(90, 125, 159);
            Warehouse.BackColor = Color.FromArgb(90, 125, 159);
            MyShop.BackColor = Color.FromArgb(90, 125, 159);
            MyInvent.BackColor = Color.FromArgb(148, 166, 187);


            this.pnlFormLoader.Controls.Clear();
            dash3 dash3_Vrb = new dash3() { Dock = DockStyle.Fill, TopLevel = false, TopMost = false };
            dash3_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(dash3_Vrb);
            dash3_Vrb.Show();
        }

        private void AddItem_Leave(object sender, EventArgs e)
        {
            
        }

        private void Warehouse_Leave(object sender, EventArgs e)
        {
            
        }

        private void MyShop_Leave(object sender, EventArgs e)
        {
            
        }

        private void MyInvent_Leave(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void pnlNAV_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btns_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }



        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int WMsg, int wParam, int lParam);
        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Label_Click(object sender, EventArgs e)
        {

        }
    }
}
