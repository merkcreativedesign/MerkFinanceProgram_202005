//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MerkDataBaseBusinessLogicProject
{
    using System;
    using System.Collections.Generic;
    
    public partial class UserGroup_cu
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public UserGroup_cu()
        {
            this.RoleRegistration_cu = new HashSet<RoleRegistration_cu>();
            this.User_UserGroup_cu = new HashSet<User_UserGroup_cu>();
            this.UserGroup_Application_cu = new HashSet<UserGroup_Application_cu>();
        }
    
        public int ID { get; set; }
        public string Name_P { get; set; }
        public string Name_S { get; set; }
        public string InternalCode { get; set; }
        public bool IsOnDuty { get; set; }
        public string Description { get; set; }
        public Nullable<int> InsertedBy { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RoleRegistration_cu> RoleRegistration_cu { get; set; }
        public virtual User_cu User_cu { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<User_UserGroup_cu> User_UserGroup_cu { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserGroup_Application_cu> UserGroup_Application_cu { get; set; }
    }
}