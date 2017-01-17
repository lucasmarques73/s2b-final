using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using S2B_Final.Models;


namespace S2B_Final.Mappers
{
    public class AutoMapperConfig
    {
        public static void RegisterMapping()
        {
            Mapper.Initialize(x =>
            {
                x.AddProfile<DominToViewModelMappingProfile>();

                x.AddProfile<ViewModelToDominMappingProfile>();
            });
        }
    }

    public class DominToViewModelMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return "DominToViewModelMappingProfile"; }
        }
        protected override void Configure()
        {
            Mapper.CreateMap<DenunciaModel, DenunciaCreateViewModel>();
            Mapper.CreateMap<DenunciaModel, DenunciaEditViewModel>();
            Mapper.CreateMap<DenunciaModel, DenunciaDisplayViewModel>();
            Mapper.CreateMap<DenunciaModel, DenunciaDeleteViewModel>();

            
        }
    }
    public class ViewModelToDominMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return "ViewModelToDominMappingProfile"; }
        }
        protected override void Configure()
        {
            Mapper.CreateMap<DenunciaCreateViewModel, DenunciaModel>();
            Mapper.CreateMap<DenunciaEditViewModel, DenunciaModel>();
            Mapper.CreateMap<DenunciaDisplayViewModel, DenunciaModel>();
            Mapper.CreateMap<DenunciaDeleteViewModel, DenunciaModel>();

        }
    }
}