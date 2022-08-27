namespace TypeOperator
{
    public static class DateTimeExtension
    {
        /// <summary>
        /// Chuyển DateTime thành chuổi YYYYMM
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        public static string ToYYYYMM(this DateTime date)
        {
            return $"{date.Year}{Month2String(date.Month)}";
        }

        private static string Month2String(int month)
        {
            if (month > 9)
                return month.ToString();
            else
                return $"0{month}";
        }
    }
}