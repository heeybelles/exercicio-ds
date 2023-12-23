using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Add(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Nenhum item foi selecionado!!!", "ComboBox", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                comboBox1.Items.RemoveAt(comboBox1.SelectedIndex);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            comboBox1.SelectedIndex = -1;
            label2.Text = "";
            label5.Text = "";
            label4.Text = "";
            textBox1.Focus();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            label2.Text = comboBox1.SelectedIndex.ToString(); 
            label5.Text = comboBox1.SelectedIndex.ToString();
            label4.Text = comboBox1.Items.Count.ToString();

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                button1_Click(sender, e);
            }
        }

        private void button1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
