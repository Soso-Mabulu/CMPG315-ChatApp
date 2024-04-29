namespace CommonLibs.Connections.Repositories
{
    public interface ConnectionStringProvider
    {
        /// <summary>
        /// Returns connection string to a database from App.config
        /// </summary>
        /// <returns></returns>
        string LoadConnectionString();
    }
}
