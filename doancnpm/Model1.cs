namespace doancnpm.DB
{
    using codefirt;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class Model1 : DbContext
    {//abc
        // Your context has been configured to use a 'Model2' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'doancnpm.Model2' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'Model2' 
        // connection string in the application configuration file.
      
            public Model1()
            : base("name=Model1")
        {
                Database.SetInitializer<Model1>(new creadDB());
            }
        public virtual DbSet<MatHang> MatHangs { set; get; }
        public virtual DbSet<DonViTinh> DonViTinhs { set; get; }
        public virtual DbSet<Account> Accounts { set; get; }
        public virtual DbSet<USER> USERs { set; get; }
        public virtual DbSet<Group> Groups { set; get; }
        public virtual DbSet<ChiTietHoaDon> ChiTietHoaDons { set; get; }
        public virtual DbSet<HoaDonBanHang> HoaDonBanHangs { set; get; }
    }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
