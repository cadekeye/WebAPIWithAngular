using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebAPIWithAngular.Models
{
    public class SugarLevel
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public float Value { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public DateTime MeasuredAt { get; set; }
    }
}