using ShipEngine.Models.Package.Dto;
using ShipEngine.Models.Domain;
using System.Collections.Generic;
using System.Threading.Tasks;
using ShipEngine.Models;
namespace ShipEngine.Extensions
{
    public static class PackageExtensions
    {
        public async static Task<Information> TrackPackage(this ShipEngine shipEngine, string carrierCode, string trackingNumber)
        {
            var trackPackageParams = new TrackPackageParams
            {
                CarrierCode = carrierCode,
                TrackingNumber = trackingNumber,
            };

            var result = await shipEngine.Package.Track(trackPackageParams);
            result.AssertNoErrorMessages();
            return result.Information;
        }


        public async static Task<Information> TrackPackage(this ShipEngine shipEngine, string packageId)
        {
            var trackPackageParams = new TrackPackageParams
            {
                PackageId = packageId,
            };

            var result = await shipEngine.Package.Track(trackPackageParams);
            result.AssertNoErrorMessages();
            return result.Information;
        }
    };
};