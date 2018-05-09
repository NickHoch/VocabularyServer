using AutoMapper;
using BLL.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF.DCs;

namespace WCF.Mapping
{
    public class MappingWord
    {
        public static WordDC MappingDTOtoDC(WordDTO wordDTO)
        {
            MapperConfiguration configDTOtoDC = new MapperConfiguration(cfg => {
                cfg.CreateMap<WordDTO, WordDC>();
            });
            IMapper iMapper = configDTOtoDC.CreateMapper();
            return iMapper.Map<WordDTO, WordDC>(wordDTO);
        }
    }
}