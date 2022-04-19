namespace DéApplication.Entities
{
    public class GroupOfDice
    {
        public GroupOfDice(string title )
        {
            Title = title;
            

        }
        public int GroupOfDiceId { get; set; }
        public string Title { get; set; }
        public IList<DieGroupOfDice> dieGroupOfDices { get; set; }
      
    }
}
