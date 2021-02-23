using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Models
{
    public class PlaygroundRate
    {
        public float Rate { get; set; }

        public string ApplicationUserId { get; set; }
        public virtual ApplicationUser ApplicationUser { get; set; }

        public int PlaygroundId { get; set; }

        public virtual Playground Playground { get; set; }
    }
}