﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ResturantEntities : DbContext
    {
        public ResturantEntities()
            : base("name=ResturantEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<ResAreaCode> ResAreaCodes { get; set; }
        public DbSet<ResCookStatusCode> ResCookStatusCodes { get; set; }
        public DbSet<ResCustomer> ResCustomers { get; set; }
        public DbSet<ResCustomerType> ResCustomerTypes { get; set; }
        public DbSet<ResDeliveryStatu> ResDeliveryStatus { get; set; }
        public DbSet<ResEmployeeBasic> ResEmployeeBasics { get; set; }
        public DbSet<ResGovCode> ResGovCodes { get; set; }
        public DbSet<ResInstructionCode> ResInstructionCodes { get; set; }
        public DbSet<ResItemCode> ResItemCodes { get; set; }
        public DbSet<ResItemType> ResItemTypes { get; set; }
        public DbSet<ResJOBCode> ResJOBCodes { get; set; }
        public DbSet<ResMainCategoryCode> ResMainCategoryCodes { get; set; }
        public DbSet<ResMenuSalesCode> ResMenuSalesCodes { get; set; }
        public DbSet<ResOrderDtl> ResOrderDtls { get; set; }
        public DbSet<ResOrderHd> ResOrderHds { get; set; }
        public DbSet<ResOrderStatu> ResOrderStatus { get; set; }
        public DbSet<ResOrderType> ResOrderTypes { get; set; }
        public DbSet<ResPayment> ResPayments { get; set; }
        public DbSet<ResProperty2Codes> ResProperty2Codes { get; set; }
        public DbSet<ResPropertyCode> ResPropertyCodes { get; set; }
        public DbSet<ResShiftsCode> ResShiftsCodes { get; set; }
        public DbSet<ResStoresCode> ResStoresCodes { get; set; }
        public DbSet<ResSusCategoryCode> ResSusCategoryCodes { get; set; }
        public DbSet<ResTablesCode> ResTablesCodes { get; set; }
        public DbSet<ResTablesStatusCode> ResTablesStatusCodes { get; set; }
        public DbSet<ResTransType> ResTransTypes { get; set; }
        public DbSet<SecForm> SecForms { get; set; }
        public DbSet<SecMenue> SecMenues { get; set; }
        public DbSet<SecPermission> SecPermissions { get; set; }
        public DbSet<SecSystem> SecSystems { get; set; }
        public DbSet<SecUser> SecUsers { get; set; }
    }
}
