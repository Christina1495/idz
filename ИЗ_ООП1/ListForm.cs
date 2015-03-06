using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ИЗ_ООП1
{
    public partial class ListForm : Form
    {
        ReadFile rf;
        
        List<string> mylist = new List<string>();
        public ListForm(string s, int d, bool rb1, bool rb2, bool chb1, bool chb2, bool chb3, bool chb4, int fl)
        {
            InitializeComponent();
            panel1.Visible = false;
            listBox1.Items.Clear();
            rf = new ReadFile();
            string ss = "y";
            if (s[s.Length -1] == 'а')
            {
                s = s.Remove(s.Length - 1, 1);
                s = s.Insert(s.Length,  ss);
            }

            label1.Text = "Вы едите в " + s + " на " + d.ToString() + " дней." + Environment.NewLine + "С собой надо взять:";
            string[] llist;
            if (fl == 0)
            {
                if (chb1 == true)
                {
                    mylist.Add("~~~~~~~~~~~~~~~~~~~~~~~~");
                    mylist.Add("Деловой ужин:");
                    mylist.Add("~~~~~~~~~~~~~~~~~~~~~~~~");
                    if (rb1 == true)
                    {
                        llist = rf.mass(@"Resourses\of_p1_male.txt");
                        for (int i = 0; i < llist.Length; i++)
                            mylist.Add("-" + llist[i]);
                    }
                    if ((rb2 == true) && (chb1 = true))
                    {
                       llist = rf.mass(@"Resourses\of_p1_female.txt");
                       for (int i = 0; i < llist.Length; i++)
                           mylist.Add("-" + llist[i]);
                    }
                    listBox1.Items.Add("+");
                }
                if (chb2 == true)
                {
                    mylist.Add("~~~~~~~~~~~~~~~~~~~~~~~~");
                    mylist.Add("Переговоры:");
                    mylist.Add("~~~~~~~~~~~~~~~~~~~~~~~~");
                    llist = rf.mass(@"Resourses\of_p2.txt");
                    for (int i = 0; i < llist.Length; i++)
                        mylist.Add("-" + llist[i]);
                    listBox1.Items.Add("+");
                }
                if (chb3 == true)
                {
                    mylist.Add("~~~~~~~~~~~~~~~~~~~~~~~~");
                    mylist.Add("Конференция:");
                    mylist.Add("~~~~~~~~~~~~~~~~~~~~~~~~");
                    llist = rf.mass(@"Resourses\of_p3.txt");
                    for (int i = 0; i < llist.Length; i++)
                        mylist.Add("-" + llist[i]);
                    listBox1.Items.Add("+");
                }
                
            }
            if (fl == 1)
            {
                if (chb1 == true)
                {
                    mylist.Add("~~~~~~~~~~~~~~~~~~~~~~~~");
                    mylist.Add("Катание на лыжах:");
                    mylist.Add("~~~~~~~~~~~~~~~~~~~~~~~~");
                    llist = rf.mass(@"Resourses\rel_p1.txt");
                    for (int i = 0; i < llist.Length; i++)
                        mylist.Add("-" + llist[i]);
                    listBox1.Items.Add("+");
                }
                if (chb2 == true)
                {
                    mylist.Add("~~~~~~~~~~~~~~~~~~~~~~~~");
                    mylist.Add("Пляж:");
                    mylist.Add("~~~~~~~~~~~~~~~~~~~~~~~~");
                    llist = rf.mass(@"Resourses\rel_p2.txt");
                    for (int i = 0; i < llist.Length; i++)
                        mylist.Add("-" + llist[i]);
                    listBox1.Items.Add("+");
                }
                if (chb3 == true)
                {
                    mylist.Add("~~~~~~~~~~~~~~~~~~~~~~~~");
                    mylist.Add("Экскурсия:");
                    mylist.Add("~~~~~~~~~~~~~~~~~~~~~~~~");
                    llist = rf.mass(@"Resourses\rel_p3.txt");
                    for (int i = 0; i < llist.Length; i++)
                        mylist.Add("-" + llist[i]);
                    listBox1.Items.Add("+");
                }
                if (chb4 == true)
                {
                    mylist.Add("~~~~~~~~~~~~~~~~~~~~~~~~");
                    mylist.Add("Пикник:");
                    mylist.Add("~~~~~~~~~~~~~~~~~~~~~~~~");
                    llist = rf.mass(@"Resourses\rel_p4.txt");
                    for (int i = 0; i < llist.Length; i++)
                        mylist.Add("-" + llist[i]);
                    listBox1.Items.Add("+");
                }
            }
            
            mylist.Add("~~~~~~~~~~~~~~~~~~~~~~~~");
            mylist.Add("Документы:");
            mylist.Add("~~~~~~~~~~~~~~~~~~~~~~~~");
            llist = rf.mass(@"Resourses\Doc.txt");
            for (int i = 0; i < llist.Length; i++)
                mylist.Add("-" + llist[i]);
            listBox1.Items.Add("+");
            mylist.Add("~~~~~~~~~~~~~~~~~~~~~~~~");
            mylist.Add("Лекарства:");
            mylist.Add("~~~~~~~~~~~~~~~~~~~~~~~~");
            llist = rf.mass(@"Resourses\Apteka.txt");
            for (int i = 0; i < llist.Length; i++)
                mylist.Add("-" + llist[i]);
            listBox1.Items.Add("+");
            mylist.Add("~~~~~~~~~~~~~~~~~~~~~~~~");
            mylist.Add("Предметы личной гигиены:");
            mylist.Add("~~~~~~~~~~~~~~~~~~~~~~~~");
            llist = rf.mass(@"Resourses\Lichnaya.txt");
            for (int i = 0; i < llist.Length; i++)
                mylist.Add("-" + llist[i]);
            mylist.Add("+");

            listBox1.DataSource = mylist;
        }

        private void печатьСпискаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (printDialog1.ShowDialog() == DialogResult.OK)
            {
                // Печать
                printDocument1.Print();
            }
        }
        int printed;
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            var g = e.Graphics;
            // max высота текста
            int max_height = e.PageBounds.Height;
            int height = 0; // Отпечатано по высоте
            int temp; // Размер одной строки
            for (printed = 0; printed < listBox1.Items.Count; ++printed)
            {
                temp = TextRenderer.MeasureText((string)listBox1.Items[printed], this.Font).Height;
                if (height + temp + 5 > max_height)
                    break;
                g.DrawString(listBox1.Items[printed].ToString(), this.Font, Brushes.Black, 
                    new Rectangle(e.PageBounds.X, height, e.PageBounds.Width, temp));
                height += temp + 5;
            }
            e.HasMorePages = printed != listBox1.Items.Count;
        }

        private void printDocument1_EndPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            printed = 0;
        }

        private void printDocument1_BeginPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            if (printed != 0)
                e.Cancel = true;
        }

        private void сохранитьСписокВФайлToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFile sf = new SaveFile();
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                for (int i = 0; i < listBox1.Items.Count; i++ )
                    sf.SaveAll(saveFileDialog1.FileName, listBox1.Items[i].ToString());
            }
        }

        string[] llist;
 
        private void открытьФайлToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                listBox1.Items.Clear();
                llist = rf.mass(openFileDialog1.FileName);
                for (int i = 0; i < llist.Length; i++)
                    mylist.Add(llist[i]);
            }
        }

        private void вернутьсяВПредыдущиеОкноToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void удалитьВыбранныйЭлементToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mylist.Remove(listBox1.SelectedItem.ToString());
            listBox1.DataSource = null;
            listBox1.DataSource = mylist;
        }

        int selected_items;
        string myActiv;

        private void добавитьНовыйЭлементToolStripMenuItem_Click(object sender, EventArgs e)
        {     
            panel1.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            selected_items = listBox1.SelectedIndex;
            myActiv = textBox1.Text;
            mylist.Insert(selected_items,"-" + myActiv);
            listBox1.DataSource = null;
            listBox1.DataSource = mylist;
            panel1.Visible = false;
        }
        
    }
}
