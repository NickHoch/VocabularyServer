using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using BLL;
using WCF.DCs;
using WCF.Mapping;

namespace WCF
{
    public class Vocabulary : IVocabulary
    {
        private DataBaseBLL _bll = new DataBaseBLL();

        public int? CheckCredential(CredentialDC credentialDC)
        {
            try
            {
                var credentialDTO = MappingCredential.MappingDCtoDTO(credentialDC);
                return _bll.CheckCredential(credentialDTO);
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