using DéApplication.Entities;
using DéApplication.Repositories.Interfaces;
using MediatR;

namespace DéApplication.Features.ColoredDies.Commands.DeleteColoredDie
{
    public class DeleteColoredDieCommandHandler : IRequestHandler<DeleteColoredDieCommand>
    {
        private readonly IRepository<ColoredDie> _coloredDieRepository;
        public DeleteColoredDieCommandHandler(IRepository<ColoredDie> coloredDieRepository)
        {

        }

        public async Task<Unit> Handle(DeleteColoredDieCommand request, CancellationToken cancellationToken)
        {
            var coloredDieToDelete = await _coloredDieRepository.GetByIdAsync(request.DieId);
            await _coloredDieRepository.DeleteAsync(coloredDieToDelete);
            return Unit.Value;
        }
    }
}
