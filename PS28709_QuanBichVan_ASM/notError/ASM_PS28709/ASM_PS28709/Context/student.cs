//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASM_PS28709.Context
{
    using System;
    using System.Collections.Generic;
    
    public partial class student
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public student()
        {
            this.grades = new HashSet<grade>();
        }
    
        public string MSSV { get; set; }
        public string HoTen { get; set; }
        public string Email { get; set; }
        public string SoDT { get; set; }
        public Nullable<bool> GioiTinh { get; set; }
        public string DiaChi { get; set; }
        public string Hinh { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<grade> grades { get; set; }
    }
}
