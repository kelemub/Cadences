using System;
using System.ComponentModel.DataAnnotations;

namespace Domain
{
    public class Activity
    {
        [Key]
        [StringLength(450)]
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public required string Title { get; set; }
        public required string Description { get; set; }
        public required string Category { get; set; }
        public DateTime Date { get; set; }
        public bool IsCancelled { get; set; }

        //Location
        public required string City { get; set; }
        public required string Venue { get; set; }
        public decimal Latitude { get; set; }
        public decimal Longitude { get; set; }
    }
}