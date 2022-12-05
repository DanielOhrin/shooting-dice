using System;

namespace ShootingDice
{
    // TODO: Complete this class

    // A Player whose role will always be in the upper half of their possible rolls
    public class UpperHalfPlayer : Player
    {
        private int _lowestRoll;
        public UpperHalfPlayer()
        {
            _lowestRoll = DiceSize % 2 == 0 ? DiceSize / 2 : Convert.ToInt32(Math.Ceiling(Convert.ToDecimal(DiceSize) / 2));
        }
        public override int Roll()
        {
            return new Random().Next(_lowestRoll, DiceSize + 1);
        }
    }
}