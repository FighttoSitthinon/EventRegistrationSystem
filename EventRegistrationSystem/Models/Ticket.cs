﻿using System.ComponentModel.DataAnnotations;

namespace EventRegistrationSystem.Models
{
    public class Ticket
    {

        public string Id { get; set; }
        public string TicketNumber { get; set; }
        public string EventId { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string? UserId { get; set; }
        public int Status { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }

    }
}
