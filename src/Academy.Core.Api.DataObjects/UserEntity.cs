using System;

namespace Academy.Core.Api.DataObjects
{
    public class UserEntity : BaseEntity
    {
        public DateTime? DateOfBirth { get; set; }

        public string Email { get; set; }

        public string FirstName { get; set; }

        public Guid Id { get; set; }

        public string LastName { get; set; }

        public string MiddleName { get; set; }

        public string PasswordHash { get; set; }
    }
}