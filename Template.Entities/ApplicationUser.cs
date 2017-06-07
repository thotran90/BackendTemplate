using System;

namespace Template.Entities
{
    public class ApplicationUser
    {
        public int UserId { get; set; }
        public string LoginId { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Avatar { get; set; }
        public bool IsDisabled { get; set; }
        public DateTime RegisterDate { get; set; }
    }
}
