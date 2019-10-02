namespace Borium.Application.Utils
{
    public class QueryConnectionStringWrapper
    {
        public string Value { get; }
        public QueryConnectionStringWrapper(string connectionString)
        {
            Value = connectionString;
        }
    }
}
