using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DAL
{
    public class Word
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
        public List<Boolean> IsLearned = new List<Boolean>();
        public bool IsLearnedWord { get; set; }
        [Required]
        public virtual Dictionary Dictionary { get; set; }
    }
}