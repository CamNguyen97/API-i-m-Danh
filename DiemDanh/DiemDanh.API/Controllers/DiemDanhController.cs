using DiemDanh.Entity;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace DiemDanh.API.Controllers
{
    public class DiemDanhController : ApiController
    {
        private DiemDanhEntities db = new DiemDanhEntities();
       // [HttpPost]
     //   [Route("GetAll/{MaLop}/{MaMH}")]
     [EnableCors("*","*","*")]
        public JToken GetAll()
        {
             int? MaMH=null;
            string MaLop = null;
            //if (string.IsNullOrEmpty(MaLop)&& MaMH<=0)
            //{
            //    return null;
            //}
            //else 
            //{
                var list = from SV in db.SinhViens
                           join Lop in db.Lops.Where(x => x.MaLop.Contains("2")) on SV.MaLop equals Lop.MaLop
                           join MH in db.MonHocs
    on Lop.MaKhoaHoc equals MH.MaMon
                           where (Lop.NamHoc == DateTime.Now.Year)
                           select new { SinhVien = SV,MonHocs = MH };
                return JToken.FromObject(list);
           // }
          
        }
    }
}
