using System;

namespace Ims.Domain
{
    public class WarrantMovement
    {
        public WarrantMovement(int warrantMovementId, int warrantId, short accountHolderCompanyId, short? accountId, DateTime movementDateTimeUtc, int movedByUserId, int? requestId)
        {
            WarrantMovementId = warrantMovementId;
            WarrantId = warrantId;
            AccountHolderCompanyId = accountHolderCompanyId;
            AccountId = accountId;
            MovementDateTimeUtc = movementDateTimeUtc;
            MovedByUserId = movedByUserId;
            RequestId = requestId;
        }
    
        public int WarrantMovementId { get; set; }
        public int WarrantId { get; set; }
        public short AccountHolderCompanyId { get; set; }
        public short? AccountId { get; set; }
        public DateTime MovementDateTimeUtc { get; set; }
        public int MovedByUserId { get; set; }
        public int? RequestId { get; set; }
    }
}