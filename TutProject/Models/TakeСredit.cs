using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TutProject.Models
{
    public class TakeСredit
    {
        public double Money { get; set; }

        public double Time { get; set; }

        public double Prc { get; set; }
        public int t { get; private set; }

        public string[] get_head()
        {
            string[] arr_str = { "№", "Дата платежа", "Сумма платежа", "Основной долг", "Проценты", "Остаток долга" };
            return arr_str;
        }


        public string[,] get_body()
        {
            double x, y;

            //DateTime date1 = new DateTime();
           // DateTime date1 = DateTime.Now.AddMonths(i).to
            y = (double)Prc / 100 / 12;
            x = (double)Money * (y + (y / ((double)Math.Pow(1 + y, (double)Time) - 1)));
            x = Math.Round(x);
            t = (int)Math.Round(Time);
            
            string[,] arr_table_row = new string[t, 6];
            
            for (int i = 0; i < t; i++)
            {
                Prc *= y;
                Money -= (x - Math.Round(Money * y));
                //teloCredita = (double)(x - Prc);
                arr_table_row[i, 0] = (i + 1).ToString();
                arr_table_row[i, 1] = DateTime.Now.AddMonths(i).ToLongDateString().ToString();
                arr_table_row[i, 2] = x.ToString();
                arr_table_row[i, 3] = Math.Round(x - Money * y).ToString();
                arr_table_row[i, 4] = Math.Round(Money * y).ToString();
                arr_table_row[i, 5] = Money.ToString();


            }

            return arr_table_row;
        }
/*        public int[,] get_body() 
        {

            int[,] mas = { { 1, 2, 3, 4, 5 , 6 }, { 1, 2, 3, 4, 5, 6 }, { 1, 2, 3, 4, 5, 6 }, { 1, 2, 3, 4, 5, 6 }};

            return mas;
        }*/

    }
}