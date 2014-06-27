using System;
using System.Collections.Generic;
using System.Data;
using Ims.Core;
using Ims.Domain;

namespace Ims.DataAccess
{
    public interface IStoreDataService
    {
        void Insert(Store store);

        void Update(Store store);

        void DeleteMany(params short[] ids);

    }

    public class StoreDataService : IStoreDataService
    {
        public virtual void Insert(Store store)
        {
            using (TransactionScope transactionScope = new TransactionScope())
            {
                store.StoreId = transactionScope.ExecuteScalar<short>("storage.Store_Insert", CommandType.StoredProcedure, new Parameter("StoreId", SqlDbType.SmallInt, store.StoreId), new Parameter("StorageCompanyId", SqlDbType.SmallInt, store.StorageCompanyId), new Parameter("StoreCode", SqlDbType.NVarChar, store.StoreCode), new Parameter("StoreName", SqlDbType.NVarChar, store.StoreName), new Parameter("LocationId", SqlDbType.SmallInt, store.LocationId), new Parameter("IsActive", SqlDbType.Bit, store.IsActive));
            }
        }

        public virtual void Update(Store store)
        {
            using (TransactionScope transactionScope = new TransactionScope())
            {
                transactionScope.ExecuteNonQuery("storage.Store_Update", CommandType.StoredProcedure, new Parameter("StoreId", SqlDbType.SmallInt, store.StoreId), new Parameter("StorageCompanyId", SqlDbType.SmallInt, store.StorageCompanyId), new Parameter("StoreCode", SqlDbType.NVarChar, store.StoreCode), new Parameter("StoreName", SqlDbType.NVarChar, store.StoreName), new Parameter("LocationId", SqlDbType.SmallInt, store.LocationId), new Parameter("IsActive", SqlDbType.Bit, store.IsActive));
            }
        }

        public virtual void DeleteMany(params short[] ids)
        {
            using (TransactionScope transactionScope = new TransactionScope())
            {
                transactionScope.ExecuteNonQuery("storage.Store_DeleteMany", CommandType.StoredProcedure, new Parameter("Ids", SqlDbType.Binary, ids.ToByteArray()));
            }
        }

    }
}
