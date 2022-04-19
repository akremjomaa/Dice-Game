using AutoMapper;
using DéApplication.Entities;
using DéApplication.Features.PicturedDies.Commands.AddPicturedDie;
using DéApplication.Features.PicturedDies.Commands.UpdatePicturedDie;
using DéApplication.Models;

namespace DéApplication.Profiles
{
    public class PicturedDieMapper : Profile
    {
        public PicturedDieMapper()
        {
            CreateMap<AddPicturedDieCommand, PicturedDie>();
            CreateMap<UpdatePicturedDieCommand, PicturedDie>();
            CreateMap<PicturedDiePictuedFaceDto, PicturedDiePictuedFace>();
            CreateMap<PicturedDiePictuedFace, PicturedDiePictuedFaceDto>()
            .ConstructUsing(s => new PicturedDiePictuedFaceDto(s.Id, s.DieId, s.PicturedFaceId));
            CreateMap<PicturedDie, PicturedDieDto>().ConstructUsing(s => new PicturedDieDto(s.DieId,s.Title));
        }
    }
}
