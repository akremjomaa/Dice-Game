using DéApplication.Entities;

namespace DéApplication.Models
{
    public class NumberedDieDto
    {
        public NumberedDieDto(int id,string title )
        {
            NumberedDieId = id;
            Title = title;

        }
        public int NumberedDieId { get;set; }
        public string Title { get; set; }
       /* public List<NumberedDieNumberedFace> numberedDieNumberedFaces { get; set; }*/
    }
}
