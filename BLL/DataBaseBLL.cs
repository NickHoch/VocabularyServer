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
        public bool IsEmailAddressExists(string email)
        {
            return _dal.IsEmailAddressExists(email);
        }
        public bool IsDictionaryNameExists(string dictionaryName, int userId)
        {
            return _dal.IsDictionaryNameExists(dictionaryName, userId);
        }
        public int? GetUserIdByCredential(CredentialDTO credentialDTO)
        {
            var credential = MappingCredential.MappingDTOtoDM(credentialDTO);
            return _dal.GetUserIdByCredential(credential);
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
        public bool AddWord(WordDTO wordDTO, int dictionaryId)
        {
            var word = MappingWord.MappingDTOtoDM(wordDTO);
            word.Dictionary = _dal.GetDictionary(dictionaryId);
            return _dal.AddWord(word);
        }
        public bool DeleteWord(int wordId)
        {
            return _dal.DeleteWord(wordId);
        }
        public void UpdateWord(WordDTO wordDTO)
        {
            var word = MappingWord.MappingDTOtoDM(wordDTO);
            _dal.UpdateWord(word);
        }
        public List<WordDTO> GetWords(int dictionaryId)
        {
            List<WordDTO> listWordsDTO = new List<WordDTO>();
            var listWords = _dal.GetWords(dictionaryId);
            listWords.ForEach(x => listWordsDTO.Add(MappingWord.MappingDMtoDTO(x)));
            return listWordsDTO;
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
        public bool AddDictionary(DictionaryDTO dictionaryDTO, int userId)
        {
            var dictionary = MappingDictionary.MappingDTOtoDM(dictionaryDTO);
            dictionary.Credential = _dal.GetCredentialById(userId);
            return _dal.AddDictionary(dictionary);
        }
        public bool DeleteDictionary(int dictionaryId)
        {
            return _dal.DeleteDictionary(dictionaryId);
        }
        public List<DictionaryDTO> GetDictionariesNameAndId(int userId)
        {
            List<DictionaryDTO> listDictionariesDTO = new List<DictionaryDTO>();
            var listDictionaries = _dal.GetDictionariesNameAndId(userId);
            listDictionaries.ForEach(x => listDictionariesDTO.Add(MappingDictionary.MappingDMtoDTO(x)));
            return listDictionariesDTO;
        }
        //public DictionaryDTO GetDictionary(int dictionaryId)
        //{
        //    var dictionary = _dal.GetDictionary(dictionaryId);
        //    return MappingDictionary.MappingDMtoDTO(dictionary);
        //}
    }
}