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
    
    public partial class LoggingHistory
    {
        public int ID { get; set; }
        public int User_UC_ID { get; set; }
        public System.DateTime LoginDate { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public Nullable<int> OragnizationID { get; set; }
        public string OragnizationName { get; set; }
        public Nullable<int> PrivateOragnizationID { get; set; }
        public string SkinColorName { get; set; }
        public string ColorName { get; set; }
    
        public virtual User_cu User_cu { get; set; }
    }
}
