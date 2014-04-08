using SikhUnit.DataAccess.Context;
using SikhUnit.Domain.Entity;
using SikhUnit.DataAccess.Core;
using SikhUnit.Domain.Interface.Repository;

namespace SikhUnit.DataAccess.Repository
{
    public class ContactRepository : WritableRepository<Contact>, IContactRepository
    {
        public ContactRepository(DatabaseContext context)
            : base(context)
        {
        }

        public void SaveContact(Contact contact)
        {
            Context.Contacts.Add(contact);
            Save(contact);
        }
    }
}