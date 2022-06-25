using System;
using System.Collections.Generic;
using System.Linq;

namespace TileMaster
{
    class Program
    {
        static void Main(string[] args)
        {
            var locations = new Dictionary<string, int>()
            {
                {"Sink", 40 },
                {"Oven", 50 },
                {"Countertop", 60 },
                {"Wall", 70 },
            };
            var fittedTiles = new Dictionary<string, int>
            {
                {"Sink", 0 },
                {"Oven", 0 },
                {"Countertop", 0 },
                {"Wall", 0 },
                {"Floor", 0 }
            };
            var whiteTiles = new Stack<int>();
            var greyTiles = new Queue<int>();

            int[] whiteTileAreas = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int[] greyTileAreas = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            FillWhiteStack(whiteTiles, whiteTileAreas);
            FillGreyTiles(greyTiles, greyTileAreas);


            string tilesState = string.Empty;
            while ((tilesState = CheckTilesCount(greyTiles, whiteTiles)) == "has tiles")
            {
                var firstGreyTile = greyTiles.Peek();
                var lastWhiteTile = whiteTiles.Peek();
                bool hasFittedATile = false;

                if (firstGreyTile != lastWhiteTile)
                {
                    greyTiles.Enqueue(greyTiles.Dequeue());
                    whiteTiles.Pop();
                    whiteTiles.Push(lastWhiteTile / 2);
                    continue;
                }

                var newTile = lastWhiteTile + firstGreyTile;

                foreach (var (location, areaRequired) in locations)
                {
                    if (newTile == areaRequired)
                    {
                        greyTiles.Dequeue();
                        whiteTiles.Pop();
                        fittedTiles[location]++;
                        hasFittedATile = true;
                        break;
                    }
                }
                if (hasFittedATile)
                    continue;

                fittedTiles["Floor"]++;
                greyTiles.Dequeue();
                whiteTiles.Pop();

            }

            PrintTiles(greyTiles, whiteTiles, tilesState);
            PrintLocations(fittedTiles);

        }

        public static void FillWhiteStack(Stack<int> whiteTiles, int[] whiteTileAreas)
        {
            for (int i = 0; i < whiteTileAreas.Length; i++)
            {
                whiteTiles.Push(whiteTileAreas[i]);
            }
        }
        public static void FillGreyTiles(Queue<int> greyTiles, int[] greyTileAreas)
        {
            for (int i = 0; i < greyTileAreas.Length; i++)
            {
                greyTiles.Enqueue(greyTileAreas[i]);
            }
        }
        public static string CheckTilesCount(Queue<int> greyTiles, Stack<int> WhiteTiles) 
        {
            if (greyTiles.Count == 0 && WhiteTiles.Count == 0)
            {
                return "both";
            }
            else if (greyTiles.Count == 0)
            {
                return "grey";
            }
            else if(WhiteTiles.Count == 0)
            {
                return "white";
            }

            return "has tiles";
        }
        public static void PrintTiles(Queue<int> greyTiles, Stack<int> WhiteTiles, string tileState)
        {
            if (tileState == "both")
            {
                Console.WriteLine("White tiles left: none");
                Console.WriteLine("Grey tiles left: none");
            }
            else if (tileState == "grey")
            {
                Console.WriteLine($"White tiles left: {string.Join(", ", WhiteTiles)}");
                Console.WriteLine("Grey tiles left: none");
            }
            else if (tileState == "white")
            {
                Console.WriteLine("White tiles left: none");
                Console.WriteLine($"Grey tiles left: {string.Join(", ", greyTiles)}");
            }
        }
        public static void PrintLocations(Dictionary<string, int> fittedTiles)
        {
            fittedTiles = fittedTiles.OrderByDescending(t => t.Value)
                .ThenBy(t => t.Key)
                .ToDictionary(l => l.Key, v => v.Value);
            foreach (var (location, tilesCount) in fittedTiles)
            {
                if(tilesCount > 0)
                Console.WriteLine($"{location}: {tilesCount}");
            }
        }
    }
}

