
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
    
public partial class SecForm
{

    public SecForm()
    {

        this.SecPermissions = new HashSet<SecPermission>();

    }


    public int ModuleNo { get; set; }

    public decimal FormNo { get; set; }

    public string FormNameA { get; set; }

    public string FormNameE { get; set; }

    public string FormUrl { get; set; }

    public Nullable<decimal> MenuNo { get; set; }

    public Nullable<int> rank { get; set; }



    public virtual SecSystem SecSystem { get; set; }

    public virtual ICollection<SecPermission> SecPermissions { get; set; }

}

}
