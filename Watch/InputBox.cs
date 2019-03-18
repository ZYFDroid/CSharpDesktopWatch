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
    public partial class InputBox : Form
    {
        public InputBox()
        {
            InitializeComponent();
        }

        private void InputBox_Load(object sender, EventArgs e)
        {

        }


        public DialogResult GetInput(out string str) {
            DialogResult dr = this.ShowDialog();
            str = textBox1.Text;
            return dr;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {

            Console.WriteLine(e.Handled);
            Console.WriteLine(e.KeyCode);
            Console.WriteLine(e.KeyData);
            Console.WriteLine(e.KeyValue);
            Console.WriteLine(e.SuppressKeyPress);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Contains("\r") || textBox1.Text.Contains("\n")) {
                textBox1.Text = textBox1.Text.Replace("\r", "").Replace("\n", "");
                DialogResult = DialogResult.OK;
            }
        }
    }
}
