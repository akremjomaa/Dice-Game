using DéApplication.Entities;

namespace DéApplication.Models
{
    public class PicturedDieDto
    {
        public PicturedDieDto(string title)
        {
            Title = title;

        }
        public string Title { get; set; }
        public List<PicturedDiePictuedFace> picturedDiePictuedFaces { get; set; }

    }
}
