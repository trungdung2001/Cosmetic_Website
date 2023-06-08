﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Comestic_Web.Models
{
    [Table("LoaiSP")]
    public class LoaiSP
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LoaiSP()
        {
            SanPham = new HashSet<SanPham>();
        }

        [Key]
        [StringLength(5)]
        public string maLoai { get; set; }

        [Required]
        [StringLength(50)]
        public string tenLoai { get; set; }

        [StringLength(50)]
        public string ghiChu { get; set; }

        [Column(TypeName = "text")]
        [Required]
        public string Anh { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SanPham> SanPham { get; set; }
    }
}
