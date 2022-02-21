using EventRegistrationSystem.Models.Dto;

namespace EventRegistrationSystem.Services.IServices
{
    public interface ITicketService
    {
        string CreateTicket(TicketRegisterDto model);
        string UpdateTicket(TicketDto model);

        TicketDto Find(string Id);
        PagedList<TicketDto> List(string eventId, int page = 1);
    }
}
