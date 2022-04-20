namespace DéApplication.Entities
{
    public class DieGroupOfDice
    {
        public int Id { get; set; }
        public int DieId { get; set; }
        public Die Die { get; set; }
        public int GroupOfDiceId { get; set; }
        public GroupOfDice GroupOfDice { get; set; }
    }
}
