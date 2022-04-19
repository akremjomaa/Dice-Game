using AutoMapper;
using DéApplication.Entities;
using DéApplication.Features.PicturedFaces.Commands.AddPicturedFace;
using DéApplication.Features.PicturedFaces.Commands.UpdatePicturedFace;
using DéApplication.Models;

namespace DéApplication.Profiles
{
    public class PicturedFaceMapper : Profile
    {
        public PicturedFaceMapper()
        {
            CreateMap<AddPicturedFaceCommand, PicturedFace>();
            CreateMap<UpdatePicturedFaceCommand, PicturedFace>();
            CreateMap<PicturedFace, PicturedFaceDto>().ConstructUsing(s => new PicturedFaceDto(s.PicturedFaceId, s.Picture));
        }
    }
}
