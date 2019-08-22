using System;
namespace aspnetcoreapp
{
    public class Hello : IHello
    {
        public Hello()
        {
            // throw new Exception();
        }

        public string SayHello()
        {
            return "Hello From Interface Using DI"; 
        }
    }
}