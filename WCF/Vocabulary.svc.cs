using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using BLL;

namespace WCF
{
    public class Vocabulary : IVocabulary
    {
        private DataBaseBLL _bll = new DataBaseBLL();

        public int? CheckCredential(string login, string password)
        {
            return _bll.CheckCredential(login, password);
        }

        public bool IsEmailAddressFree(string email)
        {
            return _bll.IsEmailAddressFree(email);
        }
    }
}