using System.ComponentModel.DataAnnotations;

namespace Practice02
{
    internal class Program
    {
        static int GetHighest(int[] scores) //Highest
        {
            int max = 0;
            foreach (int score in scores) {
                if (score > max) { 
                    max = score;
                }
            }
            return max;
        }

        static float GetAverage(int[] scores) //Average
        {
            int sum = 0;

            foreach (int score in scores)
            {
                sum += score;
            }

            if (sum == 0) {
                return 0;
            }
            return sum/scores.Length;
        }

        static int GetIndex(int[] scores, int value) //Finding value
        {
            for (int i = 0; i< scores.Length; i++)
            {
                if (scores[i] == value)
                {
                    return i+1;
                }
            }
            return -1; // Not exist 
        }

        static void Sort(int[] scores) //Sorting
        {
            for(int i = scores.Length -1; i >= 0 ; i--)
            {
                for(int j = 0; j < i; j++)
                {
                    if (scores[j] > scores[j+1]) {
                        int temp = scores[j];
                        scores[j] = scores[j+1];
                        scores[j+1] = temp; 
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            int[] scores = new int[5] {10, 30, 40, 20, 50};
            int highest = GetHighest(scores);
            Console.WriteLine(highest);

            float average = GetAverage(scores);
            Console.WriteLine(average);

            int index = GetIndex(scores, 15);
            Console.WriteLine(index);

            Sort(scores);

            foreach (int i in scores) Console.WriteLine(i);
            
        }
    }
}
