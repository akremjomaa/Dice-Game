namespace DéApplication.Models
{
    public class DieGroupOfDiceDto
    {
        public DieGroupOfDiceDto()
        {

        }
        public DieGroupOfDiceDto(int id,int dieId, int groupId)
        {
            Id = id;
            DieId = dieId;
            GroupOfDieId = groupId;



        }
        public int Id { get; set; }
        public int DieId { get; set; }
        public int GroupOfDieId { get; set; }
     
    }
}
