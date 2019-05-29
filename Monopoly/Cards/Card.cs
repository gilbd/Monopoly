namespace Monopoly.Cards
{
    public class Card
    {
        public string SetName { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public string Owner { get; set; } = null;
        public int[] Fees { get; set; }
        public CardState State { get; set; } = 0;
        public int FeeToPay => Fees[(int) State];
        public uint SetSize { get; set; }

        public Card(string setName, string name, int price, int[] fees, uint setSize)
        {
            SetName = setName;
            Name = name;
            Price = price;
            Fees = fees;
            SetSize = setSize;
        }
    }
}