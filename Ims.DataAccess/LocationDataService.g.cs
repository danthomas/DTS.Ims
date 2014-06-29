using System;
using System.Collections.Generic;
using System.Data;
using DTS.AppFramework.Core;
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
            using (ImsDataContext imsDataContext = new ImsDataContext())
            {
                location.LocationId = imsDataContext.ExecuteScalar<short>("core.Location_Insert", CommandType.StoredProcedure, new Parameter("LocationId", SqlDbType.SmallInt, location.LocationId), new Parameter("LocationCode", SqlDbType.VarChar, location.LocationCode), new Parameter("LocationName", SqlDbType.VarChar, location.LocationName), new Parameter("IsActive", SqlDbType.Bit, location.IsActive));
            }
        }

        public virtual void Update(Location location)
        {
            using (ImsDataContext imsDataContext = new ImsDataContext())
            {
                imsDataContext.ExecuteNonQuery("core.Location_Update", CommandType.StoredProcedure, new Parameter("LocationId", SqlDbType.SmallInt, location.LocationId), new Parameter("LocationCode", SqlDbType.VarChar, location.LocationCode), new Parameter("LocationName", SqlDbType.VarChar, location.LocationName), new Parameter("IsActive", SqlDbType.Bit, location.IsActive));
            }
        }

        public virtual void DeleteMany(params short[] ids)
        {
            using (ImsDataContext imsDataContext = new ImsDataContext())
            {
                imsDataContext.ExecuteNonQuery("core.Location_DeleteMany", CommandType.StoredProcedure, new Parameter("Ids", SqlDbType.Binary, ids.ToByteArray()));
            }
        }

        public virtual Location SelectByLocationId(short locationId)
        {
            using (ImsDataContext imsDataContext = new ImsDataContext())
            {
                DataRow dataRow = imsDataContext.ExecuteDataRow("core.Location_SelectByLocationId", CommandType.StoredProcedure, new Parameter("LocationId", SqlDbType.SmallInt, locationId));

                return dataRow == null ? null : new Location(dataRow.Field<short>("LocationId"), dataRow.Field<string>("LocationCode"), dataRow.Field<string>("LocationName"), dataRow.Field<bool>("IsActive"));
            }
        }

        public virtual Location SelectByLocationCode(string locationCode)
        {
            using (ImsDataContext imsDataContext = new ImsDataContext())
            {
                DataRow dataRow = imsDataContext.ExecuteDataRow("core.Location_SelectByLocationCode", CommandType.StoredProcedure, new Parameter("LocationCode", SqlDbType.VarChar, locationCode));

                return dataRow == null ? null : new Location(dataRow.Field<short>("LocationId"), dataRow.Field<string>("LocationCode"), dataRow.Field<string>("LocationName"), dataRow.Field<bool>("IsActive"));
            }
        }
    }
}
