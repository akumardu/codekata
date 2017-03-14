using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beginner
{
    class BooleanMatrix
    {
        //http://www.geeksforgeeks.org/a-boolean-matrix-question/
        //Space Complexity: O(nm)
        /*
          public static bool[][] matrix(bool[][] inputMatrix, int rows, int cols)
          {
              bool[][] resultMatrix = new bool[rows][];
              for (int i = 0; i < rows; i++)
                 resultMatrix[i]= new bool[cols];

              // TODO: Scan through the input matrix to find true positions
              for (int i = 0; i < rows; i++)
              {
                  for (int j = 0; j < cols; j++)
                  {
                      if (inputMatrix[i][j] == true)
                      {
                          int posx = i;
                          int posy = j;
                          setPosition(resultMatrix, rows, cols, posx, posy);
                      }
                  }
              }
              return resultMatrix;
          }

          private static void setPosition(bool[][] resultMatrix, int rows, int cols, int posX, int posY)
          {
              // TODO: Set the row and col to true in resultMatrix corresponding to posX and posY
              for(int i = 0; i < rows; i++)
              {
                  resultMatrix[i][posY] = true;
              }
              for (int j = 0; j < cols; j++)
              {
                  resultMatrix[posX][j] = true;
              }
          }
          public static void testMatrix()
          {
              Console.WriteLine("enter the number of rows");
              int rows = int.Parse(Console.ReadLine());
              Console.WriteLine("enter the number of columns");
              int cols = int.Parse(Console.ReadLine());
              bool[][] input = new bool[rows][];
              for (int i = 0; i < rows; i++)
                  input[i] = new bool[cols];
              for (int i = 0; i < rows; i++)
              {
                  for (int j = 0; j < cols; j++)
                  {
                      input[i][j] = false;
                  }
              }
              Console.WriteLine("enter the number of positions to be made true");
              int pos = int.Parse(Console.ReadLine());
              int positionOfXToBeTrue = 0;
              int positioOfYToBeTrue = 0;
              for (int k = 0; k < pos; k++)
              {
                  Console.WriteLine("enter position of x");
                  positionOfXToBeTrue = int.Parse(Console.ReadLine());
                  Console.WriteLine("enter position of y");
                  positioOfYToBeTrue = int.Parse(Console.ReadLine());
                  if (positionOfXToBeTrue < rows && positioOfYToBeTrue < cols)
                  {
                      input[positionOfXToBeTrue][positioOfYToBeTrue] = true;
                  }
                  else
                  {
                      throw new ArgumentException($"{positionOfXToBeTrue} is greater than {rows} or {positioOfYToBeTrue} is greater than {cols}");
                  }
              }
              bool[][] result = matrix(input, rows, cols);
              printMatrix(result, rows, cols);
          }
         */
        public static void printMatrix<T>(T [][] input, int rows, int cols)
        {
            
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(input[i][j] +" ");

                }
                Console.WriteLine();
            }
        }

        // Method 2: Space Complexity is O(n+m)
        public static bool[][] matrixModified(bool[][] input, int rows, int cols)
        {
            bool[] rowsArray = new bool[rows];
            bool[] columnsArray = new bool[cols];
            for (int i = 0; i < rows; i++)
                rowsArray[i] = false;
            for (int j = 0; j < cols; j++)
                columnsArray[j] = false;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (input[i][j] == true)
                    {
                        rowsArray[i] = true;
                        columnsArray[j] = true;
                    }
                }
            }
            for (int i = 0; i < rows; i++)
            {
                if(rowsArray[i]==true)
                {
                    for (int j = 0; j < cols; j++)
                        input[i][j] = true;
                }
            }
            for (int i = 0; i < cols; i++)
            {
                if (columnsArray[i] == true)
                {
                    for (int j = 0; j < rows; j++)
                        input[j][i] = true;
                }
            }
            return input; 
        }
        public static void testMatrixModified()
        {
            Console.WriteLine("enter the number of rows");
            int rows = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the number of columns");
            int cols = int.Parse(Console.ReadLine());
            bool[][] input = new bool[rows][];
            for (int i = 0; i < rows; i++)
                input[i] = new bool[cols];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    input[i][j] = false;
                }
            }
            Console.WriteLine("enter the number of positions to be made true");
            int pos = int.Parse(Console.ReadLine());
            int positionOfXToBeTrue = 0;
            int positioOfYToBeTrue = 0;
            for (int k = 0; k < pos; k++)
            {
                Console.WriteLine("enter position of x");
                positionOfXToBeTrue = int.Parse(Console.ReadLine());
                Console.WriteLine("enter position of y");
                positioOfYToBeTrue = int.Parse(Console.ReadLine());
                if (positionOfXToBeTrue < rows && positioOfYToBeTrue < cols)
                {
                    input[positionOfXToBeTrue][positioOfYToBeTrue] = true;
                }
                else
                {
                    throw new ArgumentException($"{positionOfXToBeTrue} is greater than {rows} or {positioOfYToBeTrue} is greater than {cols}");
                }
            }
            bool[][] result = matrixModified(input, rows, cols);
            printMatrix(result, rows, cols);
        }
    }
}
