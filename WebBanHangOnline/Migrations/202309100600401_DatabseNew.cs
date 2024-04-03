namespace WebBanHangOnline.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DatabseNew : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.tb_Order", "Status");
        }
        
        public override void Down()
        {
            AddColumn("dbo.tb_Order", "Status", c => c.Int(nullable: false));
        }
    }
}
