using AutoMapper;
using DéApplication.Entities;
using DéApplication.Models;
using DéApplication.Repositories.Interfaces;
using MediatR;

namespace DéApplication.Features.PicturedDies.Queries.GetPicturedDieList
{
    public class GetPicturedDieListQueryHandler : IRequestHandler<GetPicturedDieListQuery, List<PicturedDieDto>>
    {
        private readonly IRepository<PicturedDie> _picturedDieRepository;
        private readonly IMapper _mapper;
        public GetPicturedDieListQueryHandler(IRepository<PicturedDie> picturedDieRepository, IMapper mapper)
        {
            _picturedDieRepository = picturedDieRepository;
            _mapper = mapper;

        }

        public async Task<List<PicturedDieDto>> Handle(GetPicturedDieListQuery request, CancellationToken cancellationToken)
        {
            var picturedDies = (await _picturedDieRepository.ListAsync(cancellationToken)).OrderBy(x => x.DieId);
            return _mapper.Map<List<PicturedDieDto>>(picturedDies);
        }
    }
}
