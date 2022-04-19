namespace DéApplication.Models
{
    public class NumberedDieNumberedFaceDto
    {
        public NumberedDieNumberedFaceDto(int id , int dieId , int numberedFaceId)
        {
            Id = id;
            DieId = dieId;
            NumberedFaceId = numberedFaceId;

        }
        public int Id { get; set; }
        public int DieId { get; set; }
        public int NumberedFaceId { get; set; }
    }
}
