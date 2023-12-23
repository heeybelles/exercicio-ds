using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ativiidade03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Nenhuma opção foi selecionada!!", "ListBox", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            listBox1.Items.Clear();
            label2.Text = "";
            label3.Text = "";
            label4.Text = "";
            textBox1.Focus();

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listBox1.SelectedIndex != 1)
            {
                label2.Text = listBox1.SelectedIndex.ToString();
                label3.Text = listBox1.SelectedIndex.ToString();
                label4.Text = listBox1.SelectedIndex.ToString();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13)
            {
                button1_Click(sender, e);
            }
        }
    }
}
