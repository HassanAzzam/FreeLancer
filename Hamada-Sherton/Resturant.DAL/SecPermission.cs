
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
    
public partial class SecPermission
{

    public int ModuleNo { get; set; }

    public string UserName { get; set; }

    public decimal FormNo { get; set; }

    public Nullable<decimal> UpdatSw { get; set; }

    public Nullable<decimal> InsertSw { get; set; }

    public Nullable<decimal> DeleteSw { get; set; }



    public virtual SecForm SecForm { get; set; }

    public virtual SecUser SecUser { get; set; }

}

}
