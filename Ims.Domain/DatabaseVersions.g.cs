using System;

namespace Ims.Domain
{
    public class DatabaseVersions
    {
        public DatabaseVersions(int databaseVersionId, string versionNumber)
        {
            DatabaseVersionId = databaseVersionId;
            VersionNumber = versionNumber;
        }
    
        public int DatabaseVersionId { get; set; }
        public string VersionNumber { get; set; }
    }
}