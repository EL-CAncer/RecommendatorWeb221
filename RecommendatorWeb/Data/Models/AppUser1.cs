﻿using RecommendatorWeb.Models;

namespace RecommendatorWeb.Data.Models
{
    public class AppUser1
    {
        public AppUser1()
        {
            Topics = new HashSet<Topic>();
            Comments = new HashSet<Comment>();
        }
        public int Id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public UserRole Role { get; set; }

        // Navigation properties
        public ICollection<Topic> Topics { get; set; }
        public ICollection<Comment> Comments { get; set; }

        public enum UserRole
        {
            User,
            Administrator
        }
    }
}
