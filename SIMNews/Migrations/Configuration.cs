namespace SIMNews.Migrations
{
    using SIMNews.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<SIMNews.Models.SIMNewsContext>
    {
        public Configuration()
        {
            AutomaticMigrationDataLossAllowed = true;
            AutomaticMigrationsEnabled = true;
            ContextKey = "SIMNews.Models.SIMNewsContext";
        }

        protected override void Seed(SIMNews.Models.SIMNewsContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
            context.职称表.AddOrUpdate(p => p.Id,
                new 职称表 { 职称 = "教授", 级别 = "高级" },
                new 职称表 { 职称 = "副教授", 级别 = "副高级" },
                new 职称表 { 职称 = "讲师", 级别 = "中级" },
                new 职称表 { 职称 = "助教", 级别 = "初级" }
            );

            context.教师.AddOrUpdate(p => p.工号,
                new 教师 { 工号 = "19930953", 姓名 = "宋燕林", 性别 = "男", 出生日期 = new DateTime(1971,10,03), 所在系部 = "", 职称 = "", 职务 = "", 个人简介 = "", 邮箱 = "", 办公电话 = "", 家庭电话 = "", 手机 = "", 角色 = "" }
            );
        }
    }
}
