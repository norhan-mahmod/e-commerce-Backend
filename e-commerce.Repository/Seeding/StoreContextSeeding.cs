using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using e_commerce.Core.Entities;
using e_commerce.Repository.DbContexts;

namespace e_commerce.Repository.Seeding
{
    public static class StoreContextSeeding
    {
        public static async Task SeedDataAsync( StoreContext context)
        {
            if(context.Brands.Count() == 0)
            {
                await context.Brands.AddRangeAsync([

                    new Brand {  Name = "Sony", Image = "https://cdn-icons-png.flaticon.com/512/5968/5968515.png" },
                    new Brand {  Name = "H&M", Image = "https://cdn-icons-png.flaticon.com/512/889/889419.png" },
                    new Brand {  Name = "Tefal", Image = "https://cdn-icons-png.flaticon.com/512/1187/1187551.png" },
                    new Brand {  Name = "Penguin Books", Image = "https://cdn-icons-png.flaticon.com/512/188/188991.png" },
                    new Brand {  Name = "The Ordinary", Image = "https://cdn-icons-png.flaticon.com/512/3603/3603695.png" },
                    new Brand {  Name = "LEGO", Image = "https://cdn-icons-png.flaticon.com/512/385/385973.png" },
                    new Brand {  Name = "Nike", Image = "https://cdn-icons-png.flaticon.com/512/731/731985.png" },
                    new Brand {  Name = "Black+Decker", Image = "https://cdn-icons-png.flaticon.com/512/2920/2920364.png" },
                    new Brand {  Name = "Nature’s Bounty", Image = "https://cdn-icons-png.flaticon.com/512/1785/1785360.png" },
                    new Brand {  Name = "Purina", Image = "https://cdn-icons-png.flaticon.com/512/616/616554.png" }

                ]);
            }

            if(context.Categories.Count() == 0)
            {
                await context.Categories.AddRangeAsync([
                    new Category {  Name = "Electronics", Slug = "electronics", Image = "https://cdn-icons-png.flaticon.com/512/1041/1041883.png" },
                    new Category {  Name = "Clothing", Slug = "clothing", Image = "https://cdn-icons-png.flaticon.com/512/892/892458.png" },
                    new Category {  Name = "Home & Kitchen", Slug = "home-kitchen", Image = "https://cdn-icons-png.flaticon.com/512/1534/1534014.png" },
                    new Category {  Name = "Books", Slug = "books", Image = "https://cdn-icons-png.flaticon.com/512/3375/3375459.png" },
                    new Category {  Name = "Beauty & Personal Care", Slug = "beauty-personal-care", Image = "https://cdn-icons-png.flaticon.com/512/2920/2920290.png" },
                    new Category {  Name = "Toys & Games", Slug = "toys-games", Image = "https://cdn-icons-png.flaticon.com/512/190/190411.png" },
                    new Category {  Name = "Sports & Outdoors", Slug = "sports-outdoors", Image = "https://cdn-icons-png.flaticon.com/512/1724/1724261.png" },
                    new Category {  Name = "Automotive", Slug = "automotive", Image = "https://cdn-icons-png.flaticon.com/512/733/733562.png" },
                    new Category {  Name = "Health & Wellness", Slug = "health-wellness", Image = "https://cdn-icons-png.flaticon.com/512/135/135672.png" },
                    new Category {  Name = "Pet Supplies", Slug = "pet-supplies", Image = "https://cdn-icons-png.flaticon.com/512/616/616408.png" }

                ]);
            }

            if(context.Products.Count() == 0)
            {
                await context.Products.AddRangeAsync([
                    new Product
                    {
                        Title = "Wireless Bluetooth Headphones",
                        Slug = "wireless-bluetooth-headphones",
                        Description = "High-quality sound with noise cancellation and 20h battery life.",
                        Quantity = 50,
                        Price = 79.99m,
                        ImageCover = "https://encrypted-tbn0.gstatic.com/shopping?q=tbn:ANd9GcTTkzxV4EQx5zcKXKXupgqTdTSHSiPIYd79aBIYM3jiPQq0DTrHMTGudg7lqmMcNcjft8x5MbzpxwlYFPsb9XyAJZ9pU6JpikWhNfoH0MSJSIDerqUHBkNZGG8rX-ViGZ88sUBqRpYinF8&usqp=CAc",
                        BrandId = 1,
                        CategoryId = 1,
                        ProductImages = new List<ProductImage>
                        {
                            new ProductImage { ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRuctEBlzRega-Nm3mGsu_S7w2jWJtJyhzrPQ&s" },
                            new ProductImage { ImageUrl = "https://encrypted-tbn1.gstatic.com/shopping?q=tbn:ANd9GcR6-aRKnfbOiSUB3Uy-J8Q2Pq5dgawwSzKkR6pKSLWttHrTVFv7F-BZBLtodGIMAr_Rp8fu9ebN5rpNeBjq_0LD3GxZGXi8b-xZ3X8Wjv6RRwzW-ElyACbeqNWICtIbUKkPkoHKMKpYeQ&usqp=CAc" }
                        }
                    },
                    new Product
                    {
                        Title = "Men's Casual T-Shirt",
                        Slug = "mens-casual-tshirt",
                        Description = "Comfortable cotton T-shirt, available in multiple colors.",
                        Quantity = 100,
                        Price = 15.49m,
                        ImageCover = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTn9bSTOsfqQ4np5zbj-4W_gpTzbc3D113Yig&s",
                        BrandId = 2,
                        CategoryId = 2,
                        ProductImages = new List<ProductImage>
                        {
                            new ProductImage { ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTjlj9bsJcawOgcHPxIaXNn5vgHnSDNiB6UXg&s" },
                            new ProductImage { ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSyJOQKWIhlFtk3zTNrRf2hLLyURSu0WO3I2Q&s" }
                        }
                    },
                    new Product
                    {
                        Title = "Nonstick Frying Pan Set",
                        Slug = "nonstick-frying-pan-set",
                        Description = "3-piece nonstick pan set perfect for any kitchen.",
                        Quantity = 40,
                        Price = 35.99m,
                        ImageCover = "https://encrypted-tbn3.gstatic.com/shopping?q=tbn:ANd9GcT-bLylXuc8RjlpYE-JRHuTZf4Di-WYFodEfiGZSXJVXeWxlO0xH6R9dquQM1PLf9KTnVpKxmuTjnslUG309cGErhfc--BuJgQD2coZ0g4xFBeTsfdNue3BLhreFH3XNOvIEHd-xnYabA&usqp=CAc",
                        BrandId = 3,
                        CategoryId = 3,
                        ProductImages = new List<ProductImage>
                        {
                            new ProductImage { ImageUrl = "https://encrypted-tbn1.gstatic.com/shopping?q=tbn:ANd9GcR830oLeQUJq255VYk9H_jlV7xuxoUC1UMhO-YPRDt6xvKI8JW8ysyvsudmx9ryKPJ7FHCIpHlhbhL-ABi5x_TQeXgeCJFIUXHceztBFDy0iUDGmA2ImWk8FqOGdlnPXmElIHFQyWYy&usqp=CAc" },
                            new ProductImage { ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQkADU6bWuhWrYzfpJBq7AKHGfiluUYwiPWYQ&s" }
                        }
                    },
                    new Product
                    {
                        Title = "Organic Face Moisturizer",
                        Slug = "organic-face-moisturizer",
                        Description = "Hydrating and soothing moisturizer made with natural ingredients.",
                        Quantity = 60,
                        Price = 24.99m,
                        ImageCover = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQIjrpHKsf2-n45wC68ACsKWl9gYCfe4i-DmQ&s",
                        BrandId = 5,
                        CategoryId = 5,
                        ProductImages = new List<ProductImage>
                        {
                            new ProductImage { ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTJxDvjEQOE4jWG9T6bXqCuGL619JLmYrEztA&s" },
                            new ProductImage { ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQwMx1NlPo6v1MkZg4lTvmeslZjbta2wO3KlA&s" }
                        }
                    },
                    new Product
                    {
                        Title = "Yoga Mat with Carrying Strap",
                        Slug = "yoga-mat-with-carrying-strap",
                        Description = "Non-slip surface, 6mm thick, perfect for yoga and pilates.",
                        Quantity = 70,
                        Price = 21.99m,
                        ImageCover = "https://encrypted-tbn0.gstatic.com/shopping?q=tbn:ANd9GcQK3N455VM1q4sj63jbDOdrj6GDKO2Y85D5fz4awp3QleaSzL3ZwCbxAJTJ5H49IWWCJwcoS1u9oeH00j0nB6XIPu-CDlAugBH5c_88WMC2FA-gPpGBNeW3GeXWXIm78atgwB6S1G0&usqp=CAc",
                        BrandId = 7,
                        CategoryId = 7,
                        ProductImages = new List<ProductImage>
                        {
                            new ProductImage { ImageUrl = "https://encrypted-tbn2.gstatic.com/shopping?q=tbn:ANd9GcTY6HlBVavl5oLER6NqdKwHrB_QRu5Ymx32m08rVMo2QT8-OjnAuLnlPTi1jqqGoBnt-fNqxFMgMFKPiHyljd60JL-qj5R3uqHIkF55bFhhV0m1hHF21yb1ENcSysyd1HupvPsf_dI&usqp=CAc" },
                            new ProductImage { ImageUrl = "https://encrypted-tbn3.gstatic.com/shopping?q=tbn:ANd9GcQCVvWaw7q1yq8teuk6OfRIRW0P3MdOA1Oot2Ri11kVqrTjNO9IKR0DdcxZ4dc60UxoFc5361mGHDdp1Q5eMuukjFhReT4izfyt3yMUh0wkDC-vd03URk97_iJ9m3mCT1ua6YIMxQ&usqp=CAc" }
                        }
                    },
                    new Product
                    {
                        Title = "Car Vacuum Cleaner",
                        Slug = "car-vacuum-cleaner",
                        Description = "Portable, powerful suction for keeping your car clean.",
                        Quantity = 30,
                        Price = 29.99m,
                        ImageCover = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQvbVXt3V67Jy_JnjIJxmcYMeVVUt-cSUTcsw&s",
                        BrandId = 8,
                        CategoryId = 8,
                        ProductImages = new List<ProductImage>
                        {
                            new ProductImage { ImageUrl = "https://encrypted-tbn1.gstatic.com/shopping?q=tbn:ANd9GcSNjYDaG9s6oZ4o6LjopYPlulDjbY9B3Rjj76SDHz6U3R7l5tDJ7iyGEpW4h-HVDUdBQuJ6wZOD83K488jvsjNcRYFImqxbIDeSmeF8wYdidp4N71llzV4bBErDCxf2uA&usqp=CAc" },
                            new ProductImage { ImageUrl = "https://encrypted-tbn0.gstatic.com/shopping?q=tbn:ANd9GcQKOfPRrQGspSG4UmOLigDf4tnUZCWh2dr45BayYkzDdotuOCrm_eM3Tw7SkoZYs77NUiLxPZBlRT-V1B3IK5B2hk50lryW0D88f9X3lA2ebvyXb4SsiyzcgwY5CR7UttdSOZDiDg&usqp=CAc" }
                        }
                    },
                    new Product
                    {
                        Title = "Vitamin C Immune Support",
                        Slug = "vitamin-c-immune-support",
                        Description = "1000mg tablets, boosts immunity and overall wellness.",
                        Quantity = 90,
                        Price = 12.99m,
                        ImageCover = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTBWGjosMWfpJbIUoFs23PKFAl8gEzSxyIK6g&s",
                        BrandId = 9,
                        CategoryId = 9,
                        ProductImages = new List<ProductImage>
                        {
                            new ProductImage { ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQ1rPop8z_p1FVb5nOgphRxjbOYymYwsvASSA&s" },
                            new ProductImage { ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQn-OBK62ylgdt2ranjhVIwdPigy5wDbiSwGA&s" }
                        }
                    },
                    new Product
                    {
                        Title = "Pet Food Bowl Set",
                        Slug = "pet-food-bowl-set",
                        Description = "Stainless steel bowl set for food and water, anti-slip base.",
                        Quantity = 45,
                        Price = 18.49m,
                        ImageCover = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQbTHHW9PAv4IN_WNEwjdJquUe4gglDpyPoPQ&s",
                        BrandId = 10,
                        CategoryId = 10,
                        ProductImages = new List<ProductImage>
                        {
                            new ProductImage { ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRyM2E4SzXsZ8HbIpnynr_gZCpoud2GsCcUDg&s" },
                            new ProductImage { ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcT6UQFDLYWAsiydThqFMUEg5Y41dYpduqGy6g&s" }
                        }
                    }
                ]);
            }

            await context.SaveChangesAsync();
        }
    }
}
