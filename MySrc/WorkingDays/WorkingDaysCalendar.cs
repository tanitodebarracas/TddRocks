﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WorkingDays
{
    public class WorkingDaysCalendar
    {
        public bool IsWorkingDay(DateTime day)
        {
            if (day.DayOfWeek == DayOfWeek.Sunday)
                return false;

            return true;
        }
    }
}
