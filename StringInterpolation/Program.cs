namespace StringInterpolation
{
    internal class Program
    {
        private static void Main(string[] args)
        {

            //var nowUtc = DateTime.UtcNow; //agnostic
            //https://www.c-sharpcorner.com/blogs/date-and-time-format-in-c-sharp-programming1
            
           
            //1.January 22, 2019 (right aligned in a 40 character field)
            //string exampleOne = DateTime.Now.ToString("MMMM dd, yyyy");
            DateTime thisDate = DateTime.Now;
            var now = DateTime.Now;
            
            string exampleOne = DateTime.Now.ToString("MMMM dd, yyyy");
            //Console.WriteLine($"{exampleOne,40}");
            Console.WriteLine($"{now,40:MMMM dd, yyyy}");
            
            //2.2019.01.22
            string exampleTwo = DateTime.Now.ToString("yyyy.MM.dd");
            Console.WriteLine($"{exampleTwo}");
            
            //3.Day 22 of January, 2019
            Console.WriteLine($"Day {now:dd} of {now:MMMM, yyyy}");
            
            //4.Year: 2019, Month: 01, Day: 22
            Console.WriteLine($"Year: {now:yyyy}, Month: {now:MM}, Day: {now:dd}");
            
            //5.            Tuesday (10 spaces total, right aligned)
            Console.WriteLine($"{now,10:dddd}");
            
            //6.     11:01 PM             Tuesday (10 spaces total for each including the day-of-week, both right-aligned)
            Console.WriteLine($"{now,10:hh:mm tt}{now,10:dddd}");
            
            //7.h:11, m:01, s:27
            Console.WriteLine($"h:{now:hh}, m:{now:mm}, s:{now:ss}");
            
            //8.2019.01.22.11.01.27
            string exampleEight = DateTime.Now.ToString("yyyy.MM.dd.hh.mm.ss");
            Console.WriteLine($"{exampleEight}");
            
            var pi = Math.PI;
            //{<interpolationExpression>[,<alignment>][:<formatString>]}
            
            //1. Output as currency
            Console.WriteLine($"{pi:C2}");
            
            Console.WriteLine($"{pi,10:N3}"); //right aligned
            //Console.WriteLine($"|{pi,10:N2}|"); //left aligned
            //Console.WriteLine($"{pi:P2}");
           


        }
    }
}