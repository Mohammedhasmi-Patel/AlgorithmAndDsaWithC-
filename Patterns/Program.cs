namespace DsaWithCSharp.Patterns
{
    internal class Program
    {
        static void PatternOne()
        {
            /*
               * * * * *
               * * * * *
               * * * * *
               * * * * *
               * * * * *
               
            */

            int totalRows,totalCols;

            Console.WriteLine("Please enter total no of rows");
            totalRows = Convert.ToInt32 (Console.ReadLine());

            Console.WriteLine("Please enter total no of cols");
            totalCols = Convert.ToInt32 (Console.ReadLine());

            if(totalCols != totalRows)
            {
                Console.WriteLine("Please enter rows & cols value same");
                return;
            }

            // print the star pattern

            for(int i=0;i<totalRows;i++)
            {
                for(int j = 0; j < totalCols; j++)
                {
                    Console.Write("* ");
                }

                Console.WriteLine();
            }
        }

        static void PatternTwo()
        {
            /*
               1 1 1 1 1
               2 2 2 2 2
               3 3 3 3 3
               4 4 4 4 4
               5 5 5 5 5
               
            */

            int totalRows, totalCols;

            Console.WriteLine("Please enter total no of rows");
            totalRows = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter total no of cols");
            totalCols = Convert.ToInt32(Console.ReadLine());

            if (totalCols != totalRows)
            {
                Console.WriteLine("Please enter rows & cols value same");
                return;
            }

            // print the star pattern

            for (int i = 0; i < totalRows; i++)
            {
                for (int j = 0; j < totalCols; j++)
                {
                    Console.Write((i+1) + " ");
                }

                Console.WriteLine();
            }
        }

        static void PatternThree()
        {
            /*
               1 2 3 4 5
               1 2 3 4 5
               1 2 3 4 5
               1 2 3 4 5
               1 2 3 4 5
                
            */

            int totalRows, totalCols;

            Console.WriteLine("Please enter total no of rows");
            totalRows = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter total no of cols");
            totalCols = Convert.ToInt32(Console.ReadLine());

            if (totalCols != totalRows)
            {
                Console.WriteLine("Please enter rows & cols value same");
                return;
            }

            // print the star pattern

            for (int i = 0; i < totalRows; i++)
            {
                for (int j = 0; j < totalCols; j++)
                {
                    Console.Write((j + 1) + " ");
                }

                Console.WriteLine();
            }
        }

        static void PatternFour()
        {
            /*
               5 4 3 2 1
               5 4 3 2 1
               5 4 3 2 1
               5 4 3 2 1
               5 4 3 2 1
                
            */

            int totalRows, totalCols;

            Console.WriteLine("Please enter total no of rows");
            totalRows = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter total no of cols");
            totalCols = Convert.ToInt32(Console.ReadLine());

            if (totalCols != totalRows)
            {
                Console.WriteLine("Please enter rows & cols value same");
                return;
            }

            // print the star pattern

            for (int i = 0; i < totalRows; i++)
            {
                for (int j = totalCols; j > 0; j--)
                {
                    Console.Write((j ) + " ");
                }

                Console.WriteLine();
            }
        }

        static void PatternFive()
        {
            /*
               a a a a a
               b b b b b
               c c c c c
               d d d d d
               e e e e e
                
            */

            int totalRows, totalCols;

            Console.WriteLine("Please enter total no of rows");
            totalRows = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter total no of cols");
            totalCols = Convert.ToInt32(Console.ReadLine());

            if (totalCols != totalRows)
            {
                Console.WriteLine("Please enter rows & cols value same");
                return;
            }

            // print the star pattern
            char ch = 'a';



            for (int i = 0; i < totalRows; i++)
            {

                for (int j = totalCols; j > 0; j--)
                {
                    Console.Write(ch + " ");
                    
                }
                ch++;

                Console.WriteLine();
            }
        }

        static void PatternSix()
        {
            /*
               a a a a a
               b b b b b
               c c c c c
               d d d d d
               e e e e e
                
            */

            int totalRows, totalCols;

            Console.WriteLine("Please enter total no of rows");
            totalRows = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter total no of cols");
            totalCols = Convert.ToInt32(Console.ReadLine());

            if (totalCols != totalRows)
            {
                Console.WriteLine("Please enter rows & cols value same");
                return;
            }

            // print the star pattern
            int count = 1;



            for (int i = 0; i < totalRows; i++)
            {

                for (int j = totalCols; j > 0; j--)
                {
                    //Console.Write(ch + " ");
                    Console.Write(count + " ");
                    count++;

                }

                Console.WriteLine();
            }
        }

        static void PatternSeven()
        {
            /*
                * 
                * *
                * * *
                * * * *
                * * * * *
            */

            int totalRows, totalCols;

            Console.WriteLine("Please enter total no of rows");
            totalRows = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter total no of cols");
            totalCols = Convert.ToInt32(Console.ReadLine());

            if (totalCols != totalRows)
            {
                Console.WriteLine("Please enter rows & cols value same");
                return;
            }

            // print the star pattern

            for (int i = 0; i < totalRows; i++)
            {

                for (int j = 0;j<=i;j++)
                {
                    //Console.Write(ch + " ");
                    Console.Write("* ");

                }

                Console.WriteLine();
            }
        }

        static void PatternEight()
        {
            /*
                
            */

            int totalRows, totalCols;

            Console.WriteLine("Please enter total no of rows");
            totalRows = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter total no of cols");
            totalCols = Convert.ToInt32(Console.ReadLine());

            if (totalCols != totalRows)
            {
                Console.WriteLine("Please enter rows & cols value same");
                return;
            }

            // print the star pattern

            for (int i = 0; i < totalRows; i++)
            {

                for (int j = 0; j <= i; j++)
                {
                    //Console.Write(ch + " ");
                    Console.Write((j+1)+" ");

                }

                Console.WriteLine();
            }
        }

        static void PatternNine()
        {
            /*
                
            */

            int totalRows, totalCols;

            Console.WriteLine("Please enter total no of rows");
            totalRows = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter total no of cols");
            totalCols = Convert.ToInt32(Console.ReadLine());

            if (totalCols != totalRows)
            {
                Console.WriteLine("Please enter rows & cols value same");
                return;
            }

            // print the star pattern

            for (int i = 0; i < totalRows; i++)
            {

                for (int j = 0; j <= i; j++)
                {
                    //Console.Write(ch + " ");
                    Console.Write((i + 1) + " ");

                }

                Console.WriteLine();
            }
        }

        static void PatternTen()
        {
            /*
                
            */

            int totalRows, totalCols;

            Console.WriteLine("Please enter total no of rows");
            totalRows = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter total no of cols");
            totalCols = Convert.ToInt32(Console.ReadLine());

            if (totalCols != totalRows)
            {
                Console.WriteLine("Please enter rows & cols value same");
                return;
            }

            // print the star pattern

            for (int i = 0; i < totalRows; i++)
            {

                for (int j = i+1; j > 0; j--)
                {
                    //Console.Write(ch + " ");
                    Console.Write((j) + " ");

                }

                Console.WriteLine();
            }
        }

        static void PatternEleven()
        {
            /*
                * 
                * *
                * * *
                * * * *
                * * * * *
            */

            int totalRows, totalCols;

            Console.WriteLine("Please enter total no of rows");
            totalRows = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter total no of cols");
            totalCols = Convert.ToInt32(Console.ReadLine());

            if (totalCols != totalRows)
            {
                Console.WriteLine("Please enter rows & cols value same");
                return;
            }

            // print the star pattern
            char ch = 'a';

            for (int i = 0; i < totalRows; i++)
            {


                for (int j = 0; j <= i; j++)
                {
                    //Console.Write(ch + " ");
                    Console.Write(ch + " ");

                }

                Console.WriteLine();
                ch++;
            }
        }

        static void PatternTwelve()
        {
            /*
                * 
                * *
                * * *
                * * * *
                * * * * *
            */

            int totalRows, totalCols;

            Console.WriteLine("Please enter total no of rows");
            totalRows = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter total no of cols");
            totalCols = Convert.ToInt32(Console.ReadLine());

            if (totalCols != totalRows)
            {
                Console.WriteLine("Please enter rows & cols value same");
                return;
            }

            // print the star pattern
            //char ch = 'a';

            for (int i = 0; i < totalRows; i++)
            {


                for (int j = totalRows; j > i; j--)
                {
                    //Console.Write(ch + " ");
                    Console.Write("* ");

                }

                Console.WriteLine();
                //ch++;
            }
        }

        static void PatternThirteen()
        {
            /*
                * 
                * *
                * * *
                * * * *
                * * * * *
            */

            int totalRows, totalCols;

            Console.WriteLine("Please enter total no of rows");
            totalRows = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter total no of cols");
            totalCols = Convert.ToInt32(Console.ReadLine());

            if (totalCols != totalRows)
            {
                Console.WriteLine("Please enter rows & cols value same");
                return;
            }

            // print the star pattern
            //char ch = 'a';


            for (int i = 0; i < totalRows; i++)
            {
                int count = 1;


                for (int j = totalRows; j > i; j--)
                {
                    //Console.Write(ch + " ");
                    Console.Write(count + " ");
                    count++;

                }

                Console.WriteLine();
                //ch++;
            }
        }




        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            //PatternOne();
            //PatternTwo();
            //PatternThree();
            //PatternFour();
            //PatternFive();
            //PatternSix();
            //PatternSeven();
            //PatternEight();
            //PatternNine();
            //PatternTen();
            //PatternEleven();
            //PatternTwelve();
            PatternThirteen();
        }
    }
}
