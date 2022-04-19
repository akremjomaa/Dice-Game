using AutoMapper;
using DéApplication.Entities;
using DéApplication.Features.ColoredFaces.Commands.AddColoredFace;
using DéApplication.Features.ColoredFaces.Commands.UpdateColoredFace;
using DéApplication.Models;

namespace DéApplication.Profiles
{
    public class ColoredFaceMapper:Profile
    {
        public ColoredFaceMapper()
        {
            CreateMap<AddColoredFaceCommand, ColoredFace>();
            CreateMap<UpdateColoredFaceCommand, ColoredFace>();
            CreateMap<ColoredFace, ColoredFaceDto>().ConstructUsing(s=> new ColoredFaceDto(s.ColoredFaceId,s.Color));
        }
    }
}
