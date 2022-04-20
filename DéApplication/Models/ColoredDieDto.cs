using DéApplication.Entities;

namespace DéApplication.Models
{
    public class ColoredDieDto
    {
        public ColoredDieDto(int id,string title)
        {
            ColoredDieId = id;
            Title = title;
        }
        public int ColoredDieId { get; set; }
        public string Title { get; set; }
        public List<ColoredDieColoredFaceDto> coloredDieColoredFaces { get; set; }  
    }
}
