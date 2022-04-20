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
      

        private readonly List<DieGroupOfDice> _dieGroupOdDice = new List<DieGroupOfDice>();
        public virtual IEnumerable<DieGroupOfDice> DieGroupOfDices => _dieGroupOdDice.AsReadOnly();

        public void AddDiceToGroupOfDice(List<DieGroupOfDice> dieGroupOfDices)
        {
            _dieGroupOdDice.AddRange(dieGroupOfDices);

        }

    }
}
