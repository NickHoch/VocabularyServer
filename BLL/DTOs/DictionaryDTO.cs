using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class DictionaryDTO
    {
        public int Id { get; set; }
        [Required, StringLength(20, MinimumLength = 1)]
        public string Name { get; set; }
        public virtual CredentialDTO Credential { get; set; }
    }
}