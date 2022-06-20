using Contact.ServicePersistance;
using ContactInfo.Persistent.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace ContactService.Application.Interactions.Contacts
{
    public static class GetAllContacts
    {
        public class Query : IRequest<IEnumerable<ContactEntity>>
        {
        }

        public class Handler : IRequestHandler<Query, IEnumerable<ContactEntity>>
        {
            private readonly ContactServiceDBContext _dbContext;

            public Handler(ContactServiceDBContext dbContext)
            {
                _dbContext = dbContext;
            }

            public async Task<IEnumerable<ContactEntity>> Handle(Query request, CancellationToken cancellationToken)
            {
                return await _dbContext.ContactEntities.ToListAsync();
            }
        }
    }
}
