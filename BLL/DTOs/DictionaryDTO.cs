﻿using System;
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
        public string Name { get; set; }
        public CredentialDTO Credential { get; set; }
        public List<WordDTO> Words { get; set; }
    }
}