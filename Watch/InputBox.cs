using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Watch
{
    public partial class InputBox : Form
    {
        Form frmOwner;
        Boolean ownerTopMost;
        public InputBox(Form owner)
        {
            frmOwner = owner;
            ownerTopMost = owner.TopMost;
            owner.TopMost = false;
            InitializeComponent();
        }

        private void InputBox_Load(object sender, EventArgs e)
        {

        }

        SoundPlayer successSound = new SoundPlayer(Properties.Resources.success);

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
                successSound.Play();
            }
        }

        private void InputBox_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmOwner.TopMost = ownerTopMost;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            successSound.Play();
        }
    }
}
