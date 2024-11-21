using Microsoft.VisualBasic.Devices;
using Shotgun.NewFolder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Shotgun
{
    
    public class GameLogic
    {
        private GameComputer gamecomputer;
        private Player player;

        public GameLogic(Player player, GameComputer gamecomputer)
        {
            this.player = player;
            this.gamecomputer = gamecomputer;
        }

        public void ResetGame()
        {
            player.PlayerShots = 0;
            gamecomputer.ComputerShots = 0;

        }


        public string PlayerAction(string playerChoice)
        {
            string computerChoice = gamecomputer.ComputerChoise();
            return Round(playerChoice, computerChoice);
        }

        private string Round(string playerChoice, string computerChoice)
        {
            if (playerChoice == "Shotgun" && player.PlayerShots > 2)
            {
                return "Spelare vinner med Shotgun";
            }


            if (playerChoice == "Ladda" && computerChoice == "Ladda")
            {
                player.PlayerShots++;
                gamecomputer.ComputerShots++;
                
                return "Båda spelarna laddade: Spelaren och datorn får ett skott var.";
            }
            if (playerChoice == "Ladda" && computerChoice == "Blocka")
            {
                player.PlayerShots++;
                return "Spelaren laddade, datorn blockerade: Spelaren får ett skott.";
            }
            if (playerChoice == "Blocka" && computerChoice == "Blocka")
            {
                return "Båda blockerade: Ingenting händer.";
            }
            if (playerChoice == "Blocka" && computerChoice == "Ladda")
            {
                gamecomputer.ComputerShots++;
                return "Spelaren Blcokade och datorn laddade, Datorn får +1 skott";
            }
            if (playerChoice == "Blocka" && computerChoice == "Skjuta")
            {
                gamecomputer.ComputerShots--;
                return "Spelaren blockade och datorn sköt, Datorn tappar -1 skott";
            }
            if (playerChoice == "Skjuta" && computerChoice == "Blocka")
            {
                player.PlayerShots--;
                return "Spelaren sköt men datorn blockerade: Spelaren förlorade ett skott.";
            }
            if (playerChoice == "Skjuta" && computerChoice == "Skjuta")
            {
                player.PlayerShots--;
                gamecomputer.ComputerShots--;
                return "Båda spelarna sköt: Varje spelare förlorar ett skott.";
            }
            if (playerChoice == "Skjuta" && computerChoice == "Ladda")
            {
                player.PlayerShots--;
                gamecomputer.ComputerShots++;
                return "Spelaren vinner genom att skjuta medan datorn laddade!";
            }
            if (computerChoice == "Skjuta" && playerChoice == "Ladda")
            {
                gamecomputer.ComputerShots--;
                player.PlayerShots++;
                return "Datorn vinner genom att skjuta medan spelaren laddade!";
            }

            return "Ogiltigt drag eller tillstånd.";
        }
    }
}