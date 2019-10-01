namespace Borium.Application.Utils
{
    public class CommandConnectionStringWrapper
    {
        public string Value { get; }
        public CommandConnectionStringWrapper(string connectionString)
        {
            Value = connectionString;
        }

    }
}
