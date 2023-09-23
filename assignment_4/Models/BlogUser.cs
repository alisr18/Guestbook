using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace assignment_4.Models
{
    
        public class BlogUser
        {
            public BlogUser() {}
        
            public BlogUser(string nickname, string title, string summary, string content, DateTime time)
            {
                Nickname = nickname;
                Title = title;
                Summary = summary;
                Content = content;
                Time = time;
            }

            public int Id { get; set; }

            [Required]
            [StringLength(100)]
            [DisplayName("Nickname")]
            public string Nickname { get; set; }

            [Required]
            [StringLength(100)]
            [DisplayName("Title")]
            public string Title { get; set; }

            [Required]
            [StringLength(100)]
            [DisplayName("Summary")]
            public string Summary { get; set; }
            
            [Required]
            [StringLength(100)]
            [DisplayName("Content")]
            public string Content { get; set; }
            
            [DataType(DataType.Date)]
            [DisplayName("Time")]
            public DateTime Time { get; set; }
    }
}