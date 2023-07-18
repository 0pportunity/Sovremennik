namespace Sovremennik.Models
{
    /// <summary>
    /// Статья
    /// </summary>
    public class Article
    {
        /// <summary>
        /// Заголовок
        /// </summary>
        public string Title { get; private set; }

        /// <summary>
        /// Краткое описание
        /// </summary>
        public string Description { get; private set; }

        /// <summary>
        /// ID автора
        /// </summary>
        public int AuthorId { get; }

        /// <summary>
        /// Содержание статьи
        /// </summary>
        public string Content { get; private set; }

        /// <summary>
        /// Конструктор, значения Empty - кроме автор-ID
        /// </summary>
        /// <param name="user"></param>
        public Article(User user) 
        {
            this.AuthorId = user.Id;
            this.Title = string.Empty;
            this.Description = string.Empty;
            this.Content = string.Empty;
        }
    }
}
