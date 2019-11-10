using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parent_Form
{
    public partial class frmListAllChidren : Form
    {
        public frmListAllChidren(Dictionary<string, Form> childList)
        {
            InitializeComponent();
            childList.Select(e => $"Child Name:{e.Value.Text} " +
            $"- Color: {e.Value.BackColor.Name}").ToList().ForEach(e => lstChildren.Items.Add(e));
        }

        private void llblClose_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Close();
        }
    }
}
