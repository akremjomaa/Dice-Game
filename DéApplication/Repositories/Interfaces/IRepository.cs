namespace DéApplication.Repositories.Interfaces
{
    public interface IRepository<T> : Ardalis.Specification.IRepositoryBase<T> where T : class
    {
    }
}
