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
        int? CheckCredential(CredentialDC credentialDC);
        [OperationContract]
        bool IsEmailAddressFree(string email);
        //[OperationContract]
        //bool AddCredential(CredentialDC credentialDC);
    }
}
