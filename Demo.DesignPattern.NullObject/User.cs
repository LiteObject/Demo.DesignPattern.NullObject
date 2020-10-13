namespace Demo.DesignPattern.NullObject
{
    /// <summary>
    /// The user.
    /// </summary>
    public class User : IEntity
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="User"/> class.
        /// </summary>
        /// <param name="id">
        /// The id.
        /// </param>
        /// <param name="username">
        /// The username.
        /// </param>
        /// <param name="emails">
        /// The emails.
        /// </param>
        public User(int id, string username, string[] emails)
        {
            this.Id = id;
            this.Username = username;
            this.Emails = emails;
        }

        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the username.
        /// </summary>
        public string Username { get; set; }

        /// <summary>
        /// Gets or sets the emails.
        /// </summary>
        public string[] Emails { get; set; }
    }
}