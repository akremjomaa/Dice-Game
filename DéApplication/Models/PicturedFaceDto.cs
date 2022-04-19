namespace DéApplication.Models
{
    public class PicturedFaceDto
    {
        public PicturedFaceDto(int id , string pictrue)
        {
            PicturedFaceId = id;
            Picture = pictrue;

        }
        public int PicturedFaceId { get; set; }
        public string Picture { get; set; }
    }
}
