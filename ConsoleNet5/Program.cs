using System;
using Echo;

namespace ConsoleNet5
{
  internal class Program
  {
    static void Main(string[] args)
    {
      var message = "This is my message. There are many like it, but this one is mine.";
      var echoer = new Echoer();
      var echoResponse = echoer.Echo(message);
      Console.WriteLine($"Original Message: {message}");
      Console.WriteLine($"Echo response: {echoResponse}");
    }
  }
}
