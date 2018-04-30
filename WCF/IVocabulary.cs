using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF
{
    [ServiceContract]
    public interface IVocabulary
    {
        [OperationContract]
        int? CheckCredential(string login, string password);
        [OperationContract]
        bool IsEmailAddressFree(string email);
    }
}
