namespace SikhUnit.Domain.Interface.Core
{
    public interface IWritableRepository<in T> where T : IEntity
    {
        void Save(T t);
    }
}