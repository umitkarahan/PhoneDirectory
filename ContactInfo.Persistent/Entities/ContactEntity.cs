using Contact.ServicePersistent.Entities;

namespace ContactInfo.Persistent.Entities
{
    public class ContactEntity
    {
        public Guid Uuid { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Firm { get; set; }
        public List<ContactInfoEntity>? ContactInfos { get; set; }

    }
}
