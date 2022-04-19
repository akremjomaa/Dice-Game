namespace DéApplication.Entities
{
    public class PicturedFace : Face
    {
        public PicturedFace(string picture) 
        {
            Picture = picture;
        }

        public int PicturedFaceId { get; set; }
        public string Picture { get; set; }
        public ICollection<PicturedDiePictuedFace> picturedDiePictuedFaces { get; set; }= new List<PicturedDiePictuedFace>();
    }
}
