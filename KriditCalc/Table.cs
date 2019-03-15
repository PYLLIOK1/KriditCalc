using System.Collections.Generic;

namespace KriditCalc
{
    public class Table
    {
        public List<string> Date { get; set; }

        public List<double> Sum { get; set; }

        public double Dolg { get; set; }

        public List<double> Procent { get; set; }

        public List<double> Ostatok { get; set; }

        public double TotalPaymentAmount { get; set; }

        public double TheOverpaymentOfInterest { get; set; }

        public double OverpaymentWithTheCommission { get; set; }
    }
}
