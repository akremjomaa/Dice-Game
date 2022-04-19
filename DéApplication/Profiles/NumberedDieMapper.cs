using AutoMapper;
using DéApplication.Entities;
using DéApplication.Features.NumberedDies.Commands.AddNumberedDie;
using DéApplication.Features.NumberedDies.Commands.UpdateNumberedDie;
using DéApplication.Models;

namespace DéApplication.Profiles
{
    public class NumberedDieMapper:Profile
    {
        public NumberedDieMapper()
        {
            CreateMap<AddNumberedDieCommand, NumberedDie>();
            CreateMap<UpdateNumberedDieCommand, NumberedDie>();
            CreateMap<NumberedDieNumberedFaceDto, NumberedDieNumberedFace>();
            CreateMap<NumberedDieNumberedFace, NumberedDieNumberedFaceDto>()
            .ConstructUsing(s => new NumberedDieNumberedFaceDto(s.Id, s.DieId, s.NumberedFaceId));
            CreateMap<NumberedDie, NumberedDieDto>().ConstructUsing(s => new NumberedDieDto(s.Title));
        }
    }
}
