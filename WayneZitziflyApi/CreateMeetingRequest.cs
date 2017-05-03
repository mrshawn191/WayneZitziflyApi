using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using WayneZitziflyApi.Model;

namespace WayneZitziflyApi
{
    public class CreateMeetingRequest
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        public string Description { get; set; }

        [Required]
        public MeetingType MeetingType { get; set; }

        [Required]
        public Address Address { get; set; }

        [Required]
        public User Owner { get; set; }

        public List<User> AcceptedUsers { get; set; }

        [Required]
        public DateTimeOffset StartTime { get; set; }

        [Required]
        public DateTimeOffset EndTime { get; set; }

        [Required]
        public DateTimeOffset CreatedAt { get; set; }
    }
}