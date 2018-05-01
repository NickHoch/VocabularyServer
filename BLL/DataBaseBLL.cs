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
        public int? CheckCredential(CredentialDTO credentialDTO)
        {
            var credential = MappingCredential.MappingDTOtoDM(credentialDTO);
            return _dal.GetUserIdByCredential(credential);
        }
        public bool IsEmailAddressFree(string email)
        {
            return _dal.IsEmailAddressFree(email);
        }
        public bool AddCredential(CredentialDTO credentialDTO)
        {
            var credential = MappingCredential.MappingDTOtoDM(credentialDTO);
            return _dal.AddCredential(credential);
        }
    }
}