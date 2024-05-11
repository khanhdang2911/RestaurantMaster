namespace winform_project.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateBan : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Ban", "TinhTrang", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Ban", "TinhTrang");
        }
    }
}
