using System;
using System.Collections.Generic;
using System.Data;
using Ims.Core;
using Ims.Domain;

namespace Ims.DataAccess
{
    public interface ILocationDataService
    {
        void Insert(Location location);

        void Update(Location location);

        void DeleteMany(params short[] ids);

        Location SelectByLocationId(short locationId);

        Location SelectByLocationCode(string locationCode);
    }

    public class LocationDataService : ILocationDataService
    {
        public virtual void Insert(Location location)
        {
            using (TransactionScope transactionScope = new TransactionScope())
            {
                location.LocationId = transactionScope.ExecuteScalar<short>("core.Location_Insert", CommandType.StoredProcedure, new Parameter("LocationId", SqlDbType.SmallInt, location.LocationId), new Parameter("LocationCode", SqlDbType.VarChar, location.LocationCode), new Parameter("LocationName", SqlDbType.VarChar, location.LocationName), new Parameter("IsActive", SqlDbType.Bit, location.IsActive));
            }
        }

        public virtual void Update(Location location)
        {
            using (TransactionScope transactionScope = new TransactionScope())
            {
                transactionScope.ExecuteNonQuery("core.Location_Update", CommandType.StoredProcedure, new Parameter("LocationId", SqlDbType.SmallInt, location.LocationId), new Parameter("LocationCode", SqlDbType.VarChar, location.LocationCode), new Parameter("LocationName", SqlDbType.VarChar, location.LocationName), new Parameter("IsActive", SqlDbType.Bit, location.IsActive));
            }
        }

        public virtual void DeleteMany(params short[] ids)
        {
            using (TransactionScope transactionScope = new TransactionScope())
            {
                transactionScope.ExecuteNonQuery("core.Location_DeleteMany", CommandType.StoredProcedure, new Parameter("Ids", SqlDbType.Binary, ids.ToByteArray()));
            }
        }

        public virtual Location SelectByLocationId(short locationId)
        {
            using (TransactionScope transactionScope = new TransactionScope())
            {
                DataRow dataRow = transactionScope.ExecuteDataRow("core.Location_SelectByLocationId", CommandType.StoredProcedure, new Parameter("LocationId", SqlDbType.SmallInt, locationId));

                return dataRow == null ? null : new Location(dataRow.Field<short>("LocationId"), dataRow.Field<string>("LocationCode"), dataRow.Field<string>("LocationName"), dataRow.Field<bool>("IsActive"));
            }
        }

        public virtual Location SelectByLocationCode(string locationCode)
        {
            using (TransactionScope transactionScope = new TransactionScope())
            {
                DataRow dataRow = transactionScope.ExecuteDataRow("core.Location_SelectByLocationCode", CommandType.StoredProcedure, new Parameter("LocationCode", SqlDbType.VarChar, locationCode));

                return dataRow == null ? null : new Location(dataRow.Field<short>("LocationId"), dataRow.Field<string>("LocationCode"), dataRow.Field<string>("LocationName"), dataRow.Field<bool>("IsActive"));
            }
        }
    }
}
