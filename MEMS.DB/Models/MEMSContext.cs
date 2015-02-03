using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using MEMS.DB.Models.Mapping;

namespace MEMS.DB.Models
{
    public partial class MEMSContext : DbContext
    {
        static MEMSContext()
        {
            Database.SetInitializer<MEMSContext>(null);
        }

        public MEMSContext()
            : base("Name=MEMSContext")
        {
        }

        public DbSet<T_ApplyMaterial> T_ApplyMaterial { get; set; }
        public DbSet<T_ApplyOrder> T_ApplyOrder { get; set; }
        public DbSet<T_Base_companytype> T_Base_companytype { get; set; }
        public DbSet<T_Base_customertype> T_Base_customertype { get; set; }
        public DbSet<T_Base_profession> T_Base_profession { get; set; }
        public DbSet<T_Base_suppliertype> T_Base_suppliertype { get; set; }
        public DbSet<T_CodeType> T_CodeType { get; set; }
        public DbSet<T_Crafts> T_Crafts { get; set; }
        public DbSet<T_CraftsPrice> T_CraftsPrice { get; set; }
        public DbSet<T_Customer> T_Customer { get; set; }
        public DbSet<T_Customer_address> T_Customer_address { get; set; }
        public DbSet<T_Customer_contacts> T_Customer_contacts { get; set; }
        public DbSet<T_FileMgr> T_FileMgr { get; set; }
        public DbSet<T_Invoice> T_Invoice { get; set; }
        public DbSet<T_MaterialMode> T_MaterialMode { get; set; }
        public DbSet<T_MaterialType> T_MaterialType { get; set; }
        public DbSet<T_Product> T_Product { get; set; }
        public DbSet<T_ProductbasicPrice> T_ProductbasicPrice { get; set; }
        public DbSet<T_ProductDraw> T_ProductDraw { get; set; }
        public DbSet<T_ProductType> T_ProductType { get; set; }
        public DbSet<T_PurchaseMaterial> T_PurchaseMaterial { get; set; }
        public DbSet<T_PurchaseOrder> T_PurchaseOrder { get; set; }
        public DbSet<T_quotation> T_quotation { get; set; }
        public DbSet<T_quotationprice> T_quotationprice { get; set; }
        public DbSet<T_saledetail> T_saledetail { get; set; }
        public DbSet<T_saleorder> T_saleorder { get; set; }
        public DbSet<T_SaleReceive> T_SaleReceive { get; set; }
        public DbSet<T_StandardMaterial> T_StandardMaterial { get; set; }
        public DbSet<T_StockCode> T_StockCode { get; set; }
        public DbSet<T_Suppliers> T_Suppliers { get; set; }
        public DbSet<T_Suppliers_contacts> T_Suppliers_contacts { get; set; }
        public DbSet<T_Unit> T_Unit { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new T_ApplyMaterialMap());
            modelBuilder.Configurations.Add(new T_ApplyOrderMap());
            modelBuilder.Configurations.Add(new T_Base_companytypeMap());
            modelBuilder.Configurations.Add(new T_Base_customertypeMap());
            modelBuilder.Configurations.Add(new T_Base_professionMap());
            modelBuilder.Configurations.Add(new T_Base_suppliertypeMap());
            modelBuilder.Configurations.Add(new T_CodeTypeMap());
            modelBuilder.Configurations.Add(new T_CraftsMap());
            modelBuilder.Configurations.Add(new T_CraftsPriceMap());
            modelBuilder.Configurations.Add(new T_CustomerMap());
            modelBuilder.Configurations.Add(new T_Customer_addressMap());
            modelBuilder.Configurations.Add(new T_Customer_contactsMap());
            modelBuilder.Configurations.Add(new T_FileMgrMap());
            modelBuilder.Configurations.Add(new T_InvoiceMap());
            modelBuilder.Configurations.Add(new T_MaterialModeMap());
            modelBuilder.Configurations.Add(new T_MaterialTypeMap());
            modelBuilder.Configurations.Add(new T_ProductMap());
            modelBuilder.Configurations.Add(new T_ProductbasicPriceMap());
            modelBuilder.Configurations.Add(new T_ProductDrawMap());
            modelBuilder.Configurations.Add(new T_ProductTypeMap());
            modelBuilder.Configurations.Add(new T_PurchaseMaterialMap());
            modelBuilder.Configurations.Add(new T_PurchaseOrderMap());
            modelBuilder.Configurations.Add(new T_quotationMap());
            modelBuilder.Configurations.Add(new T_quotationpriceMap());
            modelBuilder.Configurations.Add(new T_saledetailMap());
            modelBuilder.Configurations.Add(new T_saleorderMap());
            modelBuilder.Configurations.Add(new T_SaleReceiveMap());
            modelBuilder.Configurations.Add(new T_StandardMaterialMap());
            modelBuilder.Configurations.Add(new T_StockCodeMap());
            modelBuilder.Configurations.Add(new T_SuppliersMap());
            modelBuilder.Configurations.Add(new T_Suppliers_contactsMap());
            modelBuilder.Configurations.Add(new T_UnitMap());
        }
    }
}
