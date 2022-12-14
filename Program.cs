using System;
using System.Collections.Generic;
using System.Linq;

namespace ShootingDice
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player1 = new Player();
            player1.Name = "Bob";

            Player player2 = new Player();
            player2.Name = "Sue";

            player2.Play(player1);

            Console.WriteLine("-------------------");

            Player player3 = new Player();
            player3.Name = "Wilma";

            player3.Play(player2);

            Console.WriteLine("-------------------");

            Player large = new LargeDicePlayer();
            large.Name = "Bigun Rollsalot";

            player1.Play(large);

            Console.WriteLine("-------------------");

            SmackTalkingPlayer smackTalker = new SmackTalkingPlayer();
            smackTalker.Name = "Joe Mama";

            smackTalker.Play(player1);

            Console.WriteLine("-------------------");

            OneHigherPlayer oneHigher = new OneHigherPlayer();
            oneHigher.Name = "One Higher";

            oneHigher.Play(smackTalker);

            Console.WriteLine("-------------------");

            HumanPlayer human = new HumanPlayer();
            human.Name = "Daniel";

            human.Play(oneHigher);

            Console.WriteLine("-------------------");

            CreativeSmackTalkingPlayer creativeSTP = new CreativeSmackTalkingPlayer();
            creativeSTP.Name = "Joe Dada";

            creativeSTP.Play(smackTalker);

            Console.WriteLine("-------------------");

            SoreLoserPlayer soreLoser = new SoreLoserPlayer();
            soreLoser.Name = "Sappy";

            soreLoser.Play(player2);

            Console.WriteLine("-------------------");

            UpperHalfPlayer upperHalf = new UpperHalfPlayer();
            upperHalf.Name = "Upppp";

            upperHalf.Play(player3);

            Console.WriteLine("-------------------");

            SoreLoserUpperHalfPlayer soreLoserUHP = new SoreLoserUpperHalfPlayer();
            soreLoserUHP.Name = "Grumpy";

            soreLoserUHP.Play(player1);

            Console.WriteLine("-------------------");

            List<Player> players = new List<Player>() {
                player1,
                player2,
                player3,
                large,
                smackTalker,
                oneHigher,
                human,
                creativeSTP,
                soreLoser,
                upperHalf,
                soreLoserUHP
            };

            PlayMany(players);
        }

        static void PlayMany(List<Player> players)
        {
            Console.WriteLine();
            Console.WriteLine("Let's play a bunch of times, shall we?");

            // We "order" the players by a random number
            // This has the effect of shuffling them randomly
            Random randomNumberGenerator = new Random();
            List<Player> shuffledPlayers = players.OrderBy(p => randomNumberGenerator.Next()).ToList();

            // We are going to match players against each other
            // This means we need an even number of players
            int maxIndex = shuffledPlayers.Count;
            if (maxIndex % 2 != 0)
            {
                maxIndex = maxIndex - 1;
            }

            // Loop over the players 2 at a time
            for (int i = 0; i < maxIndex; i += 2)
            {
                Console.WriteLine("-------------------");

                // Make adjacent players play one another
                Player player1 = shuffledPlayers[i];
                Player player2 = shuffledPlayers[i + 1];
                player1.Play(player2);
            }
        }
    }
}