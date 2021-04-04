using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace UtaPrototype.Models
{
    public partial class User
    {
        public User()
        {
            PomoTimerSettings = new HashSet<PomoTimerSetting>();
        }

        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [EmailAddress]
        public string Email { get; set; }

        public virtual ICollection<PomoTimerSetting> PomoTimerSettings { get; set; }
    }
}
