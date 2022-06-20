

using Contact.ServicePersistance;
using ContactInfo.Persistent.Entities;
using MediatR;

namespace ContactService.Application.Interactions.Contacts
{
    public static class CreateContact
    {

        public class Command : IRequest<ContactEntity>
        {
            public ContactEntity? Contact { get; set; }
        }

        public class Handler : IRequestHandler<Command, ContactEntity>
        {
            private readonly ContactServiceDBContext _dbContext;

            public Handler(ContactServiceDBContext dbContext)
            {
                _dbContext = dbContext;
            }

            public async Task<ContactEntity> Handle(Command request, CancellationToken cancellationToken)
            {
                if (request.Contact == null) throw new NullReferenceException();//TODO: add exceptions...
                                                                                //TODO: validate input. 
                request.Contact.Uuid = Guid.NewGuid();
                _dbContext
                    .ContactEntities
                    .Add(request.Contact);

                await _dbContext.SaveChangesAsync(cancellationToken);

                return request.Contact;
            }
        }
    }
}

