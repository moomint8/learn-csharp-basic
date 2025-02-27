namespace temperature_converter
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("변환할 온도: ");
            string input = Console.ReadLine();

            double fahrenheit = (int.Parse(input) * 1.8) + 32;
            Console.WriteLine("섭씨 " + input + "도는 화씨" + fahrenheit + "도입니다.");
        }
    }
}
