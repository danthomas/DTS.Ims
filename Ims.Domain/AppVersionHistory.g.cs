using System;

namespace Ims.Domain
{
    public class AppVersionHistory
    {
        public AppVersionHistory(byte appVersionHistoryId, byte appVersionId, string versionNumber, string componentCode, string componentName, bool isSolution, string notes, string serverList, DateTime createDateTimeUtc, string createUserName, DateTime? updateDateTimeUtc, string updateUserName, string versionHistoryDateTimeUtc, string action)
        {
            AppVersionHistoryId = appVersionHistoryId;
            AppVersionId = appVersionId;
            VersionNumber = versionNumber;
            ComponentCode = componentCode;
            ComponentName = componentName;
            IsSolution = isSolution;
            Notes = notes;
            ServerList = serverList;
            CreateDateTimeUtc = createDateTimeUtc;
            CreateUserName = createUserName;
            UpdateDateTimeUtc = updateDateTimeUtc;
            UpdateUserName = updateUserName;
            VersionHistoryDateTimeUtc = versionHistoryDateTimeUtc;
            Action = action;
        }
    
        public byte AppVersionHistoryId { get; set; }
        public byte AppVersionId { get; set; }
        public string VersionNumber { get; set; }
        public string ComponentCode { get; set; }
        public string ComponentName { get; set; }
        public bool IsSolution { get; set; }
        public string Notes { get; set; }
        public string ServerList { get; set; }
        public DateTime CreateDateTimeUtc { get; set; }
        public string CreateUserName { get; set; }
        public DateTime? UpdateDateTimeUtc { get; set; }
        public string UpdateUserName { get; set; }
        public string VersionHistoryDateTimeUtc { get; set; }
        public string Action { get; set; }
    }
}