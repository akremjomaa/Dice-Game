namespace DéApplication.Models
{
    public class PicturedDiePictuedFaceDto
    {
        public int Id { get; set; }
        public int DieId { get; set; }
        public int PicturedFaceId { get; set; }

        public PicturedDiePictuedFaceDto(int id, int dieId, int picturedFaceId)
        {
            Id = id;
            DieId = dieId;
            PicturedFaceId = picturedFaceId;
        }
    }
}
