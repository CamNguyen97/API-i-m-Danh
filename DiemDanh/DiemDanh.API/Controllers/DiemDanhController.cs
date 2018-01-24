using DiemDanh.Entity;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DiemDanh.API.Controllers
{
    public class DiemDanhController : ApiController
    {
        private DiemDanhEntities db = new DiemDanhEntities();
        [HttpPost]
        [Route("GetAll/{MaLop}/{MaMH}")]
        public JToken GetAll(string MaLop, int? MaMH)
        {
            if (string.IsNullOrEmpty(MaLop)&& MaMH<=0)
            {
                return null;
            }
            else 
            {
                var list = from SV in db.SinhViens
                           join Lop in db.Lops.Where(x => x.MaLop.Contains(MaLop)) on SV.MaLop equals Lop.MaLop
                           join MH in db.MonHocs
    on Lop.MaKhoaHoc equals MH.MaMon
                           where (Lop.NamHoc == DateTime.Now.Year && MH.MaMon == MaMH)
                           select new { MaSV = SV.MaSV, TenSV = SV.HoTen, MaMH = MH.MaMon, TenMH = MH.TenMon };
                return JToken.FromObject(list);
            }
          
        }
    }
}
