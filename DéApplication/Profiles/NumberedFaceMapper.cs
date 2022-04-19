using AutoMapper;
using DéApplication.Entities;
using DéApplication.Features.NumberedFaces.Commands.AddNumberedFace;
using DéApplication.Features.NumberedFaces.Commands.UpdateNumberedFace;
using DéApplication.Models;

namespace DéApplication.Profiles
{
    public class NumberedFaceMapper : Profile
    {
        public NumberedFaceMapper()
        {
            CreateMap<AddNumberedFaceCommand, NumberedFace>();
            CreateMap<UpdateNumberedFaceCommand, NumberedFace>();
            CreateMap<NumberedFace, NumberedFaceDto>().ConstructUsing(s => new NumberedFaceDto(s.NumberedFaceId, s.FaceNumber));
        }
    }
}
