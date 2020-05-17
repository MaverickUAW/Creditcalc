using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditCal
{
    class CR
    {
       

        public CR()
        {
           
          
            Termin = 0;
            count_Of_Credit = 0;
            month_Pay = 0;
            Summ_Payment = 0;
            percent = 0;
        }

        public double vzTerm()
        {
            Term(0);
            Termin = Summ_Payment / month_Pay;
            return Termin;
        }


        public double CountOfCredit()
        {
            count_Of_Credit = ((month_Pay * Termin) / Math.Pow((1 + percent / 100), Termin));
            return count_Of_Credit;
        }

        public double CountOfPay()
        {
            Summ_Payment = month_Pay * Termin;
            return Summ_Payment;
        }

        public double CountOfPayTerm()
        {
            Summ_Payment = month_Pay * Termin + count_Of_Credit;
            return Summ_Payment;
        }

        public double Procent()
        {
            percent = (Math.Pow(CountOfCredit() / count_Of_Credit, 1 / Termin) - 1) * 100;
            return percent;
        }

        private void Term(int Termin_)
        {
            Termin = Termin_;
        }

       

      
        public static int Zapros {

            get;

            set; 
        }

        private double count_Of_Credit;

        private double percent;

        private double Termin;

        private double month_Pay;

        private double Summ_Payment;

        public CR(double count_Of_Credit_, double percent_, double Termin_, double month_Pay_, double Summ_Payment_)
        {
            count_Of_Credit = count_Of_Credit_;

            percent = percent_;

            Termin = Termin_;

            month_Pay = month_Pay_;

            Summ_Payment = Summ_Payment_;

        }
    }
}
    

