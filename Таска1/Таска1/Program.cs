
namespace CheckMatrixNegativeNumber
{
    class ChecksMatrix
    {
        public static void Main()
        {
            int[][] matrix = WriteMatrix();
            List<int> rows = CheckMatrix(matrix);
            Console.WriteLine("Answer");
            foreach (int i in rows)
                Console.WriteLine(i);
        }

        private static int[][] WriteMatrix()
        {
            int count;
            do
            {
                Console.WriteLine("Write size of squared matrix N:\n");
                count = Convert.ToInt32(Console.ReadLine());
            } while (count <3);
            int[][] matrix = new int[count][];
            Console.WriteLine("Enter Elements  of Matrix:");
            for (int i = 0; i < count; i++)
            {
                matrix[i] = new int[count];
                for (int j = 0; j < count; j++)
                {
                    matrix[i][j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            return matrix;
        }

        private static List<int> CheckMatrix(int[][] matrix)
        {
            int count = 0;
            List<int> rows = new List<int>();
            for (int i = 0; i < matrix.Length; i++)
            {
                rows.Add(i+1);
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    if (matrix[i][j] < 0)
                    {
                        count++;
                    }
                    if (count > 2)
                    {
                        rows.Remove(rows.Count - 1);
                        break;
                    }
                }
                //  int[] negativeNumbers = Array.FindAll(matrix[i], element => element < 0);
              //  if (negativeNumbers.Length <= 2)
              //  {
              //      rows.Add(i+1);
              //  }
            }
            return rows;
        }
    }
}




