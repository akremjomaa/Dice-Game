using DéApplication.Entities;

namespace DéApplication.Models
{
    public class NumberedDieDto
    {
        public NumberedDieDto(string title )
        {
            Title = title;

        }
        public string Title { get; set; }
        public List<NumberedDieNumberedFace> numberedDieNumberedFaces { get; set; }
    }
}
