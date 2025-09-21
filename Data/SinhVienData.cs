using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Data
{
    [Table("sinhvien")]
    public class SinhVienData
    {
        [Column("nam_hoc")]
        public string nam_hoc { get; set; }

        [Column("chuyen_nganh")]
        public string chuyen_nganh { get; set; }

        [Column("ten")]
        public string ten { get; set; }

        [Column("que_quan")]
        public string que_quan { get; set; }

        [Column("ngay_sinh")]
        public string ngay_sinh { get; set; }

        [Key]
        [Column("oid")]
        public string oid { get; set; }
    }
}
