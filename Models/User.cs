using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Sovremennik.Models
{
    /// <summary>
    /// Пользователь
    /// </summary>
    public class User
    {
        /// <summary>
        /// ID пользователя
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Имя пользователя
        /// </summary>
        public string Name { get; set; }
    }
}
