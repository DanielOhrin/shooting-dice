using System;

namespace ShootingDice
{
    // TODO: Complete this class

    // A Player who always rolls in the upper half of their possible role and
    //  who throws an exception when they lose to the other player
    public class SoreLoserUpperHalfPlayer : SoreLoserPlayer
    {
        private int _lowestRoll;
        public SoreLoserUpperHalfPlayer()
        {
            _lowestRoll = DiceSize % 2 == 0 ? DiceSize / 2 : Convert.ToInt32(Math.Ceiling(Convert.ToDecimal(DiceSize) / 2));
        }
        public override int Roll()
        {
            return new Random().Next(_lowestRoll, DiceSize + 1);
        }
    }
}