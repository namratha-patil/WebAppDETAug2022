namespace WebAppDETAug2022.Service
{
    public interface IHello
    {

            string SayHello(string name);
        }
        public class Hello : IHello
        {
            public string SayHello(string name)
            {
                return $"Hello {name}, Wellcome to Asp.NET Core";
            }
        }
        public class Hello2 : IHello
        {
            public string SayHello(string name)
            {
                return $"Hai ,Hello{name}, How is the day!!";
            }
        }
    }



