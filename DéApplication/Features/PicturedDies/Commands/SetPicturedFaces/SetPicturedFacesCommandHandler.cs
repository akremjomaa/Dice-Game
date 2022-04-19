using AutoMapper;
using DéApplication.Entities;
using DéApplication.Features.ColoredDies.Commands.SetColoredFaces;
using DéApplication.Repositories.Interfaces;
using MediatR;

namespace DéApplication.Features.PicturedDies.Commands.SetPicturedFaces
{
    public class SetPicturedFacesCommandHandler : IRequestHandler<SetPicturedFacesCommand>
    {
        private readonly IRepository<PicturedDie> _picturedDieRepository;
        private readonly IMapper _mapper;
        public SetPicturedFacesCommandHandler(IRepository<PicturedDie> picturedDieRepository, IMapper mapper)
        {
            _picturedDieRepository= picturedDieRepository;
            _mapper= mapper;

        }

        public async Task<Unit> Handle(SetPicturedFacesCommand request, CancellationToken cancellationToken)
        {
            if (request.PicturedDiePictuedFaces != null && request.PicturedDiePictuedFaces.Count > 0)
            {
                var picturedFacesToAdd = new List<PicturedDiePictuedFace>();
                var dieToUpdate = await _picturedDieRepository.GetByIdAsync(request.PicturedDiePictuedFaces.FirstOrDefault().DieId);
                foreach (var df in request.PicturedDiePictuedFaces)
                {
                    var diePicturedFace = _mapper.Map<PicturedDiePictuedFace>(df);
                    picturedFacesToAdd.Add(diePicturedFace);
                }
                dieToUpdate.AddPicturedDiePicturedFaces(picturedFacesToAdd);
                await _picturedDieRepository.UpdateAsync(dieToUpdate);
            }
            return Unit.Value;
        }
    }
}
