namespace DéApplication.Models
{
    public class NumberedFaceDto
    {

        public NumberedFaceDto(int id,int faceNumber)
        {
          NumberedFaceId = id;
            FaceNumber = faceNumber;

        }
        public int NumberedFaceId { get; set; }
        public int FaceNumber { get; set; }
    }
}
