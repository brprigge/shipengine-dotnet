using ShipEngine.Models;
using System.Threading.Tasks;

namespace ShipEngine.Extensions
{
    public static class TagExtensions
    {
        public async static Task<string> CreateTag(this ShipEngine shipEngine, string tag)
        {
            var tagParams = new CreateTagParams
            {
                Name = tag,
            };
            CreateTagResult tags = await shipEngine.Tags.Create(tagParams);
            return tags.Name;
        }
    }
}
