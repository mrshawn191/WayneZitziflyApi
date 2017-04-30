using System;
using System.ComponentModel.DataAnnotations;

namespace WayneZitziflyApi.Model
{
    public class Meeting
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        public string Description { get; set; }

        [Required]
        public MeetingType MeetingType { get; set; }

        [Required]
        public DateTimeOffset CreatedAt { get; set; }
    }


}