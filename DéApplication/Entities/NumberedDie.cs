namespace DéApplication.Entities
{
    public class NumberedDie : Die
    {
        public NumberedDie(string title) : base(title)
        {
            Title = title;
          
          
        }
        
        private readonly List<NumberedDieNumberedFace> _numberedDieNumberedFaces = new List<NumberedDieNumberedFace>();
        public virtual IEnumerable<NumberedDieNumberedFace> NumberedDieNumberedFaces => _numberedDieNumberedFaces.AsReadOnly();

        public void AddNumberedDieNumberedFaces(List<NumberedDieNumberedFace> numberedDieNumberedFaces)
        {
            _numberedDieNumberedFaces.AddRange(numberedDieNumberedFaces);
           
        }
    }

}


