using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Sovremennik.Models
{
    /// <summary>
    /// Комментарий
    /// </summary>
    public class Comment
    {
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// ID автора комментария
        /// </summary>
        public int AuthorId { get; }

        /// <summary>
        /// Содержание комментария
        /// </summary>
        public string Content { get; private set; }

    }
}
