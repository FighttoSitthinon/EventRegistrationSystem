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
        private readonly IHttpContextAccessor httpContextAccessor;

        public TicketService(ApplicationDbContext dbContext, IHttpContextAccessor httpContextAccessor)
        {
            this.ticketRepository = new TicketRepository(dbContext);
            this.httpContextAccessor = httpContextAccessor;
        }

        public TicketDto FindById(string Id)
        {
            var ticket = ticketRepository.Get(Id);
            if (ticket == null) return null;

            return new TicketDto(ticket);
        }

        public TicketDto FindByTicketNumber(string TicketNumber)
        {
            var ticket = ticketRepository.GetByTicketNumber(TicketNumber);
            if (ticket == null) return null;

            return new TicketDto(ticket);
        }

        public PagedList<TicketDto> List(string eventId, int page = 1)
        {
            int pageSize = 12;

            var query = ticketRepository.List(eventId).Select(x => new TicketDto(x));
            if (query == null) return null;

            return PagedList<TicketDto>.ToPagedList(query, page, pageSize);
        }

        public string CreateTicket(TicketRegisterDto model)
        {
            // validate duplicate email or phone
            bool duplicate = ticketRepository.IsUserAlreadyRegisterEvent(model.EventId, model.Email, model.PhoneNumber);
            if (duplicate) return null;

            Ticket role = new Ticket()
            {
                Id = Guid.NewGuid().ToString().ToUpper(),
                TicketNumber = Guid.NewGuid().ToString().Replace("-", "").ToUpper().Substring(0, 15),
                Status = (int)Status.Active,
                Email = model.Email,
                PhoneNumber = model.PhoneNumber,
                EventId = model.EventId
            };

            ticketRepository.Create(role);
            ticketRepository.Save();
            return role.TicketNumber;
        }

        public string UpdateTicket(TicketDto model)
        {
            var ticket = ticketRepository.Get(model.Id);
            if (ticket == null) return string.Empty;

            ticket.PhoneNumber = model.PhoneNumber;
            ticket.Email = model.Email;
            ticket.UpdatedDate = DateTime.UtcNow;
            ticket.UpdatedBy = GetUserName();

            ticketRepository.Update(ticket);
            ticketRepository.Save();

            return ticket.TicketNumber;
        }

        private string GetUserName() => httpContextAccessor != null ? httpContextAccessor.HttpContext.User.Identity.Name : string.Empty;

    }
}
