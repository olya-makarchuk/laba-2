using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_2
{
    public class DateInterval
    {
        public DateTime Start { get; set; }
        public DateTime End { get; set; }

        public int date_res;
        private int Diff_date()
        {
            var res = End - Start;
            date_res = res.Days;

            return date_res;
        }
        public int Print_date
        {
            get
            {
                return Diff_date();
            }
        }

        private int Diff_mon()
        {
            var yeardif = End.Year - Start.Year;
            var mon = yeardif * 12 + (End.Month - Start.Month);

            return mon;
        }
        public int Print_mon
        {
            get
            {
                return Diff_mon();
            }
        }

        private int Diff_year()
        {
            var yeardiff = End.Year - Start.Year;

            return yeardiff;
        }
        public int Print_year
        {
            get
            {
                return Diff_year();
            }
        }

        private string DayOfWeek()
        {
            string res = $"\t\t     {Start.DayOfWeek} \t {End.DayOfWeek}";
            return res;
        }
        public string Print_DayWeek
        {
            get
            {
                return DayOfWeek();
            }
        }

        private int Diff_week()
        {
            int week = date_res / 7;
            return week;
        }
        public int Print_week
        {
            get
            {
                return Diff_week();
            }
        }
        public void Print()
        {
            Console.WriteLine($"Рiзниця мiж датами: {Start}     {End}");
            Console.WriteLine(Print_DayWeek);
            Console.WriteLine($"В днях:    {Print_date}");
            Console.WriteLine($"В тижнях:  {Print_week}");
            Console.WriteLine($"В мiсяцях: {Print_mon}");
            Console.WriteLine($"В роках:   {Print_year}");
        }
    }
}
