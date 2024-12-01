using Microsoft.EntityFrameworkCore;

class Program
{
    static void Main(string[] args)
    {
        using (var dbContext = new AppDbContext())
        {
            dbContext.Database.Migrate(); // Apply migrations

            // Example usage
            var user = new User { Name = "John Doe", Email = "john.doe@example.com" };
            dbContext.Users.Add(user);
            dbContext.SaveChanges();
        }
    }
}
