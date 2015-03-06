using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ИЗ_ООП1
{
    public partial class EnterForm : Form
    {
        public EnterForm()
        {
            InitializeComponent();
            pMain.Visible = true;
            pOffical.Visible = false;
            pRelax.Visible = false;
            panel1.Visible = false;
        }
        public string city {get;set;}
        public int days { get; set; }
        bool ch_rb1 = false;
        bool ch_rb2 = false;
        bool ch_chb1 = false;
        bool ch_chb2 = false;
        bool ch_chb3 = false;
        bool ch_chb4 = false;
        int flag = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            try 
            {
                city = textBox1.Text;
                days = Convert.ToInt32(textBox2.Text);
                if ((textBox1.Text != "") && (textBox2.Text != ""))
                {
                    pMain.Visible = false;
                    if (rbOffical.Checked)
                    {
                        flag = 0;
                        panel1.Visible = true;
                        pOffical.Visible = true;
                        pRelax.Visible = false;
                    }
                    if (rbRelax.Checked)
                    {
                        flag = 1;
                        panel1.Visible = true;
                        pRelax.Visible = true;
                        pOffical.Visible = false;
                    }
                    
                }
                else
                {
                    MessageBox.Show("Заполните поля \"Город\"/\"Кол-во дней\"");
                }
                
            }
            catch (FormatException ex)
            {
               MessageBox.Show(ex.Message);
            }
            catch(Exception ex)
            { }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            pMain.Visible = true;
            panel1.Visible = false;
        }

        private void bNext2_Click_1(object sender, EventArgs e)
        {

            if ((checkBox1.Checked) || (checkBox5.Checked))  ch_chb1 = true;
            else ch_chb1 = false;
            if ((checkBox2.Checked) || (checkBox6.Checked)) ch_chb2 = true;
            else ch_chb2 = false;
            if ((checkBox3.Checked) || (checkBox7.Checked)) ch_chb3 = true;
            else ch_chb3 = false;
            if (checkBox8.Checked) ch_chb4 = true;
            else ch_chb4 = false;
            if (radioButton1.Checked)
            {
                ch_rb1 = true;
                ch_rb2 = false;
            }
            if (radioButton2.Checked)
            {
                ch_rb1 = false;
                ch_rb2 = true; 
            }
            ListForm lf = new ListForm(city, days, ch_rb1, ch_rb2, ch_chb1, ch_chb2, ch_chb3, ch_chb4, flag);
            lf.ShowDialog();
            
        }

        private void EnterForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == Convert.ToChar(8)))
                e.KeyChar = (char)0;
        }
    }
}
