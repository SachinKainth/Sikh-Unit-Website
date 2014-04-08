using SikhUnit.Domain.Entity;

namespace SikhUnit.Domain.Interface.Service
{
    public interface IEmailService
    {
        void Send(Contact contact);
    }
}