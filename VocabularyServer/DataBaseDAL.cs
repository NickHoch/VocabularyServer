﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DataBaseDAL
    {
        public readonly VocabularyModel _ctx = new VocabularyModel();
        public int? GetUserIdByCredential(string login, string password)
        {
            var cred = _ctx.Credentials.Where(x => x.Email == login && x.Password == password).SingleOrDefault();
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
    }
}