﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WCF.DCs
{
    [DataContract]
    public class DictionaryDC
    {
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public CredentialDC Credential { get; set; }
        [DataMember]
        public ICollection<WordDC> Words { get; set; }
    }
}