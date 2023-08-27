using System.Text;

StringBuilder sb = new(5, 10);

try
{
    sb.Append("Hello");
    sb.Append(" ");
    sb.Append("World");
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}



