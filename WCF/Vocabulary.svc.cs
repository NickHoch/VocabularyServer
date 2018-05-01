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
            try
            {
                return _bll.CheckCredential(login, password);
            }
            catch(Exception ex)
            {
                throw new FaultException(ex.Message);
            }
        }

        public bool IsEmailAddressFree(string email)
        {
            try
            {
                return _bll.IsEmailAddressFree(email);
            }
            catch(Exception ex)
            {
                throw new FaultException(ex.Message);
            }
        }
    }
}