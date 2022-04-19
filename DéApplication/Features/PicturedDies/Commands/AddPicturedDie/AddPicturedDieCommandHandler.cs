using AutoMapper;
using DéApplication.Entities;
using DéApplication.Repositories.Interfaces;
using MediatR;

namespace DéApplication.Features.PicturedDies.Commands.AddPicturedDie
{
    public class AddPicturedDieCommandHandler : IRequestHandler<AddPicturedDieCommand, int>
    {
        private readonly IRepository<PicturedDie> _picturedDieRepository;
        private readonly IMapper _mapper;
        public AddPicturedDieCommandHandler(IRepository<PicturedDie> picturedDieRepository, IMapper mapper)
        {
            _picturedDieRepository = picturedDieRepository;
            _mapper = mapper;

        }

        public async Task<int> Handle(AddPicturedDieCommand request, CancellationToken cancellationToken)
        {
            var picturedDie = _mapper.Map<PicturedDie>(request);
            picturedDie = await _picturedDieRepository.AddAsync(picturedDie);
            return picturedDie.DieId;
        }
    }
}
