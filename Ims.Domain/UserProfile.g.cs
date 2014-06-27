using System;

namespace Ims.Domain
{
    public class UserProfile
    {
        public UserProfile(int userId, short companyId, string userName, string emailAddress, string firstName, string lastName, string memorableWord, string memorableWordIndices, bool activeStatus, bool isConfirmed, bool isWindowsUser, DateTime lastModified)
        {
            UserId = userId;
            CompanyId = companyId;
            UserName = userName;
            EmailAddress = emailAddress;
            FirstName = firstName;
            LastName = lastName;
            MemorableWord = memorableWord;
            MemorableWordIndices = memorableWordIndices;
            ActiveStatus = activeStatus;
            IsConfirmed = isConfirmed;
            IsWindowsUser = isWindowsUser;
            LastModified = lastModified;
        }
    
        public int UserId { get; set; }
        public short CompanyId { get; set; }
        public string UserName { get; set; }
        public string EmailAddress { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MemorableWord { get; set; }
        public string MemorableWordIndices { get; set; }
        public bool ActiveStatus { get; set; }
        public bool IsConfirmed { get; set; }
        public bool IsWindowsUser { get; set; }
        public DateTime LastModified { get; set; }
    }
}