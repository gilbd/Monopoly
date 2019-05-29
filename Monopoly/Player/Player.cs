using Monopoly.Properties;

namespace Monopoly
{
    class Player
    {
        public string Name { get; set; }
        public int Balance { get; set; } = Settings.Default.InitialBalance;
        public int Location { get; set; } = 0;
        public PlayingTool Type { get; set; }
        public CardsCollection Collection { get; set; } = new CardsCollection();

        public Player(string name, PlayingTool type)
        {
            Name = name;
            Type = type;
        }
    }
}