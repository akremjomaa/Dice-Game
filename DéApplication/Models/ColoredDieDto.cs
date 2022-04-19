using DéApplication.Entities;

namespace DéApplication.Models
{
    public class ColoredDieDto
    {
        public ColoredDieDto(string title)
        {
            Title = title;
        }

        public string Title { get; set; }
        public List<ColoredDieColoredFace> coloredDieColoredFaces { get; set; }  
    }
}
