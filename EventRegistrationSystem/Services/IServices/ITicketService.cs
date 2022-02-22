using EventRegistrationSystem.Models.Dto;

namespace EventRegistrationSystem.Services.IServices
{
    public interface ITicketService
    {
        string CreateTicket(TicketRegisterDto model);
        string UpdateTicket(TicketDto model);

        TicketDto FindById(string Id);
        TicketDto FindByTicketNumber(string TicketNumber);
        PagedList<TicketDto> List(string eventId, int page = 1);
    }
}
