namespace Demo.DesignPattern.NullObject
{
    /// <summary>
    /// The null user.
    /// </summary>
    public class NullUser : IEntity
    {
        /// <summary>
        /// Gets or sets the emails.
        /// </summary>
        public string[] Emails { get; set; } = { };

        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        public int Id { get; set; } = default;

        /// <summary>
        /// Gets or sets the username.
        /// </summary>
        public string Username { get; set; } = default;
    }
}