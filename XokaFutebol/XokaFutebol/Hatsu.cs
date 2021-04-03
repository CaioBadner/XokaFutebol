using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XokaFutebol
{
    static class Hatsu
    {
        public const string message = "Don't you think that football is one of the greatest languages?\n" +
            "Because once you kick a ball, you can communicate with anybody, anywhere in the world! :-)";

        

        public static readonly string[] matchTypes = { "Friendly", "Cup", "League" };

        public static readonly string[] matchStats = { "Position", "Rating", "Condition", "Goals", "Assists", 
            "ShotsOnGoal", "Shots", "PassesCompleted", "PassesAttempted", "Tackles", "Fouls", "Offsides",
            "YellowCards", "RedCards"};

        public static readonly string[] matchStatsNames = { "Position", "Rating", "Condition", "Goals", "Assists",
            "Shots On Goal", "Shots", "Passes Completed", "Passes Attempted", "Tackles", "Fouls", "Offsides",
            "Yellow Cards", "Red Cards"};

        public static int getRandomNum(int num)
        {
            Random oracle = new Random();
            return oracle.Next(num);
        }

        public static int getRandomNum(int min, int max)
        {
            Random oracle = new Random(); 
            return oracle.Next(min,max);
        }

        public static int[] getRandomEleven(int rosterSize)
        {
            Random oracle = new Random();
            int[] winningEleven = new int[11];
            //first we get a goalie
            winningEleven[0] = oracle.Next(3);
            int next;
            for (int i = 1; i < 11; i++)
            {
                do {
                    //here we ask for a field player (starting from pos 3)
                    next = oracle.Next(3, rosterSize);
                } while (winningEleven.Contains(next));
                winningEleven[i] = next;
            }
            return winningEleven;
        }

        public static string getRandomName()
        {
            Random oracle = new Random();
            int rndName = oracle.Next(10);
            switch (rndName)
            {
                case 0: return "Abdulla Fonseca";
                case 1: return "Bambi Cogur";
                case 2: return "Todibo Dipens";
                case 3: return "Pato Oliveira";
                case 4: return "Hugo Eron Guardner";
                case 5: return "El Chuba Debo";
                case 6: return "Juca Trapaça";
                case 7: return "Kal Mokomoka";
                case 8: return "Tou Tiespe";
                default: return "Vid Covid";
            }
        }

        public static string getGoalType(int press)
        {
            Random oracle = new Random();
            int type = oracle.Next(20);
            int comment = oracle.Next(1, 4);
            string narration;
            if (press < 50)
            {
                narration = "(Do meio da rua!!!";
                if (comment == 1) narration += " Puta que o pariu bateman!)";
                else if (comment == 2) narration += " Como é que pode ser verdade uma porra dessas?)";
                else if (comment == 3) narration += " Antologicol!)";
                return narration;
            }
            if (press >= 50 && press < 75)
            {
                if (type == 1 || type == 2) narration = "(De Falta!";
                else narration = "(De fora da área!";
                if (comment == 1) narration += " Na gaveta!)";
                else if (comment == 2) narration += " Forte Bomba!)";
                else if (comment == 3) narration += " Que curva!)";
                return narration;
            }
            if (press >= 75 && press < 90)
            {
                if (type % 6 == 0) return "(De Penalty)";
                narration = "(";
                if (comment == 1) narration += "Forte Bomba!)";
                else if (comment == 2) narration += "Chute colocado!)";
                else if (comment == 3) narration += "Cabeçada!)";
                return narration;
            }
            if (press >= 90 && press < 96)
            {
                narration = "(Golaço!";
                if (comment == 1) narration += " Driblou o goleiro!)";
                else if (comment == 2) narration += " Voleio!)";
                else if (comment == 3) narration += " Cobertura!)";
                return narration;
            }
            if (press == 96)
                return "(Bicicleta!!)";
            if (press == 97)
                return "(Gol de mão!!)";
            if (press == 98)
                return "(Carretilha no goleiro!!)";
            if (press == 99)
                return "(Olímpico!!)";
            return "";
        }

        public static string kickPenalty()
        {
            Random oracle = new Random();
            int shot = oracle.Next(1, 22);
            int defense = oracle.Next(4, 19);
            if (shot < 3 || shot > 19) return "Pra fora!";
            if (defense == shot || defense == shot - 1 || defense == shot + 1)
                return "Defendeu goleiro!";
            return "Gol!";
        }

        public static Obj.Player getGoalScorer(IList<Obj.Player> squad)
        {
            Random oracle = new Random();
            int[] whoScored = new int[3];
            for (int w = 0; w < whoScored.Length; w++)
                whoScored[w] = oracle.Next(11);
            int chosen = whoScored.Max();
            Obj.Player player = squad[chosen];
            //string goalScorer = player.nickname;
            return player;
        }

        
    }
}
