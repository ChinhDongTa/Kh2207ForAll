using System.Text;

namespace TypeOperator
{
    /// <summary>
    /// Extension methods for the number type.
    /// </summary>
    public static class NumberExtensions
    {
        /// <summary>
        /// Chuyển số nguyên ra số La mã
        /// </summary>
        /// <param name="number">
        /// Số nguyên cần chuyển
        /// </param>
        /// <returns>
        /// 1 chuổi miêu tả dãy số La Mã
        /// </returns>
        public static string ToRomanNumeral(this int number)
        {
            var retVal = new StringBuilder(5);
            var valueMap = new SortedDictionary<int, string>
                               {
                                   { 1, "I" },
                                   { 4, "IV" },
                                   { 5, "V" },
                                   { 9, "IX" },
                                   { 10, "X" },
                                   { 40, "XL" },
                                   { 50, "L" },
                                   { 90, "XC" },
                                   { 100, "C" },
                                   { 400, "CD" },
                                   { 500, "D" },
                                   { 900, "CM" },
                                   { 1000, "M" },
                               };

            foreach (var kvp in valueMap.Reverse())
            {
                while (number >= kvp.Key)
                {
                    number -= kvp.Key;
                    retVal.Append(kvp.Value);
                }
            }
            return retVal.ToString();
        }

        /// <summary>
        /// Chuyển số sang định dạng VN
        /// </summary>
        /// <param name="d"></param>
        /// <returns></returns>
        public static string ToVietNamDecimal(this double d)
        {
            var s = d.ToString();
            return s.Replace('.', ',');
        }

        /// <summary>
        /// Chuyển số sang định dạng VN
        /// </summary>
        /// <param name="d"></param>
        /// <returns></returns>
        public static string ToVietNamDecimal(this double? d)
        {
            if (d.HasValue)
                return d.Value.ToVietNamDecimal();
            return string.Empty;
        }

        /// <summary>
        /// Làm tròn 3 số thập phân, 1.003 =>1 ; 1.005 =>2
        /// </summary>
        /// <param name="d"></param>
        /// <returns></returns>
        public static double Round3Decimal(this double d)
        {
            return Math.Round(d * 1000) / 1000;
        }

        /// <summary>
        /// Làm tròn x số thập phân
        /// </summary>
        /// <param name="d"></param>
        /// <param name="x">số lượng phần thập phân</param>
        /// <returns></returns>
        public static double RoundxDecimal(this double d, byte x = 0)
        {
            int y = 1;
            for (byte i = 0; i < x; i++)
            {
                y = y * 10;
            }

            return Math.Round(d * y) / y;
        }

        /// <summary>
        /// Làm tròn 3 số nguyên. 850.560 =>851.000
        /// </summary>
        /// <param name="d"></param>
        /// <returns></returns>
        public static int Round3Interger(this double d)
        {
            return (int)(Math.Round(d / 1000) * 1000);
        }

        /// <summary>
        /// Làm tròn 3 số nguyên. 850.560 =>851.000
        /// </summary>
        /// <param name="d"></param>
        /// <returns></returns>
        public static int Round3Interger(this int d)
        {
            return ((double)d).Round3Interger();
        }

        /// <summary>
        /// Đổi kiểu double sang phần trăm. VD: 0,8333 => 80,33%. numDecimal=[1,3]
        /// </summary>
        /// <param name="d"></param>
        /// <param name="numDecimal">số thập phân</param>
        /// <returns></returns>
        public static string ToPercentString(this double d, byte numDecimal)
        {
            string result = string.Empty;
            d = d * 100;//do đổi ra %
            if (numDecimal == 1)
            {
                result = $"{(Math.Round(d * 10) / 10)}%";
            }
            else if (numDecimal == 2)
            {
                result = $"{(Math.Round(d * 100) / 100)}%";
            }
            else if (numDecimal == 3)
            {
                result = $"{(Math.Round(d * 1000) / 1000)}%";
            }
            return result;
        }
    }
}