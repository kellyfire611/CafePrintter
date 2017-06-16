using MySql.Data.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;

namespace CafePrintter.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<CafePrintter.Model.CoreModel>
    {
        public Configuration()
        {
            //AutomaticMigrationsEnabled = true;
            //AutomaticMigrationDataLossAllowed = true;
            //ContextKey = "CafePrintter.Model.CoreModel";

            //// register mysql code generator
            //SetSqlGenerator("MySql.Data.MySqlClient", new MySql.Data.Entity.MySqlMigrationSqlGenerator());
            //CodeGenerator = new MySql.Data.Entity.MySqlMigrationCodeGenerator();


            AutomaticMigrationsEnabled = false;
            SetSqlGenerator("MySql.Data.MySqlClient", new MySqlMigrationSqlGenerator());
            SetHistoryContextFactory("MySql.Data.MySqlClient", (conn, schema) => new MySqlHistoryContext(conn, schema));
            CodeGenerator = new MySqlMigrationCodeGenerator();
        }

        protected override void Seed(CafePrintter.Model.CoreModel context)
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

            //context.user.AddOrUpdate(
            //    p => p.id,
            //    new Model.user() { username = "system", password = "123456" }
            //    );




        }
    }
}
