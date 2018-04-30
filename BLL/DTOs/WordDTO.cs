using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class WordDTO
    {
        public int Id { get; set; }
        [Required, StringLength(20, MinimumLength = 1)]
        public string WordEng { get; set; }
        [Required, StringLength(20, MinimumLength = 1)]
        public string Transcription { get; set; }
        [Required, StringLength(20, MinimumLength = 1)]
        public string Translation { get; set; }
        public byte[] Sound { get; set; }
        public byte[] Image { get; set; }
        public List<Boolean> IsLearned = new List<Boolean>() { false, false, false, false };
        public bool IsLearnedWord { get; set; } = false;
        public virtual DictionaryDTO Dictionary { get; set; }
    }
}