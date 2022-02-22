﻿using EventRegistrationSystem.Models;

namespace EventRegistrationSystem.Repositories.IRepositories
{
    public interface ITicketRepository: IDisposable
    {
        Ticket Get(string id);
        Ticket GetByTicketNumber(string TicketNumber);
        IQueryable<Ticket> List(string eventId);
        void Create(Ticket model);
        void Update(Ticket model);
        void Save();
    }
}
