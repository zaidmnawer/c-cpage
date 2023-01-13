using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zashop
{
    public partial class Form1 : Form
    {

        private Form currentActiveForm = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void TreeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            Form frm = null;
            TreeNode node = e.Node;
            if (node.Name == "NodeCategory")
                frm = new NodeCategory();
            else if (node.Name == "NodeJeans")
                frm = new frmJeans();
            else if (node.Name == "Nodeboots")
                frm = new frmboot();
            else if (node.Name == "NodeTops")
                frm = new frmtops();
            else if (node.Name == "NodeShirt")
                frm = new frmshirts();
            else if (node.Name == "NodeWallet")
                frm = new frmWallet();
            else if (node.Name == "NodeCart")
                frm = new frmCart();
            else if (node.Name == "NodeUser")
                frm = new frmJeans();

            if (frm != null)
            {
                if (currentActiveForm != null && currentActiveForm != frm)
                {
                    currentActiveForm.Close();
                    panel2.Controls.Remove(currentActiveForm);
                }
                frm.FormBorderStyle = FormBorderStyle.None;
                frm.TopLevel = false;
                frm.Dock = DockStyle.Fill;
                frm.BackColor = Color.White;
                currentActiveForm = frm;
                panel2.Controls.Add(frm);
                frm.Show();

            }




            if (frm != null)
            {
                frm.FormBorderStyle = FormBorderStyle.None;
                frm.TopLevel = false;

                frm.Dock = DockStyle.Fill;
                frm.BackColor = Color.White;
                panel2.Controls.Add(frm);
                frm.Show();
                currentActiveForm = frm;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you wish eo quit?", "Exit Application", MessageBoxButtons.YesNo);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                Application.Exit();






            }

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you have an account?", "Login Application", MessageBoxButtons.YesNo);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                Application.DoEvents();
            }
        }
    }
}


