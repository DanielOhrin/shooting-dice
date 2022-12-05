using System;
using System.Collections.Generic;

namespace ShootingDice
{
    // A SmackTalkingPlayer who randomly selects a taunt from a list to say to the other player
    public class CreativeSmackTalkingPlayer : Player
    {
        private List<string> _taunts = new List<string>
        {
            "You're really bad!",
            "My dog rolls higher than you!",
            "Please learn the game.",
            "You're not meant for this game.",
            "I've seen higher rolls in a gym!"
        };
        public override int Roll()
        {
            Console.WriteLine($"Joe Dada: {_taunts[new Random().Next(_taunts.Count)]}");
            return base.Roll();
        }
    }
}