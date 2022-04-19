using AutoMapper;
using DéApplication.Entities;
using DéApplication.Repositories.Interfaces;
using MediatR;

namespace DéApplication.Features.NumberedDies.Commands.AddNumberedDie
{
    public class AddNumberedDieCommandHandler : IRequestHandler<AddNumberedDieCommand, int>
    {
        private readonly IRepository<NumberedDie> _numberedDieRepository;
        private readonly IMapper _mapper;
        public AddNumberedDieCommandHandler(IRepository<NumberedDie> numberedDieRepository, IMapper mapper)
        {
            _numberedDieRepository = numberedDieRepository;
            _mapper = mapper;

        }

        public async Task<int> Handle(AddNumberedDieCommand request, CancellationToken cancellationToken)
        {
            var numberedDie = _mapper.Map<NumberedDie>(request);
            numberedDie = await _numberedDieRepository.AddAsync(numberedDie);
            return numberedDie.DieId;
        }
    }
}
