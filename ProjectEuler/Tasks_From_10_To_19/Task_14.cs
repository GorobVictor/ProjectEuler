namespace ProjectEuler.Tasks_From_10_To_19
{
    internal class Task_14 : Task<(double,int)>
    {
        protected override (double,int) Result
        {
            get
            {
                var result = new Task_NumberSequence(-1,-1);
                for (int i = 1;i<=1000000; i++)
                {
                    var collatz = new Task_NumberSequence(i,Collatz(i, 1));
                    if (result.Sequence < collatz.Sequence)
                        result = collatz;
                }
                return (result.Number,result.Sequence);
            }
        }

        int Collatz(double number, int sequence)
        {
            if (number == 1)
                return sequence;
            else if (number < 1)
                return -1;
            else if (number % 2 == 0) return Collatz(number / 2, ++sequence);
            else return Collatz(3 * number + 1, ++sequence);
        }

        class Task_NumberSequence
        {
            public Task_NumberSequence(double number,int sequence)
            {
                Number = number;
                Sequence = sequence;
            }

            public double Number { get; set; }
            public int Sequence { get; set; }
        }
    }
}