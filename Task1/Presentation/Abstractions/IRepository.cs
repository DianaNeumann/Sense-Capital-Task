namespace Presentation.Abstractions;

public interface IRepository<T>
{
    void Add(T entity);
    void Delete(T entity);
    
    IReadOnlyCollection<T> GetAll();
    T? FindById(Guid id);
}