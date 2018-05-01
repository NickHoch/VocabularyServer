using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using BLL.DTOs;
using DAL;

namespace BLL.Mapping
{
    public static class MappingCredential
    {
        public static Credential MappingDTOtoModel(CredentialDTO credentialDTO)
        {
            MapperConfiguration configDTOtoModel = new MapperConfiguration(cfg => {
                cfg.CreateMap<CredentialDTO, Credential>();
            });
            IMapper iMapper = configDTOtoModel.CreateMapper();
            return iMapper.Map<CredentialDTO, Credential>(credentialDTO);
        }
    }
}
