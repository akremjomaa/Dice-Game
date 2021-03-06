
namespace DéApplication.Entities
{
    public class ColoredDie : Die
    {
        public ColoredDie(string title) : base(title)
        {

            Title = title;
          /*  Type = type;*/
           
        }
        private readonly List<ColoredDieColoredFace> _coloredDieColoredFaces = new List<ColoredDieColoredFace>();
        public virtual IEnumerable<ColoredDieColoredFace> ColoredDieColoredFaces => _coloredDieColoredFaces.AsReadOnly();
        
        public void AddColoredDieColoredFaces(List<ColoredDieColoredFace> coloredDieColoredFaces)
        {
            _coloredDieColoredFaces.AddRange(coloredDieColoredFaces);
          
            }
        }

    }

