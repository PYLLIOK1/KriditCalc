namespace KriditCalc
{
    partial class One
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose (bool disposing)
        {
            if (disposing && ( components != null ))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent ()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Sumcredit = new System.Windows.Forms.TextBox();
            this.Komissia = new System.Windows.Forms.TextBox();
            this.Procstavka = new System.Windows.Forms.TextBox();
            this.Srokcredit = new System.Windows.Forms.TextBox();
            this.Vidplateja = new System.Windows.Forms.ComboBox();
            this.mesac = new System.Windows.Forms.ComboBox();
            this.God = new System.Windows.Forms.ComboBox();
            this.valita = new System.Windows.Forms.ComboBox();
            this.Periucredit = new System.Windows.Forms.ComboBox();
            this.proccreditcombo = new System.Windows.Forms.ComboBox();
            this.komissiacombo = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(127, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Параметры кредита";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(546, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Данные приблизительные. Из-за особенностей расчетов различными банками, результат" +
    "ы, получаемые\r\n по банковским калькуляторам разных банков, могут отличаться.\r\n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Срок кредита:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Сумма кредита:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Процентная ставка:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 270);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(150, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Единовременная комисcия:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 295);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Вид платежей:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 324);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Начало выплат:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(234, 358);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Рассчитать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Sumcredit
            // 
            this.Sumcredit.Location = new System.Drawing.Point(166, 106);
            this.Sumcredit.Name = "Sumcredit";
            this.Sumcredit.ShortcutsEnabled = false;
            this.Sumcredit.Size = new System.Drawing.Size(197, 20);
            this.Sumcredit.TabIndex = 9;
            this.Sumcredit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextboxKeyPress);
            // 
            // Komissia
            // 
            this.Komissia.Location = new System.Drawing.Point(166, 270);
            this.Komissia.Name = "Komissia";
            this.Komissia.ShortcutsEnabled = false;
            this.Komissia.Size = new System.Drawing.Size(197, 20);
            this.Komissia.TabIndex = 10;
            this.Komissia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextboxKeyPress);
            // 
            // Procstavka
            // 
            this.Procstavka.Location = new System.Drawing.Point(166, 169);
            this.Procstavka.MaxLength = 3;
            this.Procstavka.Name = "Procstavka";
            this.Procstavka.ShortcutsEnabled = false;
            this.Procstavka.Size = new System.Drawing.Size(197, 20);
            this.Procstavka.TabIndex = 11;
            this.Procstavka.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextboxKeyPress);
            // 
            // Srokcredit
            // 
            this.Srokcredit.Location = new System.Drawing.Point(166, 137);
            this.Srokcredit.MaxLength = 3;
            this.Srokcredit.Name = "Srokcredit";
            this.Srokcredit.ShortcutsEnabled = false;
            this.Srokcredit.Size = new System.Drawing.Size(197, 20);
            this.Srokcredit.TabIndex = 12;
            this.Srokcredit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextboxKeyPress);
            // 
            // Vidplateja
            // 
            this.Vidplateja.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Vidplateja.FormattingEnabled = true;
            this.Vidplateja.Items.AddRange(new object[] {
            "Дифференцированный",
            "Аннуитетный"});
            this.Vidplateja.Location = new System.Drawing.Point(166, 297);
            this.Vidplateja.Name = "Vidplateja";
            this.Vidplateja.Size = new System.Drawing.Size(197, 21);
            this.Vidplateja.TabIndex = 13;
            // 
            // mesac
            // 
            this.mesac.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.mesac.FormattingEnabled = true;
            this.mesac.Items.AddRange(new object[] {
            "Январь",
            "Февраль",
            "Март",
            "Апрель",
            "Май",
            "Июнь",
            "Июль",
            "Август",
            "Сентябрь",
            "Октябрь",
            "Ноябрь",
            "Декабрь"});
            this.mesac.Location = new System.Drawing.Point(166, 324);
            this.mesac.Name = "mesac";
            this.mesac.Size = new System.Drawing.Size(121, 21);
            this.mesac.TabIndex = 14;
            // 
            // God
            // 
            this.God.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.God.FormattingEnabled = true;
            this.God.Location = new System.Drawing.Point(303, 324);
            this.God.Name = "God";
            this.God.Size = new System.Drawing.Size(121, 21);
            this.God.TabIndex = 15;
            // 
            // valita
            // 
            this.valita.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.valita.FormattingEnabled = true;
            this.valita.Items.AddRange(new object[] {
            "Руб."});
            this.valita.Location = new System.Drawing.Point(372, 106);
            this.valita.Name = "valita";
            this.valita.Size = new System.Drawing.Size(96, 21);
            this.valita.TabIndex = 16;
            // 
            // Periucredit
            // 
            this.Periucredit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Periucredit.FormattingEnabled = true;
            this.Periucredit.Items.AddRange(new object[] {
            "Мес.",
            "Год."});
            this.Periucredit.Location = new System.Drawing.Point(372, 137);
            this.Periucredit.Name = "Periucredit";
            this.Periucredit.Size = new System.Drawing.Size(96, 21);
            this.Periucredit.TabIndex = 17;
            // 
            // proccreditcombo
            // 
            this.proccreditcombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.proccreditcombo.FormattingEnabled = true;
            this.proccreditcombo.Items.AddRange(new object[] {
            "% в год."});
            this.proccreditcombo.Location = new System.Drawing.Point(372, 169);
            this.proccreditcombo.Name = "proccreditcombo";
            this.proccreditcombo.Size = new System.Drawing.Size(164, 21);
            this.proccreditcombo.TabIndex = 18;
            // 
            // komissiacombo
            // 
            this.komissiacombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.komissiacombo.FormattingEnabled = true;
            this.komissiacombo.Items.AddRange(new object[] {
            "% от суммы кредита",
            "Фиксированная сумма"});
            this.komissiacombo.Location = new System.Drawing.Point(372, 269);
            this.komissiacombo.Name = "komissiacombo";
            this.komissiacombo.Size = new System.Drawing.Size(164, 21);
            this.komissiacombo.TabIndex = 19;
            this.komissiacombo.SelectedIndexChanged += new System.EventHandler(this.komissiacombo_SelectedIndexChanged);
            // 
            // One
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 393);
            this.Controls.Add(this.komissiacombo);
            this.Controls.Add(this.proccreditcombo);
            this.Controls.Add(this.Periucredit);
            this.Controls.Add(this.valita);
            this.Controls.Add(this.God);
            this.Controls.Add(this.mesac);
            this.Controls.Add(this.Vidplateja);
            this.Controls.Add(this.Srokcredit);
            this.Controls.Add(this.Procstavka);
            this.Controls.Add(this.Komissia);
            this.Controls.Add(this.Sumcredit);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "One";
            this.Text = "Кредитный калькулятор";
            this.Load += new System.EventHandler(this.One_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Sumcredit;
        private System.Windows.Forms.TextBox Komissia;
        private System.Windows.Forms.TextBox Procstavka;
        private System.Windows.Forms.TextBox Srokcredit;
        private System.Windows.Forms.ComboBox Vidplateja;
        private System.Windows.Forms.ComboBox mesac;
        private System.Windows.Forms.ComboBox God;
        private System.Windows.Forms.ComboBox valita;
        private System.Windows.Forms.ComboBox Periucredit;
        private System.Windows.Forms.ComboBox proccreditcombo;
        private System.Windows.Forms.ComboBox komissiacombo;
    }
}

