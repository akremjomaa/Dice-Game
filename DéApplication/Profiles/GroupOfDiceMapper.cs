using AutoMapper;
using DéApplication.Entities;
using DéApplication.Features.GroupOfDices.Commands.AddGroupOfDice;
using DéApplication.Features.GroupOfDices.Commands.UpdateGroupOfDice;
using DéApplication.Models;

namespace DéApplication.Profiles
{
    public class GroupOfDiceMapper:Profile
    {
        public GroupOfDiceMapper()
        {
            CreateMap<AddGroupOfDiceCommand, GroupOfDice>();
            CreateMap<UpdateGroupOfDiceCommand, GroupOfDice>();
            CreateMap<DieGroupOfDiceDto, DieGroupOfDice>();
            CreateMap<DieGroupOfDice, DieGroupOfDiceDto>()
            .ConstructUsing(s => new DieGroupOfDiceDto(s.Id, s.DieId,s.GroupOfDiceId));
            CreateMap<GroupOfDice, GroupOfDiceDto>().ConstructUsing(s => new GroupOfDiceDto(s.GroupOfDiceId, s.Title));
        }
    }
}
