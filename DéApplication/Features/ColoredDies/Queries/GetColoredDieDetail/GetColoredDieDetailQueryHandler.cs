using AutoMapper;
using DéApplication.Entities;
using DéApplication.Features.ColoredDies.Queries.GetColoredDieList;
using DéApplication.Models;
using DéApplication.Repositories.Interfaces;
using MediatR;

namespace DéApplication.Features.ColoredDies.Queries.GetColoredDieDetail
{
    public class GetColoredDieDetailQueryHandler : IRequestHandler<GetColoredDieDetailQuery, ColoredDieDto>
    {
        private readonly IRepository<ColoredDie> _coloredDieRepository;
        private readonly IMapper _mapper;
        public GetColoredDieDetailQueryHandler(IRepository<ColoredDie> coloredDieRepository, IMapper mapper)
        {
            _mapper = mapper;
            _coloredDieRepository = coloredDieRepository;

        }
        public async Task<ColoredDieDto> Handle(GetColoredDieDetailQuery request, CancellationToken cancellationToken)
        {
            var coloredDie = await _coloredDieRepository.GetByIdAsync(request.DieId);
            var coloredDieDto = _mapper.Map<ColoredDieDto>(coloredDie);
            return coloredDieDto;
        }
    }
}
