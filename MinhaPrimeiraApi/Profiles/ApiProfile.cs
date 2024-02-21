using AutoMapper;
using MinhaPrimeiraApi.Data.Dtos;
using MinhaPrimeiraApi.Models;

namespace MinhaPrimeiraApi.Profiles
{
    public class ApiProfile : Profile
    {
        public ApiProfile()
        {
            CreateMap<CreateApi, Api>();
            CreateMap<ReadApiDto, Api>();
            CreateMap<UpdateApiDto, Api>();
        }
    }
}
