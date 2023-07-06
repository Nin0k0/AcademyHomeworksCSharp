



using Homework_14;

const string QuestionsFileName = "questions.txt";
const string ScoresFileName = "scores.txt";
QuizManage quizManage;
var questionRepository = new QuestionsFile(QuestionsFileName);
var scoreRepository = new ResultsFile(ScoresFileName);

quizManage = new QuizManage(questionRepository, scoreRepository);

while (true)
{
    QuizManage.DisplayMainMenu();
    var choice = QuizManage.GetMainMenuChoice();

    switch (choice)
    {
        case MainMenuChoice.WriteQuiz:
            quizManage.RunQuiz();
            break;
        case MainMenuChoice.AddQuestions:
            quizManage.AddQuestions();
            break;
        case MainMenuChoice.Exit:
            return;
    }
}

//        Console.WriteLine(HasSpace("Hel loo"));

//        bool HasSpace(string str)
//        {
//            return str.Contains(' ');
//        }

//        var jaggedArray = new int[3][];
//        jaggedArray[0] = new int[] { 1, 3, 5, 7, 9 };
//        jaggedArray[1] = new int[] { 0, 2, -4, 6 };
//        jaggedArray[2] = new int[] { 11, 22 };

//        var ret = ReturnMaxs(jaggedArray);
//        foreach (var VARIABLE in ret )
//        {
//            Console.WriteLine(VARIABLE);
//}



//        int[] ReturnMaxs( int[][] arrays )
//        {
//            int[] result = new int[arrays.Length];
//            for (int i = 0; i < arrays.Length; i++)
//            {
//                result[i] = arrays[i].Max();
//            }

//            return result;
//        }

//Console.WriteLine(PositiveNumbersCount(jaggedArray[1], out int Somethin));

//        Console.WriteLine(Somethin);

//        int PositiveNumbersCount(int[] array, out int negatuveSum)
//        {
//            var result = 0;
//            negatuveSum = 0;

//    foreach (var VARIABLE in array)
//            {
//                if (VARIABLE >= 0)
//                {
//                    result += 1;
//                }
//                else
//                {

//                    negatuveSum += VARIABLE;
//                }
//            }
//            return result;
//        }


//        //    MemeCalculator(45,698);

//        //void MemeCalculator(int first, int second)
//        //{
//        //        var firststr = first.ToString();
//        //        var secondstr = second.ToString();
//        //        string[] forReverse = null;

//        //        for (int i = firststr.Length-1; i >0 ; i--)
//        //        {
//        //            for (int j = secondstr.Length-1; j > 0; j--)
//        //            {
//        //                 forReverse[i] = ((int)firststr[i] + (int)secondstr[j]).ToString();
//        //    Console.WriteLine(forReverse[i]);
//        //            }
//        //        }



//        //}


//        Console.WriteLine(IsPerfectNumber(28));


//        bool IsPerfectNumber(int number)
//        {

//            int sum = 0;

//            for ( var i = 1; i < number; i++)
//            {
//                if (number%i==0)
//                {
//                    sum += i;
//                }
//            }

//            return sum == number;

//        }