namespace MathQuiz
{
    public class BoolAnswers
    {
        public bool SumAnswer { get; set; }
        public bool MinusAnswer { get; set; }
        public bool MultiAnswer { get; set; }
        public bool DivAnswer { get; set; }

        public bool Check()
        {
            return SumAnswer && MinusAnswer && MultiAnswer && DivAnswer;
        }

        public int CorrectAnswersCount()
        {
            int count = 0;
            if (SumAnswer)
            {
                count += 1;

            }
            if (MinusAnswer)
            {
                count += 1;

            }
            if (MultiAnswer)
            {
                count += 1;

            }
            if (DivAnswer)
            {
                count += 1;

            }

            return count;
        }
    }
}