﻿using AutoMapper;
using BLL.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF.DCs;

namespace WCF.Mapping
{
    public static class MappingDictionary
    {
        public static DictionaryDTO MappingDCtoDTO(DictionaryDC dictionaryDC)
        {
            MapperConfiguration configDCtoDTO = new MapperConfiguration(cfg => {
                cfg.CreateMap<DictionaryDC, DictionaryDTO>();
            });
            IMapper iMapper = configDCtoDTO.CreateMapper();
            return iMapper.Map<DictionaryDC, DictionaryDTO>(dictionaryDC);
        }
    }
}