using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace KriditCalc
{
    public partial class Two : Form
    {
        public Table Table = new Table();
        public Two (Table table)
        {
            InitializeComponent();
            saveFileDialog1.Filter = "CSV files(*.csv)|*.csv";
            Table = table;
            dataGridView1.AllowUserToAddRows = false;
            date(table.Date [0]);
        }
        private void Back_Click (object sender, EventArgs e)
        {
            Program.Context.MainForm = new One();
            Program.Context.MainForm.Show();
            Close();
        }

        private void filesave_Click (object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = saveFileDialog1.FileName;
            using (StreamWriter sw = new StreamWriter(filename, true, Encoding.UTF8))
            {
                sw.WriteLine("Номер,Дата,Сумма,Долг,Проценты,Остаток");
                for (int i = 0; i < Table.Date.Count; i++)
                {
                    string str = Convert.ToString(i + 1) + "," + date(Table.Date [i]) + "," + Table.Sum [i].ToString().Replace(",", ".") + "," +
                        Table.Dolg.ToString().Replace(",", ".") + "," + Table.Procent [i].ToString().Replace(",", ".") + "," + Table.Ostatok [i].ToString().Replace(",", ".");
                    sw.WriteLine(str);
                }
                sw.Close();
            }
            MessageBox.Show("Файл сохранен");
        }

        private void Two_Load (object sender, EventArgs e)
        {
            label4.Text = Table.TotalPaymentAmount.ToString() + " руб.";
            label5.Text = Table.TheOverpaymentOfInterest.ToString() + " руб.";
            label6.Text = Table.OverpaymentWithTheCommission.ToString() + " руб.";
            for (int i = 0; i < Table.Date.Count; i++)
            {
                string [] str = { Convert.ToString(i + 1), Table.Date [i], Table.Sum [i].ToString(), Table.Dolg.ToString(), Table.Procent [i].ToString(), Table.Ostatok [i].ToString() };
                dataGridView1.Rows.Add(Convert.ToString(i + 1), Table.Date [i], Table.Sum [i].ToString(), Table.Dolg.ToString(), Table.Procent [i].ToString(), Table.Ostatok [i].ToString());
            }
        }
        public string date (string str)
        {
            str = str.Replace(" ", "-").Replace(",", "").Replace("Январь", "01").Replace("Февраль", "02").Replace("Март", "03").Replace("Апрель", "04")
                .Replace("Май", "05").Replace("Июнь", "06").Replace("Июль", "07").Replace("Август", "08").Replace("Сентябрь", "09")
                .Replace("Октябрь", "10").Replace("Ноябрь", "11").Replace("Декабрь", "12");
            return str;
        }
    }
}
