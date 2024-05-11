namespace winform_project.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddHoaDon_SanPhamBanphan2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.HoaDons", "BanId", "dbo.Ban");
            DropIndex("dbo.HoaDons", new[] { "BanId" });
            AddColumn("dbo.HoaDons", "TenBan", c => c.String());
            DropColumn("dbo.HoaDons", "BanId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.HoaDons", "BanId", c => c.Int(nullable: false));
            DropColumn("dbo.HoaDons", "TenBan");
            CreateIndex("dbo.HoaDons", "BanId");
            AddForeignKey("dbo.HoaDons", "BanId", "dbo.Ban", "Id", cascadeDelete: true);
        }
    }
}
