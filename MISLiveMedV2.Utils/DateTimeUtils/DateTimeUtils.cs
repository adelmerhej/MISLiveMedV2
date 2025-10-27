using System;
using System.Collections.Generic;
using System.Linq;

namespace MISLiveMed.Utils.DateTimeUtils
{
    public class DateTimeUtils
    {
        public static DateTime MinValue;

        static DateTimeUtils()
        {
            MinValue = new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Local);
        }

        public static DateTime SetDefaultKind(DateTime dateTime, DateTimeKind kind = DateTimeKind.Local)
        {
            DateTime localTime = dateTime;
            if (dateTime.Kind == DateTimeKind.Unspecified)
            {
                localTime = DateTime.SpecifyKind(dateTime, kind);
            }
            else if (dateTime.Kind != kind)
            {
                if (kind == DateTimeKind.Local)
                {
                    localTime = dateTime.ToLocalTime();
                }
                else if (kind == DateTimeKind.Utc)
                {
                    localTime = dateTime.ToUniversalTime();
                }
            }
            return localTime;
        }

        public static DateTime? SetDefaultKind(DateTime? dateTime)
        {
            return !dateTime.HasValue ? null : new DateTime?(SetDefaultKind(dateTime.Value));
        }

        public static DateTime StartOfWeek(DateTime dt, DayOfWeek startOfWeek)
        {
            int diff = (7 + (dt.DayOfWeek - startOfWeek)) % 7;
            return dt.AddDays(-1 * diff).Date;
        }

        public static List<int> CountYearsToDate()
        {
            var startDate = new DateTime(2016, 1, 1);
            var endDate = DateTime.Now;
            int years = (endDate.Year - startDate.Year) + 1;

            List<int> range = Enumerable.Range(0, years)
                .Select(i => startDate.AddYears(i).Year)
                .ToList();

            return range;
        }

    }
}
