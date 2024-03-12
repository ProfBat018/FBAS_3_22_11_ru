namespace WebServer.Models;

public class SimilarResponse
{
    public string word { get; set; }
    public string[] similarTo { get; set; }
}