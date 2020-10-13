namespace Demo.DesignPattern.NullObject
{
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The user repo.
    /// </summary>
    public class UserRepo
    {
        /// <summary>
        /// The users.
        /// </summary>
        private readonly IList<User> users = new List<User>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserRepo"/> class.
        /// </summary>
        public UserRepo()
        {
            this.users.Add(new User(1, "UserOne", new[] { "user.one@email.com" }));
            this.users.Add(new User(2, "UserTwo", new[] { "user.two@email.com" }));
            this.users.Add(new User(3, "UserThree", new[] { "user.three@email.com" }));
        }

        /// <summary>
        /// The get user.
        /// </summary>
        /// <param name="id">
        /// The id.
        /// </param>
        /// <returns>
        /// The <see cref="IEntity"/>.
        /// </returns>
        public IEntity GetUser(int id)
        {
            var userExists = this.users.Any(u => u.Id == id);
            return userExists ? (IEntity)this.users.FirstOrDefault(u => u.Id == id) : new NullUser();
        }
    }
}