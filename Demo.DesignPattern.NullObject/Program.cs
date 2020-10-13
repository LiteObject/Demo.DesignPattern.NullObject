namespace Demo.DesignPattern.NullObject
{
    using System;

    /// <summary>
    /// The program.
    /// This demo is based on: https://app.pluralsight.com/library/courses/csharp-design-patterns-null-object/description
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// The main.
        /// </summary>
        private static void Main()
        {
            var userRepo = new UserRepo();
            var user = userRepo.GetUser(1);

            Console.WriteLine($"Id: {user.Id}, Username: {user.Username}, Email(s): {string.Join(",", user.Emails)}");
        }
    }
}