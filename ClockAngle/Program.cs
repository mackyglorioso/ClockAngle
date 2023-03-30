internal class Program
{
    private static void Main(string[] args)
    {

       
        Console.WriteLine("Calculate the Angle of an Analog Clock!");

        Console.WriteLine("Enter Hour:  ");
        int Hour_Hand = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Minutes:  ");
        int Minutes_Hand = Convert.ToInt32(Console.ReadLine());


        if (Hour_Hand >= 12)
        {
            Console.WriteLine("INVALID TIME! Hour should be less than 12");

        }
        else if (Minutes_Hand >= 60)
        {

            Console.WriteLine("INVALID TIME! Minutes should be less than 60");
        }




        else
        {

            double angle = (30 * Hour_Hand) - (5.5 * Minutes_Hand);

            if (angle < 0)
            {
                double NewAngle = angle * -1;
                double angle2 = 360 - NewAngle;

                Console.WriteLine("\nAngle from hour hand is " + NewAngle);
                Console.WriteLine("\nAngle from Minutes hand is " + angle2);

                Console.WriteLine("\n \tThe lesser ANGLE in Degrees is " + NewAngle + " degrees.");

            }
            else
            {
                double angle3 = 360 - angle;

                Console.WriteLine("\nAngle from hour hand is " + angle);
                Console.WriteLine("\nAngle from Minutes hand is " + angle3);

                
                Console.WriteLine("\n \tThe lesser ANGLE in Degrees is " + angle + " degrees.");


            }



        }


    }
}
