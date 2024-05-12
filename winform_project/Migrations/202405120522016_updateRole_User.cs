namespace winform_project.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateRole_User : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.NguoiDung", "HoTen", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.NguoiDung", "HoTen");
        }
    }
}
