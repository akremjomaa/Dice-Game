namespace DéApplication.Entities
{
    public class PicturedDie : Die
    {
        public PicturedDie(string title) : base(title)
        {
            Title = title;
           
        }
       
     

        private readonly List<PicturedDiePictuedFace> _picturedDiePictuedFaces = new List<PicturedDiePictuedFace>();
        public virtual IEnumerable<PicturedDiePictuedFace> PicturedDiePictuedFaces => _picturedDiePictuedFaces.AsReadOnly();
        public void AddPicturedDiePicturedFaces(List<PicturedDiePictuedFace> picturedDiePictuedFaces)
        {
            _picturedDiePictuedFaces.AddRange(picturedDiePictuedFaces);
        
        }
    
}
}
