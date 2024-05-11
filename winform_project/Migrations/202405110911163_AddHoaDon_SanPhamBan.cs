namespace winform_project.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddHoaDon_SanPhamBan : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.SanPhamBans",
                c => new
                    {
                        BanId = c.Int(nullable: false),
                        SanPhamId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.BanId, t.SanPhamId })
                .ForeignKey("dbo.Ban", t => t.BanId, cascadeDelete: true)
                .ForeignKey("dbo.SanPham", t => t.SanPhamId, cascadeDelete: true)
                .Index(t => t.BanId)
                .Index(t => t.SanPhamId);
            
            CreateTable(
                "dbo.HoaDons",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NgayBan = c.DateTime(nullable: false),
                        BanId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Ban", t => t.BanId, cascadeDelete: true)
                .Index(t => t.BanId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.HoaDons", "BanId", "dbo.Ban");
            DropForeignKey("dbo.SanPhamBans", "SanPhamId", "dbo.SanPham");
            DropForeignKey("dbo.SanPhamBans", "BanId", "dbo.Ban");
            DropIndex("dbo.HoaDons", new[] { "BanId" });
            DropIndex("dbo.SanPhamBans", new[] { "SanPhamId" });
            DropIndex("dbo.SanPhamBans", new[] { "BanId" });
            DropTable("dbo.HoaDons");
            DropTable("dbo.SanPhamBans");
        }
    }
}
