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
    
    public partial class GHE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public GHE()
        {
            this.HANHKHACHes = new HashSet<HANHKHACH>();
        }
    
        public string IDGhe { get; set; }
        public string BienSoXe { get; set; }
        public Nullable<bool> TINHTRANG { get; set; }
    
        public virtual XEKHACH XEKHACH { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HANHKHACH> HANHKHACHes { get; set; }
    }
}
