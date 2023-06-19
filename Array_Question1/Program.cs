/*1. CDAC Kochi/Tri has certain number of batches. each batch has certain number of students.
        accept number of batches. for each batch accept number of students.
        create an array to store mark for each student (1 student has only 1 subject mark)
        accept the marks.
        display the marks.*/

namespace Array_Question1
{
    internal class Program
    {
       
        static void Main()
        {
            Console.WriteLine("Enter the number of batches: ");
            int noOfBatches = Convert.ToInt32(Console.ReadLine());
            
            int[][] arr = new int[noOfBatches][];

            for(int i = 0; i < noOfBatches; i++)
            {
                Console.WriteLine($"Enter number of students in batch{i+1}: ");
                int numOfStudents = Convert.ToInt32(Console.ReadLine());

                arr[i] = new int[numOfStudents];

                for(int j = 0; j < numOfStudents; j++)
                {
                    Console.WriteLine($"Enter marks for student{j+1} in batch{i + 1}: ");
                    arr[i][j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine();

            for(int i = 0; i < noOfBatches; i++)
            {
                Console.WriteLine($"batch{i}: ");
                for (int j = 0; j < arr[i].Length; j++)
                {
                    Console.WriteLine($"Student{j + 1} : {arr[i][j]}");
                }
            }
        }
    }
}