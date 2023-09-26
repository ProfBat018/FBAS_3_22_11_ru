class A : IInterface
{
    public void foo()
    {
        throw new NotImplementedException();
    }
}

interface IInterface
{
    void foo();
}