namespace DéApplication.Entities
{
    public abstract class Die
    {
        public Die( string title)
        {
           
          Title = title;
           /* Type = type;*/
         
           

        }

       

        public  int DieId { get; set; }
       public string Title { get; set; }
        public string Type { get; set; }
        public IList<DieGroupOfDice> dieGroupOfDices { get; set; }

       /* public Type GetType();*/
    }
}
