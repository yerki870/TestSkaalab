using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TestSkaalab.Models
{
    public class Resource
    {

        [Key]
        public Guid Id { get; set; }
        [Required]
        public string Title { get; set; }
        public string  Description { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

    }
}