namespace CommandsService.Dtos
{
    public record PlatformPublishedDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Event { get; set; }
    }
}
