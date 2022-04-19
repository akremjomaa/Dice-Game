using AutoMapper;
using DéApplication.Entities;
using DéApplication.Repositories.Interfaces;
using MediatR;

namespace DéApplication.Features.ColoredDies.Commands.AddColoredDie
{
    public class AddColoredDieCommandHandler : IRequestHandler<AddColoredDieCommand, int>
    {
        private readonly IRepository<ColoredDie> _coloredDieRepository;
        private readonly IMapper _mapper;
        public AddColoredDieCommandHandler(IRepository<ColoredDie> coloredDieRepository, IMapper mapper)
        {
            _coloredDieRepository = coloredDieRepository;
            _mapper = mapper;

        }

        public async Task<int> Handle(AddColoredDieCommand request, CancellationToken cancellationToken)
        {
            var coloredDie = _mapper.Map<ColoredDie>(request);
            coloredDie = await _coloredDieRepository.AddAsync(coloredDie);
            return coloredDie.DieId;
        }
    }
}
