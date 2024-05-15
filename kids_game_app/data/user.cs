using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace kids_game_app.data
{
    [Table("users")]
    internal class user
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string UserName { get; set; }
        public int ScoreValue { get; set; }
        [Required]
        public string Name { get; set; }
    }
}
