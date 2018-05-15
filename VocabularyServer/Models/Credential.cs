using DAL.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DAL
{
    public class Credential
    {
        public int Id { get; set; }
        [StringLength(50)]
        public string Email { get; set; }
        [Required, StringLength(20)]
        public string Password { get; set; }
        public virtual ICollection<DictionaryExtn> Dictionaries { get; set; }
    }
}