using System;

namespace Ims.Domain
{
    public class Membership
    {
        public Membership(int userId, DateTime? createDate, string confirmationToken, bool? isConfirmed, DateTime? lastPasswordFailureDate, int passwordFailuresSinceLastSuccess, string password, DateTime? passwordChangedDate, string passwordSalt, string passwordVerificationToken, DateTime? passwordVerificationTokenExpirationDate)
        {
            UserId = userId;
            CreateDate = createDate;
            ConfirmationToken = confirmationToken;
            IsConfirmed = isConfirmed;
            LastPasswordFailureDate = lastPasswordFailureDate;
            PasswordFailuresSinceLastSuccess = passwordFailuresSinceLastSuccess;
            Password = password;
            PasswordChangedDate = passwordChangedDate;
            PasswordSalt = passwordSalt;
            PasswordVerificationToken = passwordVerificationToken;
            PasswordVerificationTokenExpirationDate = passwordVerificationTokenExpirationDate;
        }
    
        public int UserId { get; set; }
        public DateTime? CreateDate { get; set; }
        public string ConfirmationToken { get; set; }
        public bool? IsConfirmed { get; set; }
        public DateTime? LastPasswordFailureDate { get; set; }
        public int PasswordFailuresSinceLastSuccess { get; set; }
        public string Password { get; set; }
        public DateTime? PasswordChangedDate { get; set; }
        public string PasswordSalt { get; set; }
        public string PasswordVerificationToken { get; set; }
        public DateTime? PasswordVerificationTokenExpirationDate { get; set; }
    }
}