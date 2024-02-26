// See https://aka.ms/new-console-template for more information

using Echo;

var message = "This is my message. There are many like it, but this one is mine.";
var echoer = new Echoer();
var echoResponse = echoer.Echo(message);
Console.WriteLine($"Original Message: {message}");
Console.WriteLine($"Echo response: {echoResponse}");