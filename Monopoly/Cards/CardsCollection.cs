using System;
using System.Collections.Generic;

namespace Monopoly.Cards
{
    public class CardsCollection
    {
        public List<Card> Collection { get; }
        private readonly List<string> _fullSets;
        private readonly Dictionary<string, uint> _knownSets;

        public CardsCollection()
        {
            Collection = new List<Card>();
            _fullSets = new List<string>();
            _knownSets = new Dictionary<string, uint>();
        }

        public bool IsFullSet(string setName)
        {
            return _fullSets.Contains(setName);
        }

        public void Add(Card card)
        {
            if (_fullSets.Contains(card.SetName))
            {
                throw new ArgumentException("Set is already full!");
            }
            Collection.Add(card);
            if (_knownSets.ContainsKey(card.SetName))
            {
                _knownSets[card.SetName]++;
                if (_knownSets[card.SetName] == card.SetSize)
                {
                    _fullSets.Add(card.SetName);
                }
            }
            else
            {
                _knownSets[card.SetName] = 1;
            }
        }
    }
}