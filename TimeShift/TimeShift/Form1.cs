using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;

namespace TimeShift
{
    public partial class Form1 : Form
    {
        private DateTime _dateTime = System.DateTime.Now;
        private DateTime _baseTime = System.DateTime.Now;
        public Form1()
        {
            InitializeComponent();
            init();
        }
        public void init(){
            SetDate(_dateTime);

            if (TokenType.TOKEN_ELEVATION_TYPE.TokenElevationTypeFull == TokenType.GetTokenElevationType())
            {
                label2.Text = "";
            }
            else
            {
                label2.Text = "「管理者として実行」で起動してください。";
                button1.Enabled = false;
            }

        }



        private void button1_Click(object sender, EventArgs e)
        {
            SetDateTime.SetSysTime(_dateTime);
            monthCalendar1.TodayDate = _dateTime;
        }
        private void yearIncriment_Click(object sender, EventArgs e)
        {
            SetDate(_dateTime.AddYears(1));
        }

        private void yearDecrement_Click(object sender, EventArgs e)
        {
            SetDate(_dateTime.AddYears(-1));
        }

        private void monthIncriment_Click(object sender, EventArgs e)
        {
            SetDate(_dateTime.AddMonths(1));
        }

        private void monthDecrement_Click(object sender, EventArgs e)
        {
            SetDate(_dateTime.AddMonths(-1));
        }
        private void daysIncriment_Click(object sender, EventArgs e)
        {
            SetDate(_dateTime.AddDays(1));
        }

        private void daysDecrement_Click(object sender, EventArgs e)
        {
            SetDate(_dateTime.AddDays(-1));
        }

        private void hourIncriment_Click(object sender, EventArgs e)
        {
            SetDate(_dateTime.AddHours(1));
        }
        private void button2_Click(object sender, EventArgs e)
        {
            //_dateTime
            int year = _dateTime.Year;
            int month = _dateTime.Month;
            int day = _dateTime.Day;
            
            if ((month*100+day) >= 229)
            {
                year++;
            }

            while (!DateTime.IsLeapYear(year))
            {
                year++;
            }

            SetDate(new DateTime(year, 2, 29, _dateTime.Hour, _dateTime.Minute, _dateTime.Second));
        }

        private void ntp_button_Click(object sender, EventArgs e)
        {
            //SetDate(_baseTime);
            SetDate(SetDateTime.setNTP());
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            DateTime dateTime = monthCalendar1.SelectionStart;
            dateTime = dateTime.AddHours(_dateTime.Hour);
            dateTime = dateTime.AddMinutes(_dateTime.Minute);
            dateTime = dateTime.AddSeconds(_dateTime.Second);
            SetDate(dateTime);
        }
        private void SetDate(DateTime dateTime)
        {
            _dateTime = dateTime;
            monthCalendar1.SetDate(_dateTime);
            epochsec.Text = "UNIX time:" + UnixEpochTime.toUnixEpochTime(_dateTime.ToUniversalTime().Ticks).ToString();
            string str = _dateTime.ToLongTimeString();


            timeTB.Text = (str.Length == 8) ? str : "0" + str;
        }

        private void hourDecrement_Click(object sender, EventArgs e)
        {
            SetDate(_dateTime.AddHours(-1));
        }

        private void minuteIncriment_Click(object sender, EventArgs e)
        {
            SetDate(_dateTime.AddMinutes(1));
        }

        private void minuteDecrement_Click(object sender, EventArgs e)
        {
            SetDate(_dateTime.AddMinutes(-1));
        }

        private void secIncriment_Click(object sender, EventArgs e)
        {
            SetDate(_dateTime.AddSeconds(1));
        }

        private void secDecrement_Click(object sender, EventArgs e)
        {
            SetDate(_dateTime.AddSeconds(-1));
        }

        private void timeTB_TextChanged(object sender, EventArgs e)
        {
            string text = timeTB.Text;

            bool isMatch = Regex.IsMatch(text, @"^\d\d:\d\d:\d\d$", System.Text.RegularExpressions.RegexOptions.ECMAScript);

            if(!isMatch){
                return;
            }
            char[] sep = ":".ToCharArray();
            string[] list = text.Split(sep);

            setDateTime(int.Parse(list[0]), int.Parse(list[1]), int.Parse(list[2]));
        }

        private void setDateTime(int hour, int minute, int sec)
        {
            _dateTime = _dateTime.AddHours(hour % 24 - _dateTime.Hour);
            _dateTime = _dateTime.AddMinutes(minute % 60 - _dateTime.Minute);
            _dateTime = _dateTime.AddSeconds(sec % 60 - _dateTime.Second);
            SetDate(_dateTime);
        }

        private void randomButton_Click(object sender, EventArgs e)
        {
            Random random = new Random();

            //random.Next(365 * 12 * 31);
            //24 * 60 * 60


            //SetDate(_baseTime.AddDays(random.Next(365)));
            SetDate(_baseTime.AddSeconds(random.Next(10 * 365 * 24 * 60 * 60)));
        }



    }
}
