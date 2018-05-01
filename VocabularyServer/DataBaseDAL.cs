using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DataBaseDAL
    {
        public readonly VocabularyModel _ctx = new VocabularyModel();
        public int? GetUserIdByCredential(Credential credential)
        {
            var cred = _ctx.Credentials.Where(x => x.Email == credential.Email && x.Password == credential.Password)
                                       .SingleOrDefault();
            if(cred != null)
            {
                return cred.Id;
            }
            return null;   
        }
        public bool IsEmailAddressFree(string email)
        {
            return _ctx.Credentials.Any(x => x.Email == email);
        }
        public bool AddCredential(Credential credential)
        {
            int countBefore = _ctx.Credentials.Count();
            _ctx.Credentials.Add(credential);
            _ctx.SaveChanges();
            int countAfter = _ctx.Credentials.Count();
            return countAfter > countBefore;
        }
    }
}
