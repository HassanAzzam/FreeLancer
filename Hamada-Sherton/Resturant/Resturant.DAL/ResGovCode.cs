//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Resturant.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class ResGovCode
    {
        public ResGovCode()
        {
            this.ResAreaCodes = new HashSet<ResAreaCode>();
            this.ResStoresCodes = new HashSet<ResStoresCode>();
        }
    
        public decimal GovId { get; set; }
        public string GovNameA { get; set; }
        public string GovNameE { get; set; }
        public string UserName { get; set; }
        public Nullable<System.DateTime> InsertDt { get; set; }
    
        public virtual ICollection<ResAreaCode> ResAreaCodes { get; set; }
        public virtual ICollection<ResStoresCode> ResStoresCodes { get; set; }
    }
}