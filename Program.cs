Test();
//GC.Collect();
Console.ReadLine();
void Test()
{
    Human1? ted = null;
    try
    {
        ted = new Human1("Ted");
    }
    finally
    {
        ted?.Dispose();
    }
    //Console.WriteLine(ted.Name);
}
//record class Human(string Name);
public class Human1:IDisposable
{
    public string Name { get; }
    public Human1(string name)=>Name= name;
    /*~Human1()
    {
        Console.WriteLine($"{Name} has deleted");
    }*/
    public void Dispose()
    {
        Console.WriteLine($"{Name} has been disposed");
    }
}
public class SomeClass:IDisposable
{
    private bool disposed = false;
    //реализация интерфейса IDisposable
    public void Dispose()
    {
        //Освобождаем неуправлемые ресурсы
        Dispose(true);
        //добавляем финализацию
        GC.SuppressFinalize(this);
    }
    protected virtual void Dispose(bool disposing)
    {
        if(disposed) return;
        if(disposing)
        {
            //Освобождаем управляемые ресурсы
        }
        //освобождаем неуправляемые ресурсы
        disposed = true;
    }
    ~SomeClass() { Dispose(false); }
}