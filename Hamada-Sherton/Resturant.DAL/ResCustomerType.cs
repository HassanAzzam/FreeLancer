
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
    
public partial class ResCustomerType
{

    public ResCustomerType()
    {

        this.ResCustomers = new HashSet<ResCustomer>();

    }


    public decimal CustType { get; set; }

    public string CustTypeNameA { get; set; }

    public string CustTypeNameE { get; set; }



    public virtual ICollection<ResCustomer> ResCustomers { get; set; }

}

}
