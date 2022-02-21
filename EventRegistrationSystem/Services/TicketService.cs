using EventRegistrationSystem.Data;
using EventRegistrationSystem.Models;
using EventRegistrationSystem.Models.Dto;
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

        public TicketDto Find(string Id)
        {
            var ticket = ticketRepository.Get(Id);

            return new TicketDto(ticket);
        }

        public PagedList<TicketDto> List(string eventId, int page = 1)
        {
            int pageSize = 12;

            var query = ticketRepository.List(eventId).Select(x => new TicketDto(x));

            return PagedList<TicketDto>.ToPagedList(query, page, pageSize);
        }

        public string CreateTicket(TicketRegisterDto model)
        {
            Ticket role = new Ticket()
            {
                Id = Guid.NewGuid().ToString().ToUpper(),
                TicketNumber = Guid.NewGuid().ToString().Take(15).ToString().ToUpper(),
                Status = (int)Status.Active,
                Email = model.Email,
                PhoneNumber = model.PhoneNumber,
                EventId = model.EventId
            };

            ticketRepository.Create(role);
            ticketRepository.Save();
            return role.Id;
        }

        public string UpdateTicket(TicketDto model)
        {
            var ticket = ticketRepository.Get(model.Id);
            if (ticket == null) return string.Empty;

            ticket.PhoneNumber = model.PhoneNumber;
            ticket.Email = model.Email;

            ticketRepository.Update(ticket);
            ticketRepository.Save();

            return ticket.Id;
        }
    }
}
