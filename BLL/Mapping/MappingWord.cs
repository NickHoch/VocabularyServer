﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using BLL.DTOs;
using DAL;

namespace BLL.Mapping
{
    public class MappingWord
    {
        public static WordDTO MappingDMtoDTO(Word word)
        {
            MapperConfiguration configDMtoDTO = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Word, WordDTO>();
            });
            IMapper iMapper = configDMtoDTO.CreateMapper();
            return iMapper.Map<Word, WordDTO>(word);
        }
    }
}
