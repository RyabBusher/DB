//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Daily_Bugle
{
    using System;
    using System.Collections.Generic;
    
    public partial class GazSet
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public GazSet()
        {
            this.AdsSet = new HashSet<AdsSet>();
        }
    
        public int ID { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Price { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AdsSet> AdsSet { get; set; }
    }
}