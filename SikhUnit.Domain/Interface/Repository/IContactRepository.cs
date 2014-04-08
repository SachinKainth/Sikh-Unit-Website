using SikhUnit.Domain.Entity;
using SikhUnit.Domain.Interface.Core;

namespace SikhUnit.Domain.Interface.Repository
{
    public interface IContactRepository : IWritableRepository<Contact>
    {
        void SaveContact(Contact contact);
    }
}