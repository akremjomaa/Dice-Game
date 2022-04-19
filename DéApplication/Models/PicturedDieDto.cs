using DéApplication.Entities;

namespace DéApplication.Models
{
    public class PicturedDieDto
    {
        public PicturedDieDto(int id ,string title)
        {
            PicturedDieId = id;
            Title = title;

        }
        public int PicturedDieId { get; set; }
        public string Title { get; set; }
        public List<PicturedDiePictuedFace> picturedDiePictuedFaces { get; set; }

    }
}
