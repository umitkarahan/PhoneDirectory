
using ContactInfo.Persistent.Entities;

namespace Contact.ServicePersistent.Entities
{
    public class ContactInfoEntity
    {
        public Guid Uuid { get; set; }
        public Guid ContactId { get; set; }
        public int Type { get; set; }
        public string Content { get; set; }
        public ContactEntity Contact { get; set; }

    }
}
