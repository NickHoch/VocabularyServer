using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class DictionaryExtn : Dictionary
    {
        [Required]
        public virtual Credential Credential { get; set; }
        public virtual ICollection<Word> Words { get; set; }
    }
}