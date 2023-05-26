
// Fecade -  представляет шаблон проектирования, который позволяет скрыть сложность системы с помощью предоставления упрощенного интерфейса для взаимодействия с ней.

namespace Facedeee
{

    public class Facade
    {
        SubsystemA subsystemA;
        SubsystemB subsystemB;
        SubsystemC subsystemC;

        public Facade(SubsystemA sa, SubsystemB sb, SubsystemC sc)
        {
            subsystemA = sa;
            subsystemB = sb;
            subsystemC = sc;
        }
        public void Operation1()
        {
            subsystemA.A1();
            subsystemB.B1();
            subsystemC.C1();
        }
        public void Operation2()
        {
            subsystemB.B1();
            subsystemC.C1();
        }
    }

    public class SubsystemA
    {
        public void A1()
        { }
    }
    public class SubsystemB
    {
        public void B1()
        { }
    }
    public class SubsystemC
    {
        public void C1()
        { }
    }

}


