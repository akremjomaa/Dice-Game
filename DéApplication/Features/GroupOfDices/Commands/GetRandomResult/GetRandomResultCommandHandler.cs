/*using AutoMapper;
using DéApplication.Entities;
using DéApplication.Models;
using DéApplication.Repositories.Interfaces;
using MediatR;

namespace DéApplication.Features.GroupOfDices.Commands.GetRandomResult
{
    public class GetRandomResultCommandHandler : IRequestHandler<GetRandomResultCommand>
    {
        private readonly IRepository<ColoredDie> _coloredfaceRepository;
        private readonly IRepository<NumberedDie> _numberedFaceRepository;
        private readonly IRepository<PicturedDie> _picturedFaceRepository;
        private readonly IRepository<DieGroupOfDice> _repository;
        private readonly IRepository<Die> _dieRepository;
        private readonly IMapper _mapper;
        public GetRandomResultCommandHandler(IRepository<GroupOfDice> groupOfDiceRepository, IMapper mapper, IRepository<DieGroupOfDice> repository, IRepository<Die> dieRepository)
        {

            _mapper = mapper;
            _repository = repository;
            _dieRepository = dieRepository;
        }
        public async Task<Unit> Handle(GetRandomResultCommand request, CancellationToken cancellationToken)
        {
            *//*  var dicesList = new List<int>();
              var coloredDicesList = new List<int>();
              var groupOfDiceList = await _repository.ListAsync();
              foreach (var dice in groupOfDiceList)
              {

                  if (request.GroupOfDiceId == dice.GroupOfDiceId)
                  {
                      dicesList.Add(dice.DieId);

                  }
              }

              var groupOfDiceChosen = await _groupOfDiceRepository.GetByIdAsync(request.GroupOfDiceId);
              var GroupOfDices = (await _repository.ListAsync()).Where(groupOfDiceChosen.GroupOfDiceId == );
              var DicesList = (await _repository.ListAsync()).Where(groupOfDiceChosen.GroupOfDiceId == GroupOfDices.).ToList();


              foreach (var dice in dicesList)
              {
                  var die = await _dieRepository.GetByIdAsync(dice);
                  if (die.Die_type == dice.GroupOfDiceId)
                  {
                      dicesList.Add(dice.DieId);

                  }

              }

          }*//*
            var id = 1;

            var coloredDie = await _coloredfaceRepository.GetByIdAsync(id);
            var numberedDie = await _numberedFaceRepository.GetByIdAsync(id);
            var picturedDie = await _picturedFaceRepository.GetByIdAsync(id);
        }
    }
}
*/