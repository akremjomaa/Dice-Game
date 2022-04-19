using AutoMapper;
using DéApplication.Entities;
using DéApplication.Features.ColoredDies.Commands.AddColoredDie;
using DéApplication.Features.ColoredDies.Commands.UpdateColoredDie;
using DéApplication.Models;

namespace DéApplication.Profiles
{
    public class ColoredDieMapper : Profile
    {
        public ColoredDieMapper()
        {
            CreateMap<AddColoredDieCommand, ColoredDie>();
            CreateMap<UpdateColoredDieCommand, ColoredDie>();
            CreateMap<ColoredDieColoredFaceDto, ColoredDieColoredFace>();
            CreateMap<ColoredDieColoredFace, ColoredDieColoredFaceDto>()
            .ConstructUsing(s => new ColoredDieColoredFaceDto(s.Id,s.DieId,s.ColoredFaceId));
            CreateMap<ColoredDie, ColoredDieDto>().ConstructUsing(s => new ColoredDieDto(s.DieId,s.Title));
        }
    }
}
