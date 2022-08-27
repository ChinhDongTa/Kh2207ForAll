using System.Text.RegularExpressions;

namespace TypeOperator
{
    public static class StringExtension
    {
        /// <summary>
        ///  Chuyển 1 chuổi dd-mm-yyyy hoặc mm-yyyy thành yyyymmdd hoặc yyyymm
        /// </summary>
        /// <param name="dateString">dd-mm-yyyy hoắc dd/mm/yyyy</param>
        /// <param name="c">chỉ có giá trị: '-' hặc '/'</param>
        /// <returns></returns>
        public static string? ToYYYYMMDD(this string dateString, char c)
        {
            var dateArray = dateString.Split(c, StringSplitOptions.RemoveEmptyEntries);
            if (dateArray.Length == 3)
                return $"{dateArray[2]}{dateArray[1]}{dateArray[0]}";
            else if (dateArray.Length == 2)
                return $"{dateArray[1]}{dateArray[0]}";
            return null;
        }

        /// <summary>
        ///  Chuyển 1 chuổi dd-mm-yyyy hoặc dd/mm/yyyy thành yyyymmdd
        /// </summary>
        /// <param name="dateString">Chuổi ngày tháng năm</param>
        /// <returns></returns>
        public static string ToYYYYMMDD(this string dateString)
        {
            if (dateString.Contains('-'))
                return ToYYYYMMDD(dateString, '-') ?? dateString;
            else if (dateString.Contains('/'))
                return ToYYYYMMDD(dateString, '/') ?? dateString;
            return dateString;
        }

        /// <summary>
        /// Trả về chuổi Date định dạng kiểu Việt Nam
        /// </summary>
        /// <param name="dateString">Chuổi yyyymmdd hoặc yyyymm hoặc yyyy</param>
        /// <returns></returns>
        public static string? YYYYMMDD2VnDate(this string dateString)
        {
            return dateString.Length switch
            {
                4 => dateString,
                6 => $"__-{dateString.Substring(4, 2)}-{dateString[..4]}",
                8 => $"{dateString.Substring(6, 2)}-{dateString.Substring(4, 2)}-{dateString[..4]}",
                _ => string.Empty
            };
        }

        /// <summary>
        /// Chuyển 1 chuổi "skip=5 take=10"
        /// </summary>
        /// <param name="skipTakeString"></param>
        /// <returns></returns>
        public static int[]? ParseSkipTake(this string skipTakeString)
        {
            skipTakeString = skipTakeString.RemoveAllSpace();
            if (skipTakeString.MatchAllValueIgnoreCase(new string[] { "skip", "take", "," }))
            {
                var item = skipTakeString.Split(',');
                if (item.Length > 2)
                    return null;
                var skipString = item[0].Split('=');
                var takeString = item[1].Split('=');
                return int.TryParse(skipString[1], out int skip) == true && int.TryParse(takeString[1], out int take) == true
                    ? (new[] { skip, take })
                    : null;
            }
            return null;
        }

        /// <summary>
        /// Xóa tất cả khoảng trắng
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static string RemoveAllSpace(this string s)
        {
            return Regex.Replace(s, @"\s+", "");
        }

        /// <summary>
        /// kiểm tra chuổi input có chưa tất cả giá trị của array match
        /// </summary>
        /// <param name="input"></param>
        /// <param name="match"></param>
        /// <returns></returns>
        public static bool MatchAllValueIgnoreCase(this string input, string[] match)
        {
            if (match.Length > 0)
            {
                for (int i = 0; i < match.Length; i++)
                {
                    if (!input.Contains(match[i], StringComparison.OrdinalIgnoreCase))
                        return false;
                }
            }
            else return false;
            return true;
        }
    }
}