using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
 
/*
 * Created by Kanghyun Jo
 * For PROG1197 - Lab 2
 * 2019-10-12~15
 */

namespace Parent_Form
{
    public partial class frmParent : Form
    {
        Color c;
        public Dictionary<string, Form> ChildList = new Dictionary<string, Form>();

        public frmParent()
        {
            // splash
            Thread t = new Thread(new ThreadStart(SplashForm));
            t.Start();
            Thread.Sleep(5000);
            InitializeComponent();
            t.Abort();
        }
        public void SplashForm()
        {
            Application.Run(new frmSplash());
        }

        // about
        frmAbout fa;
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fa == null)
            {
                fa = new frmAbout();
                fa.FormClosed += Fa_FormClosed;
                fa.ShowDialog();
            }
            else
                fa.Activate();
        }

        private void Fa_FormClosed(object sender, FormClosedEventArgs e)
        {
            fa = null;
        }
        private void closeAllChildrenToolStripMenuItem_Click(object sender, EventArgs e)
        {

            foreach (Form frm in this.MdiChildren)
            {
                frm.Dispose();
                frm.Close();
                defalutForm();
            }
            defalutForm();
        }

        private void selectColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var item = (ToolStripMenuItem)sender;
            ColorDialog cd = new ColorDialog();

            if (item.Text == "Red")
                c = Color.Red;
            else if (item.Text == "Green")
            {
                c = Color.Green;
            }
            else if (item.Text == "Blue")
            {
                c = Color.Blue;
            }
            else
            {
                if (cd.ShowDialog() == DialogResult.OK)
                {
                    c = cd.Color;
                }
            }
            statusStrip.BackColor = c;
            tssColor.Text = string.Format("Selected Color: {0}", c.Name);
        }

        private void createNewChildToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmChild fc = new frmChild();
            fc.FormClosed += Fc_FormClosed;
            fc.ShowDialog();
        }

        private void Fc_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form f = new Form
            {
                Text = ((frmChild)sender).FormTitle,
                BackColor = statusStrip.BackColor,
                MdiParent = this
            };
            try
            {
                f.Activated += (send, evt) => { tssActive.Text = $"Active Windows: {f.Text}"; };
                f.FormClosed += (send, evt) => { ChildList.Remove(f.Text); };
                ChildList.Add(f.Text, f);
                f.Show();
            }
            catch (Exception)
            {
                MessageBox.Show("New child cannot have the same name");
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Yes to exit / No to create more children", "Decision",
                                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Close();
        }

        private void listAllChildrenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmListAllChidren(ChildList).ShowDialog();
        }

        private void frmParent_Load(object sender, EventArgs e)
        {
            defalutForm();
        }

        private void cascadeChildrenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void defalutForm()
        {
            ChildList.Clear();
            c = Color.Teal;
            statusStrip.BackColor = c;
            tssActive.Text = "Active Window: None";
            tssColor.Text = string.Format("Selected Color: {0}", c.Name);
        }
    }
}
