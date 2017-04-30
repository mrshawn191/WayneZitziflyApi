using System;

namespace WayneZitziflyApi.Model
{
    public class User
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTimeOffset? DateOfBirth { get; set; }

        public DateTimeOffset? CreatedAt { get; set; }

        public DateTimeOffset? DeleteAt { get; set; }
    }
}