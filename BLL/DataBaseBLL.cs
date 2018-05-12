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
                    resAddUser = _dal.StartInitializeDictionary(dictionary);
                }
            }
            return resAddUser;
        }
        public bool AddDictionary(DictionaryDTO dictionaryDTO)
        {
            var dictionary = MappingDictionary.MappingDTOtoDM(dictionaryDTO);
            return _dal.AddDictionary(dictionary);
        }
        public List<DictionaryDTO> GetDictionariesNameAndId(int userId)
        {
            List<DictionaryDTO> listDictionariesDTO = new List<DictionaryDTO>();
            var listDictionaries = _dal.GetDictionariesNameAndId(userId);
            listDictionaries.ForEach(x => listDictionariesDTO.Add(MappingDictionary.MappingDMtoDTO(x)));
            return listDictionariesDTO;
        }
        public List<WordDTO> GetNotLearnedWords(int quantityWords, int dictionaryId)
        {
            List<WordDTO> listWordsDTO = new List<WordDTO>();
            var listWords = _dal.GetNotLearnedWords(quantityWords, dictionaryId);
            listWords.ForEach(x => listWordsDTO.Add(MappingWord.MappingDMtoDTO(x)));
            return listWordsDTO;
        }
        public void SetToWordsStatusAsLearned(int quantityWords, int dictionaryId)
        {
            _dal.SetToWordsStatusAsLearned(quantityWords, dictionaryId);
        }
    }
}