//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FF_Bewerbe
{
    using System;
    using System.Collections.Generic;
    
    public partial class tMannschaft
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tMannschaft()
        {
            this.tTeilnehmer = new HashSet<tTeilnehmer>();
            this.ZOT_Bewerb_Mannschaft = new HashSet<tTeilnehmendeMannschaft>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tTeilnehmer> tTeilnehmer { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tTeilnehmendeMannschaft> ZOT_Bewerb_Mannschaft { get; set; }
    }
}