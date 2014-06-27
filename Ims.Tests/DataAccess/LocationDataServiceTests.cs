using System;
using Ims.DataAccess;
using Ims.Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Ims.Tests
{
    [TestClass]
    public class LocationDataServiceTests : DataServiceTestsBase
    {
        [TestMethod]
        public void InsertUpdateDeleteLocation()
        {
            LocationDataService locationDataService = new LocationDataService();

            Location location = locationDataService.SelectByLocationCode("XX");

            if (location != null)
            {
                locationDataService.DeleteMany(location.LocationId);
            }

            location = new Location(0, "XX", "Xxxxxxxxxxxxxx", true);

            locationDataService.Insert(location);
            location.IsActive = false;
            locationDataService.Update(location);
            location = locationDataService.SelectByLocationId(location.LocationId);
            locationDataService.DeleteMany(location.LocationId);
        }
    }
}
