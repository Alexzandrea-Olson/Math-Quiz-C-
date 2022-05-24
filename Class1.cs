using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Class1
    {
        //variables
        private int testNum; 
        public static int correct = 0;
        public static int incorrect = 0;

        int[] arrayOne = { 3, 4, 5 };
        int[] arrayTwo = { 16, 17, 18 };

        double[] arrayThree = { 16, 4, 2 };
        double[] arrayFour = { 2, 4, 16 };

        //constructor
        public Class1(int userInput)
        {
            testNum = userInput;

            //takes user choice of test and then redirects to right method
            switch (testNum)
            {
                case 1:
                    mathQuizOne();
                    break;
                case 2:
                    mathQuizTwo();
                        break;
                case 3:
                    mathQuizThree();
                    break;
                case 4:
                    mathQuizFour();
                    break;
            }
        }

        //grades quizzes with int variables
        private static void gradeArrays(int[] array1, int[] array2)
        {
            //local variables
            int i = 0;
            int j = 0;
            int h = 0;

            do
            {
                //compares answers and only counts correct answers
                if (array1[i] == array2[j])
                {
                    correct++;
                }
                //count up
                i++;
                j++;
                h++;
            } while (h < 9); //loops through entire array
        
            //prints how many the user got correct
            Console.WriteLine("The number correct is: " + correct + " out of 9");
        }

        //grades quizzes with double variables
        private static void gradeArraysDoubles(double[] array3, double[] array4)
        {
            //local variables
            int i = 0;
            int j = 0;
            int h = 0;

            do
            {
                if (array3[i] == array4[j])
                {
                    correct++;
                }
                //counts up
                i++;
                j++;
                h++;
            } while (h < 9);//loops through entire array
            Console.WriteLine("The number correct is: " + correct + " out of 9");
        }
        //addition quiz
        private void mathQuizOne()
        {
            // TODO Auto-generated method stub
            int x = 0;
            int[] quizOneArray = new int[9]; //holds user answers 
            int[] quizOneAnswer = new int[9]; //holds the test answers

            //double for loop to access two arrays at the same time at the exact same array location
            for (int i = 0; i < arrayOne.Length; i++)
            {
                for (int j = 0; j < arrayTwo.Length; j++)
                {
                    //saving test answers
                    quizOneAnswer[x] = arrayOne[i] + arrayTwo[j];

                    //prompting user question 
                    Console.WriteLine("What is: " + arrayOne[i] + " + " + arrayTwo[j]);

                    //saving user input 
                    quizOneArray[x] = int.Parse(Console.ReadLine());
                    x++;
                }
            }
            //calls method to grade test
            gradeArrays(quizOneAnswer, quizOneArray);
        }
        //subtraction quiz
        private void mathQuizTwo()
        {
            // TODO Auto-generated method stub
            int x = 0;
            int[] quizTwoArray = new int[9]; //holds user answers
            int[] quizTwoAnswer = new int[9]; //holds the correct answers

            //double for loop
            for (int i = 0; i < arrayOne.Length; i++)
            {
                for (int j = 0; j < arrayTwo.Length; j++)
                {

                    //storing correct answers
                    quizTwoAnswer[x] = arrayTwo[j] - arrayOne[i];

                    //storing users answers
                    Console.WriteLine("What is : " + arrayTwo[j] + " - " + arrayOne[i]);
                    quizTwoArray[x] = int.Parse(Console.ReadLine());
                    x++;
                }
            }
            //calling method to grade
            gradeArrays(quizTwoAnswer, quizTwoArray);
        }
        //multiplication math quiz
        private void mathQuizThree()
        {
            // TODO Auto-generated method stub
            int x = 0;
            int[] quizThreeArray = new int[9]; //holds user answers
            int[] quizThreeAnswer = new int[9]; //holds the correct answers

            //double for loop
            for (int i = 0; i < arrayOne.Length; i++)
            {
                for (int j = 0; j < arrayTwo.Length; j++)
                {

                    //storing correct answers 
                    quizThreeAnswer[x] = arrayOne[i] * arrayTwo[j];

                    //storing user answers
                    Console.WriteLine("What is : " + arrayOne[i] + " * " + arrayTwo[j]);
                    quizThreeArray[x] = int.Parse(Console.ReadLine());
                    x++;
                }
            }
            gradeArrays(quizThreeAnswer, quizThreeArray);
        }
        //division math quiz
        private void mathQuizFour()
        {
            // TODO Auto-generated method stub
            int x = 0;
            double[] quizFourArray = new double[9]; //holds user answers
            double[] quizFourAnswer = new double[9]; //holds the correct answers

            //double four loop
            for (int i = 0; i < arrayThree.Length; i++)
            {
                for (int j = 0; j < arrayFour.Length; j++)
                {

                    //storing correct answers
                    quizFourAnswer[x] = arrayThree[i] / arrayFour[j];

                    //storing user answers
                    Console.WriteLine("What is: " + arrayThree[i] + " divided by " + arrayFour[j]);
                    quizFourArray[x] = int.Parse(Console.ReadLine());
                    x++;
                }
            }
            gradeArraysDoubles(quizFourAnswer, quizFourArray);
        }

    }
}
