using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Watch
{
    public partial class FormLongMsg : Form
    {
        Form frmOwner;
        Boolean ownerTopMost;
        public FormLongMsg(Form owner)
        {
            frmOwner = owner;
            ownerTopMost = owner.TopMost;
            owner.TopMost = false;
            InitializeComponent();
        }

        private void FormLongMsg_Load(object sender, EventArgs e)
        {

        }

        private void FormLongMsg_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmOwner.TopMost = ownerTopMost;
        }
    }
}
