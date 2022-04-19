using AutoMapper;
using DéApplication.Entities;
using DéApplication.Repositories.Interfaces;
using MediatR;

namespace DéApplication.Features.ColoredFaces.Commands.AddColoredFace
{
    public class AddColoredFaceCommandHandler:IRequestHandler<AddColoredFaceCommand,int>
    {
        private readonly IRepository<ColoredFace> _coloredFaceRepository;
        private readonly IMapper _mapper;
        public AddColoredFaceCommandHandler(IMapper mapper, IRepository<ColoredFace> coloredFaceRepository)
        {
            _mapper = mapper;
            _coloredFaceRepository = coloredFaceRepository;

        }

        public async Task<int> Handle(AddColoredFaceCommand request, CancellationToken cancellationToken)
        {
            var coloredFace = _mapper.Map<ColoredFace>(request);
            coloredFace = await _coloredFaceRepository.AddAsync(coloredFace);
            return coloredFace.ColoredFaceId;
        }
    }
}
