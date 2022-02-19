﻿using System.ComponentModel.DataAnnotations;

namespace EventRegistrationSystem.Models
{
    public class Ticket
    {
        [Key]
        [Required]
        public string Id { get; set; }
        [Required]
        public string TicketNumber { get; set; }
        [Required]
        public string EventId { get; set; }
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }
        public string? UserId { get; set; }
        public bool IsActive { get; set; }
        public int IsDeleted { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }

    }
}
