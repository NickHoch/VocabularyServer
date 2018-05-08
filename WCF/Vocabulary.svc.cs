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
        public int? GetUserIdByCredential(CredentialDC credentialDC)
        {
            try
            {
                var credentialDTO = MappingCredential.MappingDCtoDTO(credentialDC);
                return _bll.GetUserIdByCredential(credentialDTO);
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
        public bool AddUser(CredentialDC credentialDC)
        {
            try
            {
                var credentialDTO = MappingCredential.MappingDCtoDTO(credentialDC);
                return _bll.AddUser(credentialDTO);
            }
            catch(Exception ex)
            {
                throw new FaultException(ex.Message);
            }
        }
        public bool AddDictionary(DictionaryDC dictionaryDC)
        {
            try
            {
                var dictionaryDTO = MappingDictionary.MappingDCtoDTO(dictionaryDC);
                return _bll.AddDictionary(dictionaryDTO);
            }
            catch(Exception ex)
            {
                throw new FaultException(ex.Message);
            }
        }
    }
}