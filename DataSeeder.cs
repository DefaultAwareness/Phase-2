public static class DataSeeder
{
    public static void Seed(AppDbContext context)
    {
        if (!context.Users.Any())
        {
            context.Users.Add(new User { Name = "Admin", Email = "admin@example.com" });
            context.SaveChanges();
        }

        if (!context.Products.Any())
        {
            context.Products.Add(new Product { Name = "Sample Product", Price = 9.99m });
            context.SaveChanges();
        }
    }
}
