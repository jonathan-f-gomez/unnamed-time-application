using System;
using System.Collections.Generic;

#nullable disable

namespace UtaPrototype.Models
{
    public partial class PomoTimerSetting
    {
        public int TaskId { get; set; }
        public TimeSpan? WorkTimer { get; set; }
        public TimeSpan? LongTimer { get; set; }
        public TimeSpan? ShortTimer { get; set; }
        public int UserId { get; set; }

        public virtual User User { get; set; }
    }
}
