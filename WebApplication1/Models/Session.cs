﻿using Microsoft.AspNetCore.Identity;
namespace WebApplication1.Models
{
    public class Session
    {
        public int Id { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public string? UserId { get; set; }
        public IdentityUser? User { get; set; }  
    }
}