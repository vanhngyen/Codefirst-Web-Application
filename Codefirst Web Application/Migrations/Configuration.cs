﻿namespace Codefirst_Web_Application.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Codefirst_Web_Application.DAL.FptAptechEduContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "Codefirst_Web_Application.DAL.FptAptechEduContext";
        }

        protected override void Seed(Codefirst_Web_Application.DAL.FptAptechEduContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
