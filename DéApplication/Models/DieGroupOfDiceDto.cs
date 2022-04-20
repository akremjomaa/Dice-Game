namespace DéApplication.Models
{
    public class DieGroupOfDiceDto
    {
        public DieGroupOfDiceDto(int id,int dieId)
        {
            Id = id;
            DieId = dieId;
           

        }
        public int Id { get; set; }
        public int DieId { get; set; }
     
    }
}
