namespace MyBlog.Dtos
{
    public record PostDto
    {
        public Guid Id { get; init; }
        public required string Title { get; init; }
        public required string Content { get; init; }
        public  DateTimeOffset DateCreated { get; init; }
        public DateTimeOffset? DateModified { get; init; }
    
    }
}