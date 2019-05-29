using System;
using System.Collections.Generic;
using Monopoly.Properties;

namespace Monopoly.Cards
{
    public class SetsDb
    {
        public Dictionary<int, Card> CardsPositions { get; set; }

        public SetsDb(IEnumerable<KeyValuePair<int[], Card[]>> setsAndPositions)
        {
            CardsPositions = new Dictionary<int, Card>();
            foreach (var setAndPosition in setsAndPositions)
            {
                for (var i = 0; i < setAndPosition.Key.Length; i++)
                {
                    CardsPositions[setAndPosition.Key[i]] = setAndPosition.Value[i];
                }
            }
        }
        public void InitializeAtField(Card[] cards)
        {
            foreach (var cardsPosition in CardsPositions.Keys)
            {
                #region validation
                if (cardsPosition >= cards.Length)
                {
                    throw new ArgumentOutOfRangeException(
                        String.Format(Settings.Default.OutOfRangeMessage,
                            Environment.NewLine,
                            cardsPosition,
                            cards.Length)
                    );
                }
                if (cards[cardsPosition] != null)
                {
                    throw new ArgumentException(
                        String.Format(Settings.Default.ReassignmentMessage,
                            CardsPositions[cardsPosition].Name,
                            cardsPosition,
                            cards[cardsPosition].Name)
                    );
                }
                #endregion
                cards[cardsPosition] = CardsPositions[cardsPosition];
            }
        }
    }

}