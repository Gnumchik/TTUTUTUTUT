
//Adepter - предназначен для преобразования интерфейса одного класса в интерфейс другого.


namespace Adepterss
{
    class Client
    {
        public void Request(Target target)
        {
            target.Request();
        }
    }
    class Target
    {
        public virtual void Request()
        { }
    }
    class Apdate : Target
    {
        private Adaptee adaptee = new Adaptee();

        public override void Request()
        {
            adaptee.SpecificRequest();
        }
    }
    class Adaptee
    {
        public void SpecificRequest()
        { }
    }


}

