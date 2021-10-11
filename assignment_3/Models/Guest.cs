using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace assignment_3.Models
{
    public class Guest
    {
        public Guest() {}
        
        public Guest(string name, string title, string message)
        {
            Name = name;
            Title = title;
            Message = message;
        }

        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        [DisplayName("Name")]
        public string Name { get; set; }
        

        [Required]
        [StringLength(50, MinimumLength = 5)]
        [DisplayName("Title")]
        public string Title { get; set; }
        
        
        [Required]
        [StringLength(200, MinimumLength = 20)]
        [DisplayName("Message")]
        public string Message { get; set; }
        
    }
}