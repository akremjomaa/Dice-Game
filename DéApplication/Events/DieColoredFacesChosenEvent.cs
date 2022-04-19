using DéApplication.Entities;

namespace DéApplication.Events
{
    public class DieColoredFacesChosenEvent
    {
        public ColoredDie ColoredDie { get; set; }
        public ColoredFace ColoredFaceChosen { get; set; }
        public DieColoredFacesChosenEvent(ColoredDie coloredDie, ColoredFace coloredFace)
        {
            ColoredDie = coloredDie;
            ColoredFaceChosen = coloredFace;

        }
    }
}
