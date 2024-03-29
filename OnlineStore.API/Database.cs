﻿using Microsoft.EntityFrameworkCore;
using OnlineStore.Core;

namespace OnlineStore.API
{
    internal class Database
    {
        public static void Migrate(WebApplication app)
        {
            using (var container = app.Services.CreateScope())
            {
                var dbContext = container.ServiceProvider.GetService<AppDbContext>();
                var pendingMigration = dbContext!.Database.GetPendingMigrations();
                if (pendingMigration.Any())
                {
                    dbContext.Database.Migrate();
                }
            }
        }
    }
}
