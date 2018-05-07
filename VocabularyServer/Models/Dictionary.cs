using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DAL
{
    public class Dictionary
    {
        public int Id { get; set; }
        [Required, StringLength(20, MinimumLength = 1)]
        public string Name { get; set; }
        public virtual Credential Credential { get; set; }
        public virtual ICollection<Word> Words { get; set; }
    }
}