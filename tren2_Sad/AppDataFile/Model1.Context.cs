﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace tren2_Sad.AppDataFile
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DataBase2Entities3 : DbContext
    {
        private static DataBase2Entities3 _context;

        public DataBase2Entities3()
            : base("name=DataBase2Entities3")
        {
        }

        public static DataBase2Entities3 GetContext()
        {
            if (_context == null)
                _context = new DataBase2Entities3();
            return _context;
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Agent> Agent { get; set; }
        public virtual DbSet<Employee> Employee { get; set; }
        public virtual DbSet<HistoryProvider> HistoryProvider { get; set; }
        public virtual DbSet<HistoryRemainder> HistoryRemainder { get; set; }
        public virtual DbSet<Materials> Materials { get; set; }
        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<ProductDiscount> ProductDiscount { get; set; }
        public virtual DbSet<Production> Production { get; set; }
        public virtual DbSet<ProductSale> ProductSale { get; set; }
        public virtual DbSet<Provider> Provider { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<TypeAgent> TypeAgent { get; set; }
        public virtual DbSet<TypeProduct> TypeProduct { get; set; }
    }
}