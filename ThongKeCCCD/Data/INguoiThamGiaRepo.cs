using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace ThongKeCCCD.Data
{
    public interface INguoiThamGiaRepo
    {
        Task<IEnumerable<NguoiThamGia>> GetAll();

        Task<IEnumerable<NguoiThamGia>?> Find(Expression<Func<NguoiThamGia, bool>> predicate);

        Task<NguoiThamGia> FindById(int id);

        Task<IEnumerable<ThongKe2207Dto>?> GetThongKe2207DtosAsync();

        Task<IEnumerable<CoQuanBhxh>> GetCoQuanBhxhs();
    }

    public class NguoiThamGiaRepo : INguoiThamGiaRepo
    {
        private readonly NguoiThamGiaXacThucBcaContext db;

        public NguoiThamGiaRepo(NguoiThamGiaXacThucBcaContext _db)
        {
            db = _db;
        }

        public async Task<IEnumerable<NguoiThamGia>?> Find(Expression<Func<NguoiThamGia, bool>> predicate)
        {
            return await db.NguoiThamGia.Where(predicate).ToListAsync();
        }

        public async Task<NguoiThamGia> FindById(int id)
        {
            return await db.NguoiThamGia.SingleAsync(x => x.Id == id);
        }

        public async Task<IEnumerable<NguoiThamGia>> GetAll()
        {
            return await db.NguoiThamGia.ToListAsync();
        }

        public async Task<IEnumerable<CoQuanBhxh>> GetCoQuanBhxhs()
        {
            return await db.CoQuanBhxh.ToListAsync();
        }
        /// <summary>
        /// Thống kế kh2207 toàn tỉnh
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<ThongKe2207Dto>?> GetThongKe2207DtosAsync()
        {
            var list = new List<ThongKe2207Dto>();

            foreach (var item in await db.CoQuanBhxh.ToListAsync())
            {
                IQueryable<NguoiThamGia> dsThamGia;

                if (item.MaHuyen == "01")
                    dsThamGia =  db.NguoiThamGia.Where(x => string.IsNullOrEmpty(x.MaHuyen) || x.MaHuyen == "01");
                else
                    dsThamGia =  db.NguoiThamGia.Where(x => x.MaHuyen == item.MaHuyen);
                if (dsThamGia != null)
                {
                    var thongKe = new ThongKe2207Dto
                    {
                        DonVi = item.Ten,
                        TongNtg = dsThamGia.Count(),
                        TongCccd = dsThamGia.Count(x => !string.IsNullOrEmpty(x.SoDdcnCccdBca)),
                        TongDangKyVssid = dsThamGia.Count(x => x.DaDangKyVssid == "X"),
                        TongDangNhapVssid = dsThamGia.Count(x => x.DangNhapVssid == "X"),
                        TongXacThuc = dsThamGia.Count(x => x.TrangThaiXacThuc == "X")
                    };
                    list.Add(thongKe);
                }
            }
            return list;
        }
    }
}