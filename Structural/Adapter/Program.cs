using System.Net;
using Adapter.Models;
using Adapter.Services;

WebClient client = new();
XmlToJsonAdapter adapter = new();

var link = $"https://www.cbar.az/currencies/{DateTime.Now.ToString("dd.MM.yyyy")}.xml";

var text = client.DownloadString(link);
var json = adapter.ConvertXmlToJson<ValCurs>(text);

using FileStream fs = new("currencies.json", FileMode.OpenOrCreate);
using StreamWriter sw = new(fs);


sw.Write(json);




