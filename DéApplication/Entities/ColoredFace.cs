namespace DéApplication.Entities
{
    public class ColoredFace
    {
        public ColoredFace(string color) 
        {
                Color = color;
        }
        public int ColoredFaceId { get; set; }
        public string Color { get; set; }
        public ICollection<ColoredDieColoredFace> coloredDieColoredFaces { get; set; }=new List<ColoredDieColoredFace>();
    }
}
