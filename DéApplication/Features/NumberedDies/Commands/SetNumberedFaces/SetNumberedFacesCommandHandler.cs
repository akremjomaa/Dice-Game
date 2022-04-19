using AutoMapper;
using DéApplication.Entities;
using DéApplication.Repositories.Interfaces;
using MediatR;

namespace DéApplication.Features.NumberedDies.Commands.SetNumberedFaces
{
    public class SetNumberedFacesCommandHandler : IRequestHandler<SetNumberedFacesCommand>
    {
        private readonly IRepository<NumberedDie> _numberedDieRepository;
        private readonly IMapper _mapper;
        public SetNumberedFacesCommandHandler(IRepository<NumberedDie> numberedDieRepository, IMapper mapper)
        {
            _numberedDieRepository = numberedDieRepository;
            _mapper = mapper;

        }

        public async Task<Unit> Handle(SetNumberedFacesCommand request, CancellationToken cancellationToken)
        {
            if (request.NumberedDieNumberedFaces != null && request.NumberedDieNumberedFaces.Count > 0)
            {
                var numberedFacesToAdd = new List<NumberedDieNumberedFace>();
                var dieToUpdate = await _numberedDieRepository.GetByIdAsync(request.NumberedDieNumberedFaces.FirstOrDefault().DieId);
                foreach (var df in request.NumberedDieNumberedFaces)
                {
                    var dieNumberedFace = _mapper.Map<NumberedDieNumberedFace>(df);
                    numberedFacesToAdd.Add(dieNumberedFace);
                }
                dieToUpdate.AddNumberedDieNumberedFaces(numberedFacesToAdd);
                await _numberedDieRepository.UpdateAsync(dieToUpdate);
            }
            return Unit.Value;
        }
    }
}
