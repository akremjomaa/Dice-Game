namespace DéApplication.Entities
{
    public class PicturedDiePictuedFace
    {
        public int Id { get; set; }
        public int DieId { get; set; }
        public PicturedDie PicturedDie { get; set; }
        public int PicturedFaceId { get; set; }
        public PicturedFace PicturedFace { get; set; }
    }
}
