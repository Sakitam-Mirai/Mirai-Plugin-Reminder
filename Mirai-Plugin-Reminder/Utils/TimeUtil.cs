using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mirai_Plugin_Reminder.Utils
{
    public static class TimeUtil
    {
        public static bool IsTime(int second)
        {
            return DateTime.Now.Second == second;
        }

        public static bool IsTime(int second, int minute)
        {
            return IsTime(second) && DateTime.Now.Minute == minute;
        }

        public static bool IsTime(int second, int minute, int hour)
        {
            return IsTime(second, minute) && DateTime.Now.Hour == hour;
        }

        public static bool IsTime(int second, int minute, int hour, int day)
        {
            return IsTime(second, minute, hour) && DateTime.Now.Day == day;
        }

        public static bool IsTime(int second, int minute, int hour, int day, int month)
        {
            return IsTime(second, minute, hour, day) && DateTime.Now.Month == month;
        }

        public static bool IsTime(int second, int minute, int hour, int day, int month, int year)
        {
            return IsTime(second, minute, hour, day, month) && DateTime.Now.Year == year;
        }
    }
}
