//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL.DbModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class Subscriber
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Subscriber()
        {
            this.SubscriberPermissions = new HashSet<SubscriberPermission>();
        }
    
        public long Id { get; set; }
        public long UserDB_Id { get; set; }
        public bool IsActive { get; set; }
        public System.DateTime InsertTime { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SubscriberPermission> SubscriberPermissions { get; set; }
    }
}
