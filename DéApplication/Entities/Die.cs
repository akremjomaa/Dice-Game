namespace DéApplication.Entities
{
    public abstract class Die
    {
        public Die( string title)
        {
           
          Title = title;
           

        }
     public  int DieId { get; set; }
       public string Title { get; set; }
        public IList<DieGroupOfDice> dieGroupOfDices { get; set; }


    }
}
