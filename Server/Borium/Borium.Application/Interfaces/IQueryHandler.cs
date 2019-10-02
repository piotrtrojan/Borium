namespace Borium.Application.Interfaces
{
    public interface IQueryHandler<TQuery, TResult> where TQuery : IQuery<TResult>
    {
        // TODO: Consider adding new class: QueryResult<T>
        TResult Handle(TQuery query);
    }
}
