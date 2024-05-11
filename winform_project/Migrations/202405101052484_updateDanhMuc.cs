namespace winform_project.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateDanhMuc : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.DanhMuc", "TenDanhMuc", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.DanhMuc", "TenDanhMuc");
        }
    }
}
