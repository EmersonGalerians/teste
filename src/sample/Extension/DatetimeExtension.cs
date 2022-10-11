using System;

namespace Sample.Extension
{
    public static class DatetimeExtensions
    {
        public static string ToStringShortPtBR(this DateTime date)
        {
            return date.ToString("dd/MM/yyyy");
        }

        public static string ToStringPtBR(this DateTime date)
        {
            return date.ToString("dd/MM/yyyy HH:mm:ss");
        }
    }
}
