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
    
    public partial class JobTitle_cu
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public JobTitle_cu()
        {
            this.Department_JobTitle_cu = new HashSet<Department_JobTitle_cu>();
            this.Department_JobTitle_WorkingShiftTitle_cu = new HashSet<Department_JobTitle_WorkingShiftTitle_cu>();
            this.Employee_Department_JobTitle_cu = new HashSet<Employee_Department_JobTitle_cu>();
        }
    
        public int ID { get; set; }
        public string Name_EN { get; set; }
        public string Name_AR { get; set; }
        public string Description { get; set; }
        public Nullable<int> nvarchar_150_ { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Department_JobTitle_cu> Department_JobTitle_cu { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Department_JobTitle_WorkingShiftTitle_cu> Department_JobTitle_WorkingShiftTitle_cu { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Employee_Department_JobTitle_cu> Employee_Department_JobTitle_cu { get; set; }
        public virtual User_cu User_cu { get; set; }
    }
}
