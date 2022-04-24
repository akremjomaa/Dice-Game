namespace DéApplication.Models
{
    public class DieGroupOfDiceDto
    {
        public DieGroupOfDiceDto()
        {

        }
        public DieGroupOfDiceDto(int id,int dieId,int groupDiceId)
        {
            Id = id;
            DieId = dieId;
            GroupOfDiceId = groupDiceId;
           

        }
        public int Id { get; set; }
        public int DieId { get; set; }
        public int GroupOfDiceId { get; set; }

    }
}
