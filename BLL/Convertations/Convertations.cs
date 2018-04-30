using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.DTOs;
using DAL;

namespace BLL.Convertations
{
    public class Convertations
    {
        public CredentialDTO ConvertCredentialModelToDTO(Credential credential)
        {
            return new CredentialDTO
            {
                Id = credential.Id,
                Email = credential.Email,
                Password = credential.Password
            };
        }
    }
}
