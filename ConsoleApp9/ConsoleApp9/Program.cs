using Brideee;
using Composite;
using Facedeee;
using System;
using System.ComponentModel;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            //Proxy -
            ISubject subject = new Proxy();
            subject.Request();

            //Bride
            Abstraction abstraction;
            abstraction = new RefinedAbstraction(new ConcreteImplementorA());
            abstraction.Operation();
            abstraction.Implementor = new ConcreteImplementorB();
            abstraction.Operation();

            //Composite
            //Component root = new Composite("Root");
            //Component leaf = new Leaf("Leaf");
            //Composite subtree = new Composite("Subtree");
            //root.Add(leaf);
            //root.Add(subtree);
            //root.Display();

            //Proxy
            Facade facade = new Facade(new SubsystemA(), new SubsystemB(), new SubsystemC());
            facade.Operation1();
            facade.Operation2();
        }
    }
}
