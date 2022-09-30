using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    [Serializable]
    public class DBMahasiswa
    {
        public string SiswaID { get; set; }
        public string Nama { get; set; }
        public string Gender { get; set; }
        public string DoB { get; set; }
        public string Agama { get; set; }
        public string Email { get; set; }
        public string Alamat { get; set; }
        public float BI1 { get; set; }
        public float BI2 { get; set; }
        public float Ing1 { get; set; }
        public float Ing2 { get; set; }
        public float Mat1 { get; set; }
        public float Mat2 { get; set; }
        public float IPA1 { get; set; }
        public float IPA2 { get; set; }
    }

}
