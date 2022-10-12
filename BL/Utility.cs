using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FTPBubbleTea.BL
{
    public class Utility
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        public static string ConvertDateTimeToText(DateTime date)
        {
            return string.Format("{0:0000}/{1:00}/{2:00} {3:00}:{4:00}:{5:00}", date.Year, date.Month, date.Day, date.Hour, date.Minute, date.Second);
        }

    }
}
