using System;

namespace SpiralArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array = new int[4, 4];

            int row = 0;  // Начальная строка 
            int col = 0;  // Начальный столбец 

            int maxRow = 3; // Максимальное значение строки  
            int maxCol = 3; // Максимальное значение столбца  

            int num = 1; // Номер, который будет записываться  

            while (row <= maxRow && col <= maxCol) {  

                for (int i = col; i <= maxCol; i++) 
                {  
                    array[row, i] = num++;  
                }  

                row++;  

                for (int i = row; i <= maxRow; i++) 
                {  
                    array[i, maxCol] = num++;  
                }  

                maxCol--;  

                for (int i = maxCol; i >= col; i--) 
                {  
                    array[maxRow, i] = num++;  
                }  

                maxRow--;  

                for (int i = maxRow; i >= row; i--) 
                {  
                    array[i, col] = num++;  
                }  

                col++;                              
            }    

            Console.WriteLine("Spiral Array: ");    

            for (int r=0 ; r<4 ; r++)     
            {    

                 for (int c=0 ; c<4 ; c++)     
                 {    

                      Console.Write(array[r,c]+"\t");    

                 }    

                 Console.WriteLine();    

             }         
        }
    }
}