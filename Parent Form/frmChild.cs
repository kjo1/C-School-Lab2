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
    public partial class frmChild : Form
    {
        public string FormTitle
        {
            get
            {
                return this.txtName.Text;
            }
        }

        public frmChild()
        {
            InitializeComponent();
        }

        public void btnName_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "")
            {
                lblName.Text = "Name cannot be empty";
                lblName.ForeColor = System.Drawing.Color.Tomato;
                lblName.Font = new Font(lblName.Font, FontStyle.Bold);

                txtName.Focus();
            }
            else
                Close();
        }
    }
}
