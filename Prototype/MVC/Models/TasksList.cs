using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace UtaPrototype.Models
{
    public partial class TasksList
    {
        //TODO: MAKE HIDDEN AND AUTO INCREMENT
        public int Id { get; set; }

        [Required]
        public string TaskName { get; set; }
        public string TaskInfo { get; set; }
        public int? TaskPrority { get; set; }

        //TODO: REMOVE THIS
        public DateTime? DateCreated { get; set; }

        //TODO: NEEDS TO BE JUST DATE
        [Required]
        public DateTime? DueDate { get; set; }

        //TODO: HIDE THIS
        public bool? IsComplete { get; set; }
    }
}
