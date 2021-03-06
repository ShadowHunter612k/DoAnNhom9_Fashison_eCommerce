﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebAPI
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class DB_A6A231_DAQLTMDTEntities : DbContext
    {
        public DB_A6A231_DAQLTMDTEntities()
            : base("name=DB_A6A231_DAQLTMDTEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Authorize> Authorizes { get; set; }
        public virtual DbSet<Brand> Brands { get; set; }
        public virtual DbSet<Permission> Permissions { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Product_Type> Product_Type { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<Store> Stores { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Address> Addresses { get; set; }
        public virtual DbSet<Main_Type> Main_Type { get; set; }
        public virtual DbSet<Rating> Ratings { get; set; }
        public virtual DbSet<Cart> Carts { get; set; }
        public virtual DbSet<Cart_Item> Cart_Item { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<Order_Items> Order_Items { get; set; }
        public virtual DbSet<Buyer_LoadAllProduct> Buyer_LoadAllProduct { get; set; }
        public virtual DbSet<Buyer_LoadProduct> Buyer_LoadProduct { get; set; }
        public virtual DbSet<view_Buyer_Order_Items> view_Buyer_Order_Items { get; set; }
        public virtual DbSet<view_Buyer_Orders> view_Buyer_Orders { get; set; }
        public virtual DbSet<view_MainType> view_MainType { get; set; }
        public virtual DbSet<Order_All> Order_All { get; set; }
    
        public virtual int sp_AccountChangePassword(string email, string password)
        {
            var emailParameter = email != null ?
                new ObjectParameter("email", email) :
                new ObjectParameter("email", typeof(string));
    
            var passwordParameter = password != null ?
                new ObjectParameter("password", password) :
                new ObjectParameter("password", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_AccountChangePassword", emailParameter, passwordParameter);
        }
    
        public virtual int sp_AccountResgister(string username, string password, string email)
        {
            var usernameParameter = username != null ?
                new ObjectParameter("username", username) :
                new ObjectParameter("username", typeof(string));
    
            var passwordParameter = password != null ?
                new ObjectParameter("password", password) :
                new ObjectParameter("password", typeof(string));
    
            var emailParameter = email != null ?
                new ObjectParameter("email", email) :
                new ObjectParameter("email", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_AccountResgister", usernameParameter, passwordParameter, emailParameter);
        }
    
        public virtual int sp_alterdiagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_alterdiagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_creatediagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_creatediagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_dropdiagram(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_dropdiagram", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagramdefinition_Result> sp_helpdiagramdefinition(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagramdefinition_Result>("sp_helpdiagramdefinition", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagrams_Result> sp_helpdiagrams(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagrams_Result>("sp_helpdiagrams", diagramnameParameter, owner_idParameter);
        }
    
        public virtual int sp_renamediagram(string diagramname, Nullable<int> owner_id, string new_diagramname)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var new_diagramnameParameter = new_diagramname != null ?
                new ObjectParameter("new_diagramname", new_diagramname) :
                new ObjectParameter("new_diagramname", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_renamediagram", diagramnameParameter, owner_idParameter, new_diagramnameParameter);
        }
    
        public virtual int sp_upgraddiagrams()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_upgraddiagrams");
        }
    
        public virtual ObjectResult<Nullable<bool>> Sp_User_Login(string userName, string password)
        {
            var userNameParameter = userName != null ?
                new ObjectParameter("UserName", userName) :
                new ObjectParameter("UserName", typeof(string));
    
            var passwordParameter = password != null ?
                new ObjectParameter("Password", password) :
                new ObjectParameter("Password", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<bool>>("Sp_User_Login", userNameParameter, passwordParameter);
        }
    
        [DbFunction("DB_A6A231_DAQLTMDTEntities", "Load_User_Cart")]
        public virtual IQueryable<Load_User_Cart> Load_User_Cart(Nullable<int> user_id)
        {
            var user_idParameter = user_id.HasValue ?
                new ObjectParameter("user_id", user_id) :
                new ObjectParameter("user_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<Load_User_Cart>("[DB_A6A231_DAQLTMDTEntities].[Load_User_Cart](@user_id)", user_idParameter);
        }
    
        public virtual ObjectResult<get_ProductByID_Result> get_ProductByID(Nullable<int> product_ID)
        {
            var product_IDParameter = product_ID.HasValue ?
                new ObjectParameter("product_ID", product_ID) :
                new ObjectParameter("product_ID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<get_ProductByID_Result>("get_ProductByID", product_IDParameter);
        }
    
        public virtual int ChangeStatus(string id, Nullable<int> status)
        {
            var idParameter = id != null ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(string));
    
            var statusParameter = status.HasValue ?
                new ObjectParameter("status", status) :
                new ObjectParameter("status", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ChangeStatus", idParameter, statusParameter);
        }
    
        public virtual ObjectResult<getOrders_Of_User_Result> getOrders_Of_User(Nullable<int> userid)
        {
            var useridParameter = userid.HasValue ?
                new ObjectParameter("userid", userid) :
                new ObjectParameter("userid", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<getOrders_Of_User_Result>("getOrders_Of_User", useridParameter);
        }
    
        public virtual ObjectResult<sp_loadUserCart_Result> sp_loadUserCart(Nullable<int> user_id)
        {
            var user_idParameter = user_id.HasValue ?
                new ObjectParameter("user_id", user_id) :
                new ObjectParameter("user_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_loadUserCart_Result>("sp_loadUserCart", user_idParameter);
        }
    
        public virtual ObjectResult<sp_getOrderDetail_Result> sp_getOrderDetail(string order_id)
        {
            var order_idParameter = order_id != null ?
                new ObjectParameter("order_id", order_id) :
                new ObjectParameter("order_id", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_getOrderDetail_Result>("sp_getOrderDetail", order_idParameter);
        }
    
        public virtual ObjectResult<sp_getUserAddress_Result> sp_getUserAddress(Nullable<int> user_id)
        {
            var user_idParameter = user_id.HasValue ?
                new ObjectParameter("user_id", user_id) :
                new ObjectParameter("user_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_getUserAddress_Result>("sp_getUserAddress", user_idParameter);
        }
    
        public virtual ObjectResult<sp_ProductByType_Result> sp_ProductByType(Nullable<int> typeid)
        {
            var typeidParameter = typeid.HasValue ?
                new ObjectParameter("typeid", typeid) :
                new ObjectParameter("typeid", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_ProductByType_Result>("sp_ProductByType", typeidParameter);
        }
    
        public virtual ObjectResult<sp_ProductByStore_Result> sp_ProductByStore(Nullable<int> storeid)
        {
            var storeidParameter = storeid.HasValue ?
                new ObjectParameter("storeid", storeid) :
                new ObjectParameter("storeid", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_ProductByStore_Result>("sp_ProductByStore", storeidParameter);
        }
    
        public virtual ObjectResult<sp_searchProduct_Result> sp_searchProduct(string name, Nullable<int> typeid)
        {
            var nameParameter = name != null ?
                new ObjectParameter("name", name) :
                new ObjectParameter("name", typeof(string));
    
            var typeidParameter = typeid.HasValue ?
                new ObjectParameter("typeid", typeid) :
                new ObjectParameter("typeid", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_searchProduct_Result>("sp_searchProduct", nameParameter, typeidParameter);
        }
    
        public virtual ObjectResult<FindProducts_Result> FindProducts(Nullable<int> store_ID, string name, Nullable<int> type, Nullable<int> qualityMin, Nullable<int> qualityMax)
        {
            var store_IDParameter = store_ID.HasValue ?
                new ObjectParameter("Store_ID", store_ID) :
                new ObjectParameter("Store_ID", typeof(int));
    
            var nameParameter = name != null ?
                new ObjectParameter("Name", name) :
                new ObjectParameter("Name", typeof(string));
    
            var typeParameter = type.HasValue ?
                new ObjectParameter("Type", type) :
                new ObjectParameter("Type", typeof(int));
    
            var qualityMinParameter = qualityMin.HasValue ?
                new ObjectParameter("QualityMin", qualityMin) :
                new ObjectParameter("QualityMin", typeof(int));
    
            var qualityMaxParameter = qualityMax.HasValue ?
                new ObjectParameter("QualityMax", qualityMax) :
                new ObjectParameter("QualityMax", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<FindProducts_Result>("FindProducts", store_IDParameter, nameParameter, typeParameter, qualityMinParameter, qualityMaxParameter);
        }
    
        public virtual ObjectResult<getProducts_Result> getProducts(Nullable<int> storeID)
        {
            var storeIDParameter = storeID.HasValue ?
                new ObjectParameter("StoreID", storeID) :
                new ObjectParameter("StoreID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<getProducts_Result>("getProducts", storeIDParameter);
        }
    
        public virtual ObjectResult<sp_getAddressByID_Result> sp_getAddressByID(Nullable<int> addressID)
        {
            var addressIDParameter = addressID.HasValue ?
                new ObjectParameter("addressID", addressID) :
                new ObjectParameter("addressID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_getAddressByID_Result>("sp_getAddressByID", addressIDParameter);
        }
    
        public virtual ObjectResult<sp_View_Orders_Result> sp_View_Orders(Nullable<int> store_id, Nullable<int> status)
        {
            var store_idParameter = store_id.HasValue ?
                new ObjectParameter("store_id", store_id) :
                new ObjectParameter("store_id", typeof(int));
    
            var statusParameter = status.HasValue ?
                new ObjectParameter("status", status) :
                new ObjectParameter("status", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_View_Orders_Result>("sp_View_Orders", store_idParameter, statusParameter);
        }
    }
}
