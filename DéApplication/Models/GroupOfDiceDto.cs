using DéApplication.Entities;

namespace DéApplication.Models
{
    public class GroupOfDiceDto
    {
        public GroupOfDiceDto(int id, string title)
        {
            GroupOfDiceId = id;
            Title = title;

        }
        public int GroupOfDiceId { get; set; }
        public string Title { get; set; }
       
    }
}
