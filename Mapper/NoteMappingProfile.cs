using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZadanieWPF.Dto;
using ZadanieWPF.Model;

namespace ZadanieWPF.Mapper
{
    public class NoteMappingProfile : Profile
    {
        public NoteMappingProfile()
        {
            CreateMap<NoteEntity, NoteDto>()
                .IgnoreAllSourcePropertiesWithAnInaccessibleSetter();
        }
    }
}
