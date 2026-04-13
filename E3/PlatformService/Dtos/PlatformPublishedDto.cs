using System.Reflection.Metadata.Ecma335;

namespace PlatformService.Dtos
{
    public record PlatformPublishedDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Event { get; set; }
    }
}
