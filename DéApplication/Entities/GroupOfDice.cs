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

        static void getSampleFace(int dieID)
        {
            var random = new Random();
            //list_of_face_id = getFaces(dieID)
            var list_of_face_id =
              new List<string> { "id_face1", "id_face2", "id_face3", "id_face4" };
            int chosen_index = random.Next(list_of_face_id.Count);
            string chosen_face_id = list_of_face_id[chosen_index];
            // face = getFace(chosen_face_id)
            //return face //return the whole face or just the value, it's up to u (never the faceId alone)
            Console.WriteLine(chosen_face_id);
        }
   /*  public getFaceId(int DieId)
        {


        }*/

    }
}
