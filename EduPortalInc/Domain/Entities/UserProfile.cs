using System;

namespace Domain.Entities
{
    public class UserProfile
    {
        public int Id { get; set; } 
        public required string PhoneNumber { get; set; } 
        public required string Bio { get; set; } 
        public DateTime DateOfBirth { get; set; } 
    }
}
