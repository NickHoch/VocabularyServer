using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class DataBaseBLL
    {
        DataBaseDAL _dal = new DataBaseDAL();
        public int? CheckCredential(string login, string password)
        {
            return _dal.GetUserIdByCredential(login, password);
        }
        public bool IsEmailAddressFree(string email)
        {
            return _dal.IsEmailAddressFree(email);
        }
    }
}