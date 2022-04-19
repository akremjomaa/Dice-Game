namespace DéApplication.Entities
{
    public class NumberedFace
    {
        public NumberedFace(int faceNumber)
        {
            FaceNumber = faceNumber;
            
        }
        public int NumberedFaceId { get; set; }
        public int FaceNumber { get; set; }
        public ICollection<NumberedDieNumberedFace> numberedDieNumberedFaces { get; set; }= new List<NumberedDieNumberedFace>();
    }
}
