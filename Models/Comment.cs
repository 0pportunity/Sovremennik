namespace Sovremennik.Models
{
    /// <summary>
    /// Комментарий
    /// </summary>
    public class Comment
    {
        public int AuthorId { get; }
        public string Content { get; private set; }

    }
}
