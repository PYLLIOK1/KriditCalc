using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace KriditCalc
{
    public partial class One : Form
    {
        public One ()
        {
            InitializeComponent();
        }

        private void One_Load (object sender, EventArgs e)
        {
            valita.SelectedIndex = 0;
            Periucredit.SelectedIndex = 0;
            proccreditcombo.SelectedIndex = 0;
            komissiacombo.SelectedIndex = 0;
            Vidplateja.SelectedIndex = 0;
            int godnow = DateTime.Now.Year;
            for (int i = 0; i < 5; i++, godnow++)
            {
                God.Items.Add(godnow);
            }
            God.SelectedIndex = 0;
            mesac.SelectedIndex = 0;
            Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
        }

        private void TextboxKeyPress (object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) && ( sender as TextBox ).Text.Length > 0 )
            {
                if(( sender as TextBox ).Text[0] == '0')
                {
                    ( sender as TextBox ).Text = e.KeyChar.ToString() + Sumcredit.Text.Substring(1, Sumcredit.Text.Length - 1);
                    e.Handled = true;
                    ( sender as TextBox ).Select(1, 0);
                } 
            }
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }
        private void Srokcredit_KeyPress (object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
            if (Srokcredit.Text.Length == 0)
                if (e.KeyChar == '0') e.Handled = true;
        }

        private void Procstavka_KeyPress (object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) && ( sender as TextBox ).Text == "0" && e.KeyChar != '.')
            {
                ( sender as TextBox ).Text = e.KeyChar.ToString();
                e.Handled = true;
                ( sender as TextBox ).Select(1, 0);
            }
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && ( e.KeyChar != '.' || ( sender as TextBox ).Text.IndexOf(".") != -1 ))
            {
                e.Handled = true;
            }
            if (( sender as TextBox ).Text == "" && e.KeyChar == '.')
            {
                e.Handled = true;
            }
        }

        private void Komissia_KeyPress (object sender, KeyPressEventArgs e)
        {
            if (komissiacombo.SelectedIndex == 0)
            {
                if (char.IsDigit(e.KeyChar) && ( sender as TextBox ).Text == "0" && e.KeyChar != '.')
                {
                    ( sender as TextBox ).Text = e.KeyChar.ToString();
                    e.Handled = true;
                    ( sender as TextBox ).Select(1, 0);
                }
                if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && ( e.KeyChar != '.' || ( sender as TextBox ).Text.IndexOf(".") != -1 ))
                {
                    e.Handled = true;
                }
                if (( sender as TextBox ).Text == "" && e.KeyChar == '.')
                {
                    e.Handled = true;
                }
            }
            if (komissiacombo.SelectedIndex == 1)
            {
                if (char.IsDigit(e.KeyChar) && ( sender as TextBox ).Text.Length > 0)
                {
                    if (( sender as TextBox ).Text [0] == '0')
                    {
                        ( sender as TextBox ).Text = e.KeyChar.ToString() + Sumcredit.Text.Substring(1, Sumcredit.Text.Length - 1);
                        e.Handled = true;
                        ( sender as TextBox ).Select(1, 0);
                    }
                }
                if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
                {
                    e.Handled = true;
                }
            }
        }

        private void komissiacombo_SelectedIndexChanged (object sender, EventArgs e)
        {
            if (komissiacombo.SelectedIndex == 0)
            {
                if (Komissia.Text != "")
                {
                    if (Convert.ToInt64(Komissia.Text) > 100)
                    {
                        Komissia.Text = "100";
                    }
                }
            }
        }

        private void button1_Click (object sender, EventArgs e)
        {
            if (Proverka())
            {
                int srok = Srokmes();
                List<double> ostatok = new List<double>();
                List<double> percentPayment = new List<double>();
                List<double> procents = new List<double>();
                double sum = Convert.ToDouble(Sumcredit.Text);
                double proc = Convert.ToDouble(Procstavka.Text);
                double absolit = proc / 100.0 / 12.0;
                if (Vidplateja.SelectedIndex == 0)
                {
                    double mainPayment = Math.Round(sum / srok, 2);
                    double procent = Math.Round(sum * ( proc / 100 ) / 12, 2);
                    procents.Add(procent);
                    double result = mainPayment + procent;
                    percentPayment.Add(Math.Round(result, 2));
                    sum = sum - mainPayment;
                    ostatok.Add(Math.Round(sum, 2));
                    for (int i = 2; i <= srok; i++)
                    {
                        procent = sum * ( proc / 100 ) / 12;
                        procents.Add(Math.Round(procent, 2));
                        result = mainPayment + procent;
                        percentPayment.Add(Math.Round(result, 2));
                        sum = sum - mainPayment;
                        if (sum > 0.00)
                        {
                            ostatok.Add(Math.Round(sum, 2));
                        }
                        else
                        {
                            ostatok.Add(0.00);
                        }
                    }
                    Table table = new Table
                    {
                        Date = Date(srok),
                        Procent = procents,
                        Dolg = mainPayment,
                        Ostatok = ostatok,
                        Sum = percentPayment,
                        TotalPaymentAmount = Math.Round(percentPayment.Sum(x => x), 2),
                        TheOverpaymentOfInterest = Math.Round(procents.Sum(x => x)),
                        OverpaymentWithTheCommission = Math.Round(procents.Sum(x => x) + Komissiaa())
                    };
                    Program.Context.MainForm = new Two(table);
                    Program.Context.MainForm.Show();
                    Close();
                }
                if (Vidplateja.SelectedIndex == 1)
                {
                    double osnovdolg = Osnovdolg(sum, srok, absolit);
                    double procent = Math.Round(sum * ( proc / 100 ) / 12, 2);
                    procents.Add(procent);
                    double result = osnovdolg - procent;
                    percentPayment.Add(Math.Round(result, 2));
                    sum = sum - result;
                    ostatok.Add(Math.Round(sum, 2));
                    for (int i = 2; i <= srok; i++)
                    {
                        procent = sum * ( proc / 100 ) / 12;
                        procents.Add(Math.Round(procent, 2));
                        result = osnovdolg - procent;
                        percentPayment.Add(Math.Round(result, 2));
                        sum = sum - result;
                        if (sum > 0.00)
                        {
                            ostatok.Add(Math.Round(sum, 2));
                        }
                        else
                        {
                            ostatok.Add(0.00);
                        }
                    }
                    Table table = new Table
                    {
                        Date = Date(srok),
                        Procent = procents,
                        Dolg = osnovdolg,
                        Ostatok = ostatok,
                        Sum = percentPayment,
                        TotalPaymentAmount = Math.Round(percentPayment.Sum(x => x) + procents.Sum(x => x), 2),
                        TheOverpaymentOfInterest = Math.Round(procents.Sum(x => x)),
                        OverpaymentWithTheCommission = Math.Round(procents.Sum(x => x) + Komissiaa())
                    };
                    Program.Context.MainForm = new Two(table);
                    Program.Context.MainForm.Show();
                    Close();
                }
            }
        }
        public bool Proverka ()
        {
            if (Sumcredit.Text != "" || Srokcredit.Text != "" || Komissia.Text != "" || Procstavka.Text != "")
            {
                return true;
            }
            else
            {
                MessageBox.Show("Введите все данные");
                return false;
            }
        }
        public int Srokmes ()
        {
            if (Periucredit.SelectedIndex == 0)
            {
                return Convert.ToInt16(Srokcredit.Text);
            }
            else
            {
                return Convert.ToInt16(Srokcredit.Text) * 12;
            }
        }
        public double Osnovdolg (double sum, double srok, double absolit)
        {
            double result = ( ( absolit * Math.Pow(( 1 + absolit ), srok) ) / ( ( Math.Pow(( 1 + absolit ), srok) - 1 ) ) * sum );
            return Math.Round(result, 2);
        }
        public List<string> Date (int mes)
        {
            List<string> list = new List<string>();
            string tecgod = God.SelectedItem.ToString();
            string date = mesac.SelectedItem.ToString() + ", " + tecgod;
            list.Add(date);
            for (int i = 1; i < mes; i++)
            {
                if (mesac.SelectedIndex == 11)
                {
                    mesac.SelectedIndex = 0;
                    tecgod = Convert.ToString(Convert.ToInt32(tecgod) + 1);
                    date = mesac.SelectedItem.ToString() + ", " + tecgod;
                    list.Add(date);
                }
                else
                {
                    mesac.SelectedIndex = mesac.SelectedIndex + 1;
                    date = mesac.SelectedItem.ToString() + ", " + tecgod;
                    list.Add(date);
                }
            }
            return list;
        }
        public double Komissiaa ()
        {
            if (komissiacombo.SelectedIndex == 0)
            {
                double a = Convert.ToDouble(Komissia.Text);
                double b = Convert.ToDouble(Sumcredit.Text);
                return a * b / 100;
            }
            else
            {
                return Convert.ToInt64(Komissia.Text);
            }
        }


        private void Procstavka_TextChanged (object sender, EventArgs e)
        {
            if (double.TryParse(Procstavka.Text, out double num))
            {
                num = Convert.ToDouble(Procstavka.Text);
                if (num >= 100)
                {
                    Procstavka.Text = "100";
                }
            }
        }

        private void Sumcredit_TextChanged (object sender, EventArgs e)
        {
            if(Sumcredit.Text != "")
            {
                if (Convert.ToInt64(Sumcredit.Text) > int.MaxValue)
                {
                    Sumcredit.Text = int.MaxValue.ToString();
                }
            }
        }
    }
}

