
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
    
public partial class ResOrderStatu
{

    public ResOrderStatu()
    {

        this.ResOrderHds = new HashSet<ResOrderHd>();

    }


    public decimal OrderStatus { get; set; }

    public string StatusNameA { get; set; }

    public string StatusNameE { get; set; }



    public virtual ICollection<ResOrderHd> ResOrderHds { get; set; }

}

}
