namespace DéApplication.Models
{
    public class ColoredFaceDto
    {
        public ColoredFaceDto(int id, string color)
        {
            ColoredFaceId = id;
            Color = color;
        }
        public int ColoredFaceId { get; set; }
        public string Color { get; set; }
    }
}
