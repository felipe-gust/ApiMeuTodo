using System;

namespace MeuTodo
{
    public class Program
    {
        static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var app = builder.Build();

            app.MapGet("/", () => "Hello World! \nThis is my first API with C#!");

            app.Run();
        }
    }    
}


