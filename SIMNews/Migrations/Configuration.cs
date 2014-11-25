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
            context.ְ�Ʊ�.AddOrUpdate(p => p.Id,
                new ְ�Ʊ� { ְ�� = "����", ���� = "�߼�" },
                new ְ�Ʊ� { ְ�� = "������", ���� = "���߼�" },
                new ְ�Ʊ� { ְ�� = "��ʦ", ���� = "�м�" },
                new ְ�Ʊ� { ְ�� = "����", ���� = "����" }
            );

            context.��ʦ.AddOrUpdate(p => p.����,
                new ��ʦ { ���� = "19930953", ���� = "������", �Ա� = "��", �������� = new DateTime(1971,10,03), ����ϵ�� = "", ְ�� = "", ְ�� = "", ���˼�� = "", ���� = "", �칫�绰 = "", ��ͥ�绰 = "", �ֻ� = "", ��ɫ = "" }
            );
        }
    }
}
