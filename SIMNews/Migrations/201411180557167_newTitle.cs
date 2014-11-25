namespace SIMNews.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class newTitle : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.职称表", "级别代码1", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.职称表", "级别代码1");
        }
    }
}
