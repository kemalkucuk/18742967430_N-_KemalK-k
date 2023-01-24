using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;

namespace SportsStore.Models {

    public static class SeedData {

        public static void EnsurePopulated(IApplicationBuilder app) {
            StoreDbContext context = app.ApplicationServices
                .CreateScope().ServiceProvider.GetRequiredService<StoreDbContext>();

            if (context.Database.GetPendingMigrations().Any()) {
                context.Database.Migrate();
            }

            if (!context.Products.Any()) {
                context.Products.AddRange(
                    new Product {
                        Name = "Kayak", Description = "A boat for one person",
                        Category = "Watersports", Image = "https://www.havadis07.com/wp-content/uploads/2019/11/haber.png"
                    },
                    new Product {
                        Name = "Lifejacket",
                        Description = "Protective and fashionable",
                        Category = "Watersports", Image = "https://www.havadis07.com/wp-content/uploads/2019/11/haber.png"
                    },
                    new Product {
                        Name = "Soccer Ball",
                        Description = "FIFA-approved size and weight",
                        Category = "Soccer", Image = "https://www.havadis07.com/wp-content/uploads/2019/11/haber.png"
                    },
                    new Product {
                        Name = "Corner Flags",
                        Description = "Give your playing field a professional touch",
                        Category = "Soccer", Image = "https://www.havadis07.com/wp-content/uploads/2019/11/haber.png"
                    },
                    new Product {
                        Name = "Stadium",
                        Description = "Flat-packed 35,000-seat stadium",
                        Category = "Soccer", Image = "https://www.havadis07.com/wp-content/uploads/2019/11/haber.png"
                    },
                    new Product {
                        Name = "Thinking Cap",
                        Description = "Improve brain efficiency by 75%",
                        Category = "Chess", Image = "https://www.havadis07.com/wp-content/uploads/2019/11/haber.png"
                    },
                    new Product {
                        Name = "Unsteady Chair",
                        Description = "Secretly give your opponent a disadvantage",
                        Category = "Chess", Image = "https://www.havadis07.com/wp-content/uploads/2019/11/haber.png"
                    },
                    new Product {
                        Name = "Human Chess Board",
                        Description = "A fun game for the family",
                        Category = "Chess", Image = "https://www.havadis07.com/wp-content/uploads/2019/11/haber.png"
                    },
                    new Product {
                        Name = "Bling-Bling King",
                        Description = "Gold-plated, diamond-studded King",
                        Category = "Chess", Image = "https://www.havadis07.com/wp-content/uploads/2019/11/haber.png"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
