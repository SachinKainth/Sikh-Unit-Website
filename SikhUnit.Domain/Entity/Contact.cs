using System;
using SikhUnit.Domain.Interface.Core;

namespace SikhUnit.Domain.Entity
{
    public class Contact : IEntity
    {
        public int Id { get; set; }
        public string EmailAddress { get; set; }
        public string Name { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }
        public string IPAddress { get; set; }
        public DateTimeOffset DateTimeOffset { get; set; }
    }
}