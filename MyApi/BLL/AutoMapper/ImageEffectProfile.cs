using AutoMapper;
using DAL.Entities;
using Models;

namespace BLL.Automapper;

public sealed class ImageEffectProfile : Profile
{
    public ImageEffectProfile()
    {
        CreateMap<Image, GetImageRequestModel>();
        CreateMap<GetImagesResponseModel, Image>();
        CreateMap<EditImagesRequestModel, Image>();
        CreateMap<Effect, GetEffectRequestModel>();
        CreateMap<GetEffectRequestModel, Effect>();
        CreateMap<EditEffectRequestModel, Effect>();
        CreateMap<Effect,GetEffectRequestModel >();
        CreateMap<Effect,EditEffectRequestModel >();
    }
}
