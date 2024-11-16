namespace kare
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int kareBoyutu = 7; 
            for (int i = 0; i < kareBoyutu; i++)
            {
                for (int j = 0; j < kareBoyutu; j++)
                {
                    if (i == 0 || i == kareBoyutu - 1)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        if (j == 0 || j == kareBoyutu - 1)
                        {
                            Console.Write("*");
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }
                }
                Console.WriteLine(); 
            }

        }
    }
}
