namespace SIMNews.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.教师",
                c => new
                    {
                        工号 = c.String(nullable: false, maxLength: 8),
                        姓名 = c.String(nullable: false),
                        性别 = c.String(),
                        出生日期 = c.DateTime(),
                        所在系部 = c.String(nullable: false),
                        职称 = c.String(),
                        个人简介 = c.String(),
                        职务 = c.String(),
                        邮箱 = c.String(),
                        办公电话 = c.String(),
                        家庭电话 = c.String(),
                        手机 = c.String(),
                        角色 = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.工号);
            
            CreateTable(
                "dbo.职称表",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        职称 = c.String(),
                        级别 = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.职称表");
            DropTable("dbo.教师");
        }
    }
}
