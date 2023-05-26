//Proxy - предоставляет объект - заместитель, который управляет доступом к другому объекту. 

//Используется когда идет работа с бд
public interface ISubject
{
    void Request();
}

public class RealSubject : ISubject
{
    public void Request()
    {

    }
}

public class Proxy : ISubject
{
    public void Request()
    {

    }
}

