string name = null;

string foo(string text)
{
    return text ?? throw new ArgumentNullException(nameof(text));
}


try
{
    foo(name);
}
catch (Exception e)
{
    Console.WriteLine(e);
}


