using AutoMapper;
using DéApplication.Entities;
using DéApplication.Models;
using DéApplication.Repositories.Interfaces;
using MediatR;

namespace DéApplication.Features.PicturedDies.Queries.GetPicturedDieDetail
{
    public class GetPicturedDieDetailQueryHandler : IRequestHandler<GetPicturedDieDetailQuery,PicturedDieDto>
    {
        private readonly IRepository<PicturedDie> _picturedDieRepository;
        private readonly IMapper _mapper;
        public GetPicturedDieDetailQueryHandler(IRepository<PicturedDie> picturedDieRepository, IMapper mapper)
        {
            _picturedDieRepository = picturedDieRepository;
            _mapper = mapper;
        }

        public async Task<PicturedDieDto> Handle(GetPicturedDieDetailQuery request, CancellationToken cancellationToken)
        {
            var picturedDie = await _picturedDieRepository.GetByIdAsync(request.DieId);
            var picturedDieDto = _mapper.Map<PicturedDieDto>(picturedDie);
            return picturedDieDto;
        }
    }
}
