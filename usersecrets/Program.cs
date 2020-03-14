using Microsoft.Extensions.Configuration;
using System;

class Program
{
    static void Main()
    {
        // It is required to set "User Secrets" to the project as following steps:
        // 1. Right click on this project in Solution Explorer
        // 2. Click "Manage User Secrets"
        //   - Notes: May not displayed when "ASP.NET and web development" not installed
        // 3. Add an item has "test" key to User Secrets then save

        var configuration = new ConfigurationBuilder().AddUserSecrets<Program>().Build();
            
        Console.WriteLine(configuration["test"]);
    }
}
