
//Bridge - структурный шаблон проектирования,который позволяет отделить абстракцию от
//реализации таким образом, чтобы и абстракцию, и реализацию можно было изменять независимо друг от друга.


namespace Brideee
{
    abstract class Abstraction
    {
        protected Implementor implementor;
        public Implementor Implementor
        {
            set { implementor = value; }
        }
        public Abstraction(Implementor imp)
        {
            implementor = imp;
        }
        public virtual void Operation()
        {
            implementor.OperationImp();
        }
    }

    abstract class Implementor
    {
        public abstract void OperationImp();
    }

    class RefinedAbstraction : Abstraction
    {
        public RefinedAbstraction(Implementor imp)
            : base(imp)
        { }
        public override void Operation()
        {
        }
    }

    class ConcreteImplementorA : Implementor
    {
        public override void OperationImp()
        {
        }
    }

    class ConcreteImplementorB : Implementor
    {
        public override void OperationImp()
        {
        }
    }

}
