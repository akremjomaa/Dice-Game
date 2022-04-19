using DéApplication.Entities;
using DéApplication.Repositories.Interfaces;
using MediatR;

namespace DéApplication.Features.PicturedDies.Commands.DeletePicturedDie
{
    public class DeletePicturedDieCommandHandler : IRequestHandler<DeletePicturedDieCommand>
    {
        private readonly IRepository<PicturedDie> _picturedDieRepository;
        public DeletePicturedDieCommandHandler(IRepository<PicturedDie> picturedDieRepository)
        {
            _picturedDieRepository = picturedDieRepository;
        }

        public async Task<Unit> Handle(DeletePicturedDieCommand request, CancellationToken cancellationToken)
        {
            var picturedDieToDelete = await _picturedDieRepository.GetByIdAsync(request.DieId);
            await _picturedDieRepository.DeleteAsync(picturedDieToDelete);
            return Unit.Value;
        }
    }
}
