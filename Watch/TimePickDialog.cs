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
    public partial class TimePickDialog : Form
    {
        public TimePickDialog()
        {
            InitializeComponent();
        }

        private void TimePickDialog_Load(object sender, EventArgs e)
        {
            dateTimePicker1.MinDate = DateTime.Now;
        }

        private void dateTimePicker1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
                this.DialogResult = DialogResult.OK;
        }
    }
}
