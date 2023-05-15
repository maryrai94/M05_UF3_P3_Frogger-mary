using System;
using System.Collections.Generic;
using System.Linq;

namespace M05_UF3_P3_Frogger
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            Console.SetWindowSize(Utils.MAP_WIDTH, Utils.MAP_HEIGHT);

            Player player = new Player();
            List<Lane> lanes = GenerateLanes();


            Utils.GAME_STATE gameState = Utils.GAME_STATE.RUNNING;

            while (gameState == Utils.GAME_STATE.RUNNING)
            {
                Vector2Int input = Utils.Input();
                gameState = player.Update(input, lanes);

                Console.Clear();

                foreach (Lane lane in lanes)
                {
                    lane.Update();
                    lane.Draw();
                }

                player.Draw(lanes);

                TimeManager.NextFrame();
            }

            Console.Clear();

            if (gameState == Utils.GAME_STATE.WIN)
            {
                Console.WriteLine("Felicidades!Has Ganado");
            }
            else if (gameState == Utils.GAME_STATE.LOOSE)
            {
                Console.WriteLine("¡Has Perdido!");
            }

            Console.ReadKey();
            static List<Lane> GenerateLanes()
            {
                List<Lane> lanes = new List<Lane>();

           
                return lanes;
            }
        }
    }
}
