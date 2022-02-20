using EventRegistrationSystem.Data;
using EventRegistrationSystem.Repositories;
using EventRegistrationSystem.Repositories.IRepositories;
using EventRegistrationSystem.Services.IServices;

namespace EventRegistrationSystem.Services
{
    public class TicketService : ITicketService
    {
        public readonly ITicketRepository ticketRepository;
        public TicketService(ApplicationDbContext dbContext)
        {
            this.ticketRepository = new TicketRepository(dbContext);
        }

    }
}
