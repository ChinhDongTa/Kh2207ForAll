using TypeOperator;

namespace ThongKeCCCD.Data
{
    public class ThongKe2207Dto
    {
        public string DonVi { get; set; } = string.Empty;
        public int TongNtg { get; set; }
        public int TongDangNhapVssid { get; set; }
        public int TongDangKyVssid { get; set; }
        public int TongXacThuc { get; set; }
        public int TongCccd { get; set; }

        public string TyLeDangNhapVssid => ((double)TongDangNhapVssid / TongNtg).ToPercentString(2);
        public string TyLeDangKyVssid => ((double)TongDangKyVssid / TongNtg).ToPercentString(2);
        public string TyleXacThuc => ((double)TongXacThuc / TongNtg).ToPercentString(2);
        public string TyLeCccd => ((double)TongCccd / TongNtg).ToPercentString(2);
    }
}