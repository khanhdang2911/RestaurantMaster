namespace winform_project.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateRole_Userp2 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.NguoiDung", "Address");
        }
        
        public override void Down()
        {
            AddColumn("dbo.NguoiDung", "Address", c => c.String());
        }
    }
}
