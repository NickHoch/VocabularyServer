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
    public class MappingWord
    {
        public static WordDTO MappingDMtoDTO(Word word)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Word, WordDTO>().MaxDepth(2);
                cfg.CreateMap<Dictionary, DictionaryDTO>().MaxDepth(2);
            });
            config.AssertConfigurationIsValid();
            var mapper = config.CreateMapper();
            return mapper.Map<Word, WordDTO>(word);
        }
        public static Word MappingDTOtoDM(WordDTO wordDTO)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<WordDTO, Word>().MaxDepth(2);
                cfg.CreateMap<DictionaryDTO, Dictionary>().MaxDepth(2);
            });
            config.AssertConfigurationIsValid();
            var mapper = config.CreateMapper();
            return mapper.Map<WordDTO, Word>(wordDTO);
        }
    }
}
