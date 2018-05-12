using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WCF.DCs;

namespace WCF
{
    [ServiceContract]
    public interface IVocabulary
    {
        [OperationContract]
        int? GetUserIdByCredential(CredentialDC credentialDC);
        [OperationContract]
        bool IsEmailAddressFree(string email);
        [OperationContract]
        bool AddUser(CredentialDC credentialDC);
        [OperationContract]
        bool AddDictionary(DictionaryDC dictionaryDC);
        [OperationContract]
        ICollection<DictionaryDC> GetDictionariesNameAndId(int userId);
        [OperationContract]
        ICollection<WordDC> GetNotLearnedWords(int quantityWords, int dictionaryId);
        [OperationContract]
        void SetToWordsStatusAsLearned(int quantityWords, int dictionaryId);
    }
}