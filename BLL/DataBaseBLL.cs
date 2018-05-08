using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using BLL.DTOs;
using BLL.Mapping;

namespace BLL
{
    public class DataBaseBLL
    {
        DataBaseDAL _dal = new DataBaseDAL();
        public int? GetUserIdByCredential(CredentialDTO credentialDTO)
        {
            var credential = MappingCredential.MappingDTOtoDM(credentialDTO);
            return _dal.GetUserIdByCredential(credential);
        }
        public bool IsEmailAddressFree(string email)
        {
            return _dal.IsEmailAddressFree(email);
        }
        public bool AddUser(CredentialDTO credentialDTO)
        {
            bool resAddUser = false;
            var credential = MappingCredential.MappingDTOtoDM(credentialDTO);
            var resAddCred = _dal.AddCredential(credential);
            if(resAddCred)
            {
                Dictionary dictionary = new Dictionary
                {
                    Name = "Animals",
                    Credential = credential
                };
                var resAddDict = _dal.AddDictionary(dictionary);
                if(resAddDict)
                {
                    resAddUser = _dal.StartInitializeDctionary(dictionary);
                }
            }
            return resAddUser;
        }
        public bool AddDictionary(DictionaryDTO dictionaryDTO)
        {
            var dictionary = MappingDictionary.MappingDTOtoDM(dictionaryDTO);
            return _dal.AddDictionary(dictionary);
        }
    }
}