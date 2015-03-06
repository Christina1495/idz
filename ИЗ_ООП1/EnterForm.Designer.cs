namespace ИЗ_ООП1
{
    partial class EnterForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EnterForm));
            this.pMain = new System.Windows.Forms.Panel();
            this.bNext1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.rbRelax = new System.Windows.Forms.RadioButton();
            this.rbOffical = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pOffical = new System.Windows.Forms.Panel();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.pRelax = new System.Windows.Forms.Panel();
            this.bBack2 = new System.Windows.Forms.Button();
            this.checkBox8 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.bNext3 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.bNext2 = new System.Windows.Forms.Button();
            this.pMain.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.pOffical.SuspendLayout();
            this.pRelax.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pMain
            // 
            this.pMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pMain.Controls.Add(this.bNext1);
            this.pMain.Controls.Add(this.groupBox1);
            this.pMain.Controls.Add(this.rbRelax);
            this.pMain.Controls.Add(this.rbOffical);
            this.pMain.Controls.Add(this.label3);
            this.pMain.Controls.Add(this.label2);
            this.pMain.Controls.Add(this.label1);
            this.pMain.Controls.Add(this.textBox2);
            this.pMain.Controls.Add(this.textBox1);
            this.pMain.Location = new System.Drawing.Point(12, 12);
            this.pMain.Name = "pMain";
            this.pMain.Size = new System.Drawing.Size(391, 470);
            this.pMain.TabIndex = 0;
            // 
            // bNext1
            // 
            this.bNext1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.bNext1.Font = new System.Drawing.Font("Minion Pro Med", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bNext1.Location = new System.Drawing.Point(0, 399);
            this.bNext1.Name = "bNext1";
            this.bNext1.Size = new System.Drawing.Size(391, 71);
            this.bNext1.TabIndex = 4;
            this.bNext1.Text = "Далее";
            this.bNext1.UseVisualStyleBackColor = false;
            this.bNext1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(23, 116);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(232, 70);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Укажите пол:";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(121, 27);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(101, 29);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Женский";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 27);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(109, 29);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Мужской ";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // rbRelax
            // 
            this.rbRelax.BackgroundImage = global::ИЗ_ООП1.Properties.Resources.ДП;
            this.rbRelax.Location = new System.Drawing.Point(203, 230);
            this.rbRelax.Name = "rbRelax";
            this.rbRelax.Size = new System.Drawing.Size(142, 111);
            this.rbRelax.TabIndex = 9;
            this.rbRelax.TabStop = true;
            this.rbRelax.UseVisualStyleBackColor = true;
            // 
            // rbOffical
            // 
            this.rbOffical.BackgroundImage = global::ИЗ_ООП1.Properties.Resources.О;
            this.rbOffical.Location = new System.Drawing.Point(23, 230);
            this.rbOffical.Name = "rbOffical";
            this.rbOffical.Size = new System.Drawing.Size(142, 111);
            this.rbOffical.TabIndex = 8;
            this.rbOffical.TabStop = true;
            this.rbOffical.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(18, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(220, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Установите тип поездки:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(18, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(281, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Введите количество дней поездки:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(18, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Город:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(23, 91);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(321, 20);
            this.textBox2.TabIndex = 1;
            this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(23, 40);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(321, 20);
            this.textBox1.TabIndex = 0;
            // 
            // pOffical
            // 
            this.pOffical.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pOffical.Controls.Add(this.checkBox3);
            this.pOffical.Controls.Add(this.checkBox2);
            this.pOffical.Controls.Add(this.checkBox1);
            this.pOffical.Font = new System.Drawing.Font("Minion Pro Med", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pOffical.Location = new System.Drawing.Point(44, 106);
            this.pOffical.Name = "pOffical";
            this.pOffical.Size = new System.Drawing.Size(344, 241);
            this.pOffical.TabIndex = 1;
            // 
            // checkBox3
            // 
            this.checkBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.checkBox3.Location = new System.Drawing.Point(55, 157);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(200, 65);
            this.checkBox3.TabIndex = 2;
            this.checkBox3.Text = "Конференция";
            this.checkBox3.UseVisualStyleBackColor = false;
            // 
            // checkBox2
            // 
            this.checkBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.checkBox2.Location = new System.Drawing.Point(55, 15);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(200, 65);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "Переговоры";
            this.checkBox2.UseVisualStyleBackColor = false;
            // 
            // checkBox1
            // 
            this.checkBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.checkBox1.Location = new System.Drawing.Point(55, 86);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(200, 65);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Деловой ужин";
            this.checkBox1.UseVisualStyleBackColor = false;
            // 
            // pRelax
            // 
            this.pRelax.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pRelax.Controls.Add(this.bBack2);
            this.pRelax.Controls.Add(this.checkBox8);
            this.pRelax.Controls.Add(this.checkBox5);
            this.pRelax.Controls.Add(this.checkBox7);
            this.pRelax.Controls.Add(this.checkBox6);
            this.pRelax.Controls.Add(this.bNext3);
            this.pRelax.Font = new System.Drawing.Font("Minion Pro Med", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pRelax.Location = new System.Drawing.Point(29, 149);
            this.pRelax.Name = "pRelax";
            this.pRelax.Size = new System.Drawing.Size(341, 158);
            this.pRelax.TabIndex = 4;
            // 
            // bBack2
            // 
            this.bBack2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.bBack2.Font = new System.Drawing.Font("Minion Pro Med", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bBack2.Location = new System.Drawing.Point(0, 399);
            this.bBack2.Name = "bBack2";
            this.bBack2.Size = new System.Drawing.Size(194, 71);
            this.bBack2.TabIndex = 9;
            this.bBack2.Text = "Назад";
            this.bBack2.UseVisualStyleBackColor = false;
            // 
            // checkBox8
            // 
            this.checkBox8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.checkBox8.Location = new System.Drawing.Point(176, 78);
            this.checkBox8.Name = "checkBox8";
            this.checkBox8.Size = new System.Drawing.Size(165, 60);
            this.checkBox8.TabIndex = 8;
            this.checkBox8.Text = "Пикник";
            this.checkBox8.UseVisualStyleBackColor = false;
            // 
            // checkBox5
            // 
            this.checkBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.checkBox5.Location = new System.Drawing.Point(0, 12);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(165, 60);
            this.checkBox5.TabIndex = 3;
            this.checkBox5.Text = "Катание на лыжах";
            this.checkBox5.UseVisualStyleBackColor = false;
            // 
            // checkBox7
            // 
            this.checkBox7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.checkBox7.Location = new System.Drawing.Point(0, 78);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(165, 60);
            this.checkBox7.TabIndex = 7;
            this.checkBox7.Text = "Экскурсия";
            this.checkBox7.UseVisualStyleBackColor = false;
            // 
            // checkBox6
            // 
            this.checkBox6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.checkBox6.Location = new System.Drawing.Point(176, 12);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(165, 60);
            this.checkBox6.TabIndex = 6;
            this.checkBox6.Text = "Пляж";
            this.checkBox6.UseVisualStyleBackColor = false;
            // 
            // bNext3
            // 
            this.bNext3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.bNext3.Font = new System.Drawing.Font("Minion Pro Med", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bNext3.Location = new System.Drawing.Point(197, 399);
            this.bNext3.Name = "bNext3";
            this.bNext3.Size = new System.Drawing.Size(194, 71);
            this.bNext3.TabIndex = 5;
            this.bNext3.Text = "Далее";
            this.bNext3.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.pOffical);
            this.panel1.Controls.Add(this.pRelax);
            this.panel1.Controls.Add(this.bNext2);
            this.panel1.Location = new System.Drawing.Point(11, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(392, 470);
            this.panel1.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Monotype Corsiva", 26.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(3, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(385, 100);
            this.label4.TabIndex = 6;
            this.label4.Text = "Выберите чем вы будете заниматься в поездке:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button2.Font = new System.Drawing.Font("Minion Pro Med", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(0, 383);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(193, 87);
            this.button2.TabIndex = 5;
            this.button2.Text = "Назад";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // bNext2
            // 
            this.bNext2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.bNext2.Font = new System.Drawing.Font("Minion Pro Med", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bNext2.Location = new System.Drawing.Point(199, 383);
            this.bNext2.Name = "bNext2";
            this.bNext2.Size = new System.Drawing.Size(192, 87);
            this.bNext2.TabIndex = 4;
            this.bNext2.Text = "Далее";
            this.bNext2.UseVisualStyleBackColor = false;
            this.bNext2.Click += new System.EventHandler(this.bNext2_Click_1);
            // 
            // EnterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(414, 488);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pMain);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EnterForm";
            this.Text = "Список вещей";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EnterForm_FormClosing);
            this.pMain.ResumeLayout(false);
            this.pMain.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.pOffical.ResumeLayout(false);
            this.pRelax.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pMain;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bNext1;
        private System.Windows.Forms.Panel pOffical;
        public System.Windows.Forms.RadioButton rbRelax;
        public System.Windows.Forms.RadioButton rbOffical;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Panel pRelax;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.Button bNext3;
        private System.Windows.Forms.CheckBox checkBox8;
        private System.Windows.Forms.CheckBox checkBox7;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.Button bBack2;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.RadioButton radioButton2;
        public System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button bNext2;
        private System.Windows.Forms.Label label4;
    }
}

