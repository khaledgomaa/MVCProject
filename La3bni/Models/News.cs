using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Models
{
    public class News
    {
        public int NewsId { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        [MinLength(30)]
        public string Description { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime CreatedOn { get; set; }

        [Required]
        // image path
        public string Image { get; set; }
    }
}