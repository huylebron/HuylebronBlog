namespace Huylebron . Core . domain . Content ;

public class Post
{
    public Guid Id { get ; set ; }
    public required string Name { get ; set ; }
    public required string Slug { get ; set ; }
    public required string Description { get ; set ; }
    public Guid CategoryId { get ; set ; }
    public string ? Thumbnail { get ; set ; }
    public string ? Content { get ; set ; }
    public string ? Author { get ; set ; }
    public Guid AuthorUserId { get ; set ; }
    public string ? Source { get ; set ; }
    public string ? Tags { get ; set ; }
    public string ? SeoDescription { get ; set ; }
    public int viewCount { get ; set ; }
    public DateTime DateCreated { get ; set ; }
    public DateTime ? DateModified { get ; set ; }
    public bool IsPaid { get ; set ; }
    public double RoyaltyAmount { get ; set ; }
    public PostStatus Status { get ; set ; }
}

public enum PostStatus
{
    draft = 1,
    Cancelled = 2,
    WaitingForApproval = 3,
    rejected = 4,
    WaitingForPublish = 5,
    Published = 6,
    
}