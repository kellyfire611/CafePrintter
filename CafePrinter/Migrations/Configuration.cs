﻿using MySql.Data.Entity;
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
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
            //ContextKey = "CafePrintter.Model.CoreModel";

            //// register mysql code generator
            //SetSqlGenerator("MySql.Data.MySqlClient", new MySql.Data.Entity.MySqlMigrationSqlGenerator());
            //CodeGenerator = new MySql.Data.Entity.MySqlMigrationCodeGenerator();


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

            #region "Create Users"
            context.sys_user.AddOrUpdate(
                p => p.username,
                new Model.sys_user() { username = "system", password = "123456" }
                );
            #endregion

            #region "Create Control types"
            context.control_type.AddOrUpdate(
                p => p.code,
                new Model.control_type() { code = "text", name = "Text"},
                new Model.control_type() { code = "textarea", name = "Text area" },
                new Model.control_type() { code = "checkbox", name = "Check box" },
                new Model.control_type() { code = "radio", name = "Radio button" },
                new Model.control_type() { code = "select", name = "Select" },
                new Model.control_type() { code = "truefalse", name = "True/False" },
                new Model.control_type() { code = "email", name = "Email" },
                new Model.control_type() { code = "url", name = "URL" },
                new Model.control_type() { code = "date", name = "Date" },
                new Model.control_type() { code = "time", name = "Time" },
                new Model.control_type() { code = "datetime", name = "Datetime" },
                new Model.control_type() { code = "number", name = "Number" },
                new Model.control_type() { code = "phone", name = "Phone" },
                new Model.control_type() { code = "colorpicker", name = "Color picker" }
                );
            #endregion

            #region "Create Controls"
            context.control.AddOrUpdate(
                p => p.code,
                new Model.control() { code = "textEdit", name = "TextEdit" },
                new Model.control() { code = "memoEdit", name = "MemoEdit" },
                new Model.control() { code = "richEditControl", name = "RichEditControl" }
                );
            #endregion
        }
    }
}
