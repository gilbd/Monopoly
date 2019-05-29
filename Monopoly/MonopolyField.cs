using Monopoly.Cards;
using Monopoly.Properties;

namespace Monopoly
{
    public class MonopolyField
    {
        public Card[] Cards { get; set; }

        public MonopolyField(SetsDb gameSets)
        {
            Cards = new Card[Settings.Default.FieldSize];
            gameSets.InitializeAtField(Cards);
        }
    }
}