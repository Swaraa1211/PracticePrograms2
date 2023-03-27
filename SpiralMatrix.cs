namespace PracticePrograms2
{
    internal class SpiralMatrix
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Number: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[,] matrix = new int[n, n];

            int num = 1;
            int col = 0, col1 = n-1;

            while(n*n >= num)
            {
                for(int i=col; i<= col1; i++)
                {
                    matrix[col, i] = num++;
                }
                for(int j=col+1; j<=col1; j++)
                {
                    matrix[j, col1] = num++;
                }
                for(int i = col1-1; i>=col; i--)
                {
                    matrix[col1,i] = num++;
                }
                for(int j=col1-1; j>=col+1; j--)
                {
                    matrix[j, col] = num++;
                }
                col++;
                col1--;
            }

            for(int i=0; i < n; i++)
            {
                for(int j=0;j<n; j++)
                {
                    Console.Write(matrix[i, j] + "  ");
                }
                Console.WriteLine();
            }

            /*for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(matrix[i, j] + "  ");
                }
            }*/

        }
    }
}