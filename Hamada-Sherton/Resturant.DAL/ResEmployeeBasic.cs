
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
    
public partial class ResEmployeeBasic
{

    public ResEmployeeBasic()
    {

        this.ResOrderHds = new HashSet<ResOrderHd>();

    }


    public decimal EmpId { get; set; }

    public string EmpName { get; set; }

    public Nullable<decimal> JobId { get; set; }

    public Nullable<decimal> WorkStatus { get; set; }

    public string Tel1 { get; set; }

    public string Tel2 { get; set; }

    public Nullable<System.DateTime> InsertDt { get; set; }

    public string UserName { get; set; }



    public virtual ResJOBCode ResJOBCode { get; set; }

    public virtual ICollection<ResOrderHd> ResOrderHds { get; set; }

}

}
