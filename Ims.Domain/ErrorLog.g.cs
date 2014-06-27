using System;

namespace Ims.Domain
{
    public class ErrorLog
    {
        public ErrorLog(int errorLogId, DateTime date, string thread, string level, string logger, string message, string exception, string machineName, string applicationVersion, string supportNumber, string username)
        {
            ErrorLogId = errorLogId;
            Date = date;
            Thread = thread;
            Level = level;
            Logger = logger;
            Message = message;
            Exception = exception;
            MachineName = machineName;
            ApplicationVersion = applicationVersion;
            SupportNumber = supportNumber;
            Username = username;
        }
    
        public int ErrorLogId { get; set; }
        public DateTime Date { get; set; }
        public string Thread { get; set; }
        public string Level { get; set; }
        public string Logger { get; set; }
        public string Message { get; set; }
        public string Exception { get; set; }
        public string MachineName { get; set; }
        public string ApplicationVersion { get; set; }
        public string SupportNumber { get; set; }
        public string Username { get; set; }
    }
}