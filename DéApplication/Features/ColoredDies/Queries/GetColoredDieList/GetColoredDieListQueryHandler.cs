using AutoMapper;
using DéApplication.Entities;
using DéApplication.Models;
using DéApplication.Repositories.Interfaces;
using MediatR;

namespace DéApplication.Features.ColoredDies.Queries.GetColoredDieList
{
    public class GetColoredDieListQueryHandler : IRequestHandler<GetColoredDieListQuery, List<ColoredDieDto>>
    {
        private readonly IRepository<ColoredDie> _coloredDieRepository;
        private readonly IMapper _mapper;
        public GetColoredDieListQueryHandler(IRepository<ColoredDie> coloredDieRepository, IMapper mapper)
        {
            _mapper = mapper;
            _coloredDieRepository = coloredDieRepository;

        }
        public async Task<List<ColoredDieDto>> Handle(GetColoredDieListQuery request, CancellationToken cancellationToken)
        {
            var coloredDies = (await _coloredDieRepository.ListAsync(cancellationToken)).OrderBy(x => x.DieId);
            return _mapper.Map<List<ColoredDieDto>>(coloredDies);
        }
    }
}
