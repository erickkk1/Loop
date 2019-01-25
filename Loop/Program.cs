using System;

namespace Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" write a integer between 1 and 100");
            try
            {
                //This will get the input from the user.
                String input = Console.ReadLine();

                //This variable will be used to perform the various iterative statements and is parsed as an integer.
                int value_of_input = int.Parse(input);


                // If the value of user input is between 1 and 100, execute a For Loop.
                if ((value_of_input >= 1) && (value_of_input <= 100))
                {
                    Console.WriteLine("Executing the for loop");
                    Console.WriteLine("The for loop will iterate" + value_of_input.ToString() + "times.");
                    // here is the for loop.
                    for (int i = 0; i < value_of_input; i++)
                    {
                        Console.WriteLine(" The value of the variable i in this: " + i.ToString());
                    }
                   
                   
                    Console.WriteLine(" Press any key to exit");
                    Console.ReadKey(true);
                    
                        

                    
                }

            }// End of try
            catch
            {
                Console.WriteLine("You should type an enteger please.");
                Console.ReadKey(true);
            }// end of catch.

        } 
    }
}
