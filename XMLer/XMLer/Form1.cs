using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XMLer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string Doc;
        
        private void but_StartFile_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "<Package>\n";
            but_NewNode.Enabled = true;


        }

        private void but_NewNode_Click(object sender, EventArgs e)
        {
            string NewNode = "<Node name = \"" + textBox1.Text + "\"" + " repeatData = \""+textBox2.Text+ "\">\n";
            richTextBox1.AppendText(NewNode);
            but_AddData.Enabled = true;
            but_EndNode.Enabled = true;
            but_StartFile.Enabled = false;
        }

        private void but_AddData_Click(object sender, EventArgs e)
        {
            string NewData = "<Data page=\""+textBox3.Text+"\" row=\""+textBox4.Text+"\" col=\""+textBox5.Text+"\">"+textBox6.Text+ "</Data>\n";
            richTextBox1.AppendText(NewData);
            if (checkBox1.Checked)
            {
                int tmpint = Convert.ToInt32(textBox3.Text) + 1;
                textBox3.Text = Convert.ToString(tmpint);
            }
            if (checkBox2.Checked)
            {
                int tmpint = Convert.ToInt32(textBox4.Text) + 1;
                textBox4.Text = Convert.ToString(tmpint);
            }
            if (checkBox3.Checked)
            {
                int tmpint = Convert.ToInt32(textBox5.Text) + 1;
                textBox5.Text = Convert.ToString(tmpint);
            }
        }

        private void but_EndNode_Click(object sender, EventArgs e)
        {
            richTextBox1.AppendText("</Node>\n");
            but_EndFile.Enabled = true;
       
        }

        private void but_EndFile_Click(object sender, EventArgs e)
        {
            richTextBox1.AppendText("</Package>");
            but_StartFile.Enabled = true;
            but_EndFile.Enabled = false;
            but_AddData.Enabled = false;
            but_NewNode.Enabled = false;
            but_EndNode.Enabled = false;
        }

        private void but_ResetPage_Click(object sender, EventArgs e)
        {
            textBox3.Text = "0";
        }

        private void but_ResetRow_Click(object sender, EventArgs e)
        {
            textBox4.Text = "0";
        }

        private void but_ResetCol_Click(object sender, EventArgs e)
        {
            textBox5.Text = "0";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
