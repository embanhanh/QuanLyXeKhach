//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QuanLyXeKhach.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class XEKHACH
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public XEKHACH()
        {
            this.LICHTRINHs = new HashSet<LICHTRINH>();
            this.SUCOes = new HashSet<SUCO>();
        }
    
        public string BienSoXe { get; set; }
        public string CCCDTX { get; set; }
        public string CCCDNV { get; set; }
        public string LoaiXe { get; set; }
        public string TinhTrang { get; set; }
        public Nullable<byte> SoGhe { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LICHTRINH> LICHTRINHs { get; set; }
        public virtual NHANVIEN NHANVIEN { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SUCO> SUCOes { get; set; }
        public virtual TAIXE TAIXE { get; set; }
    }
}
