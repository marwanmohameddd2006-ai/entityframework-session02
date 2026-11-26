using Assignment_Session02_EFCore.Contexts;

namespace Assignment_Session02_EFCore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using EventHubDbContext dbContext = new EventHubDbContext();
        }
    }
}
