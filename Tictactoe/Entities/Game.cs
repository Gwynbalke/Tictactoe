using Microsoft.VisualBasic;

namespace Tictactoe.Entities
{
    public class Game
    {
        public int Id { get; set; }
        
        public int PlayerXid { get; set; }
        public int PlayerYid { get; set; }
        public VariantType board { get; set; }
        public int winner { get; set; }
        public DateTime date { get; set; }
        
    }
}
