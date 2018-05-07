using AutoMapper;
using BLL.DTOs;
using DAL;

namespace BLL.Mapping
{
    public static class MappingDictionary
    {
        public static Dictionary MappingDTOtoDM(DictionaryDTO dictionaryDTO)
        {
            MapperConfiguration configDTOtoDM = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<DictionaryDTO, Dictionary>();
            });
            IMapper iMapper = configDTOtoDM.CreateMapper();
            return iMapper.Map<DictionaryDTO, Dictionary>(dictionaryDTO);
        }
    }
}
