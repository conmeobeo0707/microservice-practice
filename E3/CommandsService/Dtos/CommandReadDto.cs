using System.Reflection.Metadata.Ecma335;

namespace CommandsService.Dtos
{
    public record CommandReadDto
    {
        public int Id { get; set; }
        public string HowTo { get; set; }
        public string CommandLine { get; set; }
        public int PlatformId { get; set; }
    }
}
