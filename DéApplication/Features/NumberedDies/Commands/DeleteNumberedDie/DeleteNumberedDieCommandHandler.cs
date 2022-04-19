using DéApplication.Entities;
using DéApplication.Repositories.Interfaces;
using MediatR;

namespace DéApplication.Features.NumberedDies.Commands.DeleteNumberedDie
{
    public class DeleteNumberedDieCommandHandler : IRequestHandler<DeleteNumberedDieCommand>
    {
        private readonly IRepository<NumberedDie> _numberedDieRepository;
        public DeleteNumberedDieCommandHandler(IRepository<NumberedDie> numberedDieRepository)
        {
            _numberedDieRepository = numberedDieRepository;

        }

        public async Task<Unit> Handle(DeleteNumberedDieCommand request, CancellationToken cancellationToken)
        {
            var numeredDieToDelete = await _numberedDieRepository.GetByIdAsync(request.DieId);
            await _numberedDieRepository.DeleteAsync(numeredDieToDelete);
            return Unit.Value;
        }
    }
}
