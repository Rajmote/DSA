using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Arrays
{
    internal class MultiDimensionalArrays
    {
        public static void MultiDimensionNumberArray()
        {
            //The declaration and initialization of a two-dimensional array with 5 rows and 2 columns:
            int[,] TwoDimension = new int[5, 2];

            //If you want to create a three - dimensional array, the following code can be used:
            int[,,] ThreeDimension = new int[5, 4, 3];

            //Of course, you can also combine a declaration with an initialization, as shown in the  following example:
            int[,] ThreeDimensionnumberArray = new int[,] { { 9, 5, -9 }, { -11, 4, 0 }, { 6, 115, 3 }, { -12, -9, 71 }, { 1, -6, -1 } };

            // Printing multiplication table
            int[,] MutltiplicationTable = new int[10, 10];

            for (int i = 0; i < MutltiplicationTable.GetLength(0); i++)
            {
                for (int j = 0; j < MutltiplicationTable.GetLength(1); j++)
                {
                    MutltiplicationTable[i, j] = (i + 1) * (j + 1);
                }
            }

            for (int i = 0; i < MutltiplicationTable.GetLength(0); i++)
            {
                for (int j = 0; j < MutltiplicationTable.GetLength(1); j++)
                {
                    Console.Write("{0,4}", MutltiplicationTable[i, j]);
                }
                Console.WriteLine();
            }


        }
    }
}
