using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

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
        public string Content { get; private set; }
    }
}
