﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop.Common.DateTime
{
    public static class DateTimeTools
    {
        public static string ToPersianDate(this System.DateTime dt)
        {
            var pc = new PersianCalendar();
            var day = pc.GetDayOfMonth(dt);
            var month = pc.GetMonth(dt);
            var year = pc.GetYear(dt);
            return $"{year}/{month}/{day}";
        }
    }
}