using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace Sovremennik.Models
{
    /// <summary>
    /// Тег
    /// </summary>
    public class Tag
    {
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Содержание тега
        /// </summary>
        public string Content { get; set; }

        public int ArticleId { get; set; }      // внешний ключ
        public Article? Article { get; set; }    // навигационное свойство
    }
}
