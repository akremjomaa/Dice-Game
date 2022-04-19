using AutoMapper;
using DéApplication.Entities;
using DéApplication.Repositories.Interfaces;
using MediatR;

namespace DéApplication.Features.NumberedFaces.Commands.UpdateNumberedFace
{
    public class UpdateNumberedFaceCommandHandler : IRequestHandler<UpdateNumberedFaceCommand>
    {
        private readonly IRepository<NumberedFace> _numberedFaceRepository;
        private readonly IMapper _mapper;
      
        public UpdateNumberedFaceCommandHandler(IRepository<NumberedFace> numberedFaceRepository, IMapper mapper)
        {
            _numberedFaceRepository = numberedFaceRepository;
            _mapper = mapper;

        }

        public async Task<Unit> Handle(UpdateNumberedFaceCommand request, CancellationToken cancellationToken)
        {
            var numberedFaceToUpdate = await _numberedFaceRepository.GetByIdAsync(request.NumberedFaceId);
            _mapper.Map(request, numberedFaceToUpdate, typeof(UpdateNumberedFaceCommand), typeof(NumberedFace));
            await _numberedFaceRepository.UpdateAsync(numberedFaceToUpdate, cancellationToken);
            return Unit.Value;
        }
    }
}
