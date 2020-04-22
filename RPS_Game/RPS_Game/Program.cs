using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace RPS_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Player1 Name: "); //input player's name
            String player1 = Console.ReadLine(); //player1<-read input
            Console.WriteLine("Enter Player2 Name: "); //input player's name
            String player2 = Console.ReadLine(); //player2<-read input
            int p1 = 0; // result for player1 in int
            int p2 = 0; // result for player2 in int
            int ties = 0; // amount of tied rounds
            int round = 0; // number of round
            List<string> resultsList = new List<string>(); // results stored in a list
            string[] rps = { "Rock", "Paper", "Scissor" }; // results in string
            Random rand = new Random(); // generate a random result

            while (true) { // 0 = rock, 1 = paper, 2 = scissor // 
                round++; //increase the round by 1
                int p1rand = rand.Next(3); // for player 1 to get a random result ranging from 0 to 2
                int p2rand = rand.Next(3); // for player 2 to get a random result ranging from 0 to 2

                int win = p1rand - p2rand + 2; // to select a winner the switch statement is being utilized, see possible cases listed down below
                string results = "Round " + round + " - " + player1 + " chose " + rps[p1rand]; // results from player 1
                results +=  ", " + player2 + " chose " + rps[p2rand] + ". - "; // results from player 2
                switch (win){
                    case 0: //p1 rock p2 scissor p1 wins
                        p1++; 
                        break;
                    case 1: // p1 lost since result is negative rock(0) - paper(1) or 1 - 2
                        p2++;
                        break;
                    case 2: // tie
                        ties++;
                        break;
                    case 3:// p1 wins as 1 - 0 or 2 - 1;
                        p1++;
                        break;
                    case 4://p1 scissor p2 rock p2 wins
                        p2++;
                        break;
                    default:
                        break;
                }

                if (win == 2) // tie
                {
                    results += player1  + " and " + player2 + " ties.";
                }
                else if (win == 1 || win == 3) // player1 wins
                {
                    results += player1 + " wins."; 
                }
                else { //player2 wins
                    results += player2 + " wins."; 
                }

                resultsList.Add(results); // store results in a list
                if (p1 > 1 || p2 > 1) {
                    foreach (string element in resultsList){
                        Console.WriteLine(element); 
                    }

                    if (p1 > 1)
                    {
                        Console.WriteLine($"{player1} Wins {p1} - {p2} with {ties} ties."); // print results and message stating player 1 wins
                    }
                    else {
                        Console.WriteLine($"{player2} Wins {p2} - {p1} with {ties} ties."); // print results and message staring player 2 wins
                    }
                    return;
                }
            }
            
        }
    }
}
