using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Sovremennik.Models
{
    /// <summary>
    /// Статья
    /// </summary>
    public class Article
    {
        [Key]
        public int Id { get; set; }

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

        List<Tag> Tags { get; set; } = new List<Tag>();
    }
}
