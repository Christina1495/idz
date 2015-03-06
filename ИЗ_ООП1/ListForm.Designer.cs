namespace ИЗ_ООП1
{
    partial class ListForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListForm));
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.добавитьНовыйЭлементToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.удалитьВыбранныйЭлементToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.сохранитьСписокВФайлToolStripMenuItem = new System.Windows.Forms.ToolStripTextBox();
            this.открытьФайлToolStripMenuItem = new System.Windows.Forms.ToolStripTextBox();
            this.печатьСпискаToolStripMenuItem = new System.Windows.Forms.ToolStripTextBox();
            this.вернутьсяВПредыдущиеОкноToolStripMenuItem = new System.Windows.Forms.ToolStripTextBox();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bAdd = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Minion Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // listBox1
            // 
            this.listBox1.ContextMenuStrip = this.contextMenuStrip1;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 100);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(536, 485);
            this.listBox1.TabIndex = 1;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьНовыйЭлементToolStripMenuItem,
            this.toolStripSeparator1,
            this.удалитьВыбранныйЭлементToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(236, 54);
            // 
            // добавитьНовыйЭлементToolStripMenuItem
            // 
            this.добавитьНовыйЭлементToolStripMenuItem.Name = "добавитьНовыйЭлементToolStripMenuItem";
            this.добавитьНовыйЭлементToolStripMenuItem.Size = new System.Drawing.Size(235, 22);
            this.добавитьНовыйЭлементToolStripMenuItem.Text = "Добавить новый элемент";
            this.добавитьНовыйЭлементToolStripMenuItem.Click += new System.EventHandler(this.добавитьНовыйЭлементToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(232, 6);
            // 
            // удалитьВыбранныйЭлементToolStripMenuItem
            // 
            this.удалитьВыбранныйЭлементToolStripMenuItem.Name = "удалитьВыбранныйЭлементToolStripMenuItem";
            this.удалитьВыбранныйЭлементToolStripMenuItem.Size = new System.Drawing.Size(235, 22);
            this.удалитьВыбранныйЭлементToolStripMenuItem.Text = "Удалить выбранный элемент";
            this.удалитьВыбранныйЭлементToolStripMenuItem.Click += new System.EventHandler(this.удалитьВыбранныйЭлементToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сохранитьСписокВФайлToolStripMenuItem,
            this.открытьФайлToolStripMenuItem,
            this.печатьСпискаToolStripMenuItem,
            this.вернутьсяВПредыдущиеОкноToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(560, 27);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // сохранитьСписокВФайлToolStripMenuItem
            // 
            this.сохранитьСписокВФайлToolStripMenuItem.BackColor = System.Drawing.SystemColors.Info;
            this.сохранитьСписокВФайлToolStripMenuItem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.сохранитьСписокВФайлToolStripMenuItem.Name = "сохранитьСписокВФайлToolStripMenuItem";
            this.сохранитьСписокВФайлToolStripMenuItem.Size = new System.Drawing.Size(160, 23);
            this.сохранитьСписокВФайлToolStripMenuItem.Text = "Сохранить список в файл";
            this.сохранитьСписокВФайлToolStripMenuItem.Click += new System.EventHandler(this.сохранитьСписокВФайлToolStripMenuItem_Click);
            // 
            // открытьФайлToolStripMenuItem
            // 
            this.открытьФайлToolStripMenuItem.BackColor = System.Drawing.SystemColors.Info;
            this.открытьФайлToolStripMenuItem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.открытьФайлToolStripMenuItem.Name = "открытьФайлToolStripMenuItem";
            this.открытьФайлToolStripMenuItem.Size = new System.Drawing.Size(98, 23);
            this.открытьФайлToolStripMenuItem.Text = "Открыть файл";
            this.открытьФайлToolStripMenuItem.Click += new System.EventHandler(this.открытьФайлToolStripMenuItem_Click);
            // 
            // печатьСпискаToolStripMenuItem
            // 
            this.печатьСпискаToolStripMenuItem.BackColor = System.Drawing.SystemColors.Info;
            this.печатьСпискаToolStripMenuItem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.печатьСпискаToolStripMenuItem.Name = "печатьСпискаToolStripMenuItem";
            this.печатьСпискаToolStripMenuItem.Size = new System.Drawing.Size(99, 23);
            this.печатьСпискаToolStripMenuItem.Text = "Печать списка";
            this.печатьСпискаToolStripMenuItem.Click += new System.EventHandler(this.печатьСпискаToolStripMenuItem_Click);
            // 
            // вернутьсяВПредыдущиеОкноToolStripMenuItem
            // 
            this.вернутьсяВПредыдущиеОкноToolStripMenuItem.BackColor = System.Drawing.SystemColors.Info;
            this.вернутьсяВПредыдущиеОкноToolStripMenuItem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.вернутьсяВПредыдущиеОкноToolStripMenuItem.Name = "вернутьсяВПредыдущиеОкноToolStripMenuItem";
            this.вернутьсяВПредыдущиеОкноToolStripMenuItem.Size = new System.Drawing.Size(187, 23);
            this.вернутьсяВПредыдущиеОкноToolStripMenuItem.Text = "вернуться в предыдущие окно";
            this.вернутьсяВПредыдущиеОкноToolStripMenuItem.Click += new System.EventHandler(this.вернутьсяВПредыдущиеОкноToolStripMenuItem_Click);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // printDocument1
            // 
            this.printDocument1.BeginPrint += new System.Drawing.Printing.PrintEventHandler(this.printDocument1_BeginPrint);
            this.printDocument1.EndPrint += new System.Drawing.Printing.PrintEventHandler(this.printDocument1_EndPrint);
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "\"Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*\"";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "\"Текстовые файлы (*.txt)|*.txt| Microsoft Office Word (*.doc)|*.doc|Все файлы (*." +
    "*)|*.*\"";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.bAdd);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(38, 193);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(428, 58);
            this.panel1.TabIndex = 3;
            // 
            // bAdd
            // 
            this.bAdd.Location = new System.Drawing.Point(297, 25);
            this.bAdd.Name = "bAdd";
            this.bAdd.Size = new System.Drawing.Size(117, 23);
            this.bAdd.TabIndex = 5;
            this.bAdd.Text = "Продолжить=>";
            this.bAdd.UseVisualStyleBackColor = true;
            this.bAdd.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(7, 27);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(284, 20);
            this.textBox1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Minion Pro Med", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(411, 47);
            this.label2.TabIndex = 3;
            this.label2.Text = "введите вещь, которую вы хотите добавить в список:";
            // 
            // ListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(560, 589);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ListForm";
            this.Text = "Список вещей";
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripTextBox сохранитьСписокВФайлToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox открытьФайлToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox печатьСпискаToolStripMenuItem;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripTextBox вернутьсяВПредыдущиеОкноToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem добавитьНовыйЭлементToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьВыбранныйЭлементToolStripMenuItem;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bAdd;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}