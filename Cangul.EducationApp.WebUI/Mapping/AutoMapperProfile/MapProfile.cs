using AutoMapper;
using Cangul.EducationApp.DTO.Test;
using Cangul.EducationApp.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cangul.EducationApp.WebUI.Mapping.AutoMapperProfile
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            #region Test-TestList
            CreateMap<TestListDto, Test>().ReverseMap();
            CreateMap<TestUpdateDto, Test>().ReverseMap();
            #endregion

        }
    }
}
