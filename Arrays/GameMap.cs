using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Arrays
{
    public enum TerrainEnum
    {
        GRASS,
        SAND,
        WATER,
        WALL
    }

    public static class TerrainEnumExtensions
    {
        public static ConsoleColor GetColor(this TerrainEnum terrain)
        {
            switch (terrain)
            {
                case TerrainEnum.GRASS: return ConsoleColor.Green;
                case TerrainEnum.SAND: return ConsoleColor.Yellow;
                case TerrainEnum.WATER: return ConsoleColor.DarkBlue;
                default: return ConsoleColor.DarkGray;
            }
        }
        public static Char GetChar(this TerrainEnum terrain)
        {
            switch (terrain)
            {
                case TerrainEnum.GRASS: return '\u201c';
                case TerrainEnum.SAND: return '\u25cb';
                case TerrainEnum.WATER: return '\u2248';
                default: return '\u25cf';
            }
        }
    }

    public static class GameMap
    {
        public static void RunMap()
        {
            TerrainEnum[,] map ={ { TerrainEnum.SAND, TerrainEnum.SAND, TerrainEnum.SAND, TerrainEnum.SAND, TerrainEnum.GRASS, 
                    TerrainEnum.GRASS, TerrainEnum.GRASS, TerrainEnum.GRASS, TerrainEnum.GRASS, TerrainEnum.GRASS },
                    { TerrainEnum.WATER, TerrainEnum.WATER, TerrainEnum.WATER, TerrainEnum.WATER, TerrainEnum.WATER,
                    TerrainEnum.WATER, TerrainEnum.WATER, TerrainEnum.WALL, TerrainEnum.WATER, TerrainEnum.WATER } };

            Console.OutputEncoding = UTF8Encoding.UTF8;

            for (int row = 0; row < map.GetLength(0); row++)
            {
                for (int column = 0; column < map.GetLength(1); column++)
                {
                    Console.ForegroundColor = map[row, column].GetColor();
                    Console.Write(map[row, column].GetChar() + " ");
                }
                Console.WriteLine();
            }

            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }

}
