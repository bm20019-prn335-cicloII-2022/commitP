
using DriveDownload;

Utilidad ut = new Utilidad();
ut.SetId("1ir1rmmG_Pjmhcc35bjUMgRxTB8IRYAxP");
ut.SetApiKey("AIzaSyB0ND7xOs3nkDUVTA_IzaJzChZLwfNiKDU");
Console.WriteLine(ut.CheckUrl("https://www.googleapis.com/drive/v3/files/1ir1rmmG_Pjmhcc35bjUMgRxTB8IRYAxP?alt=media&key=AIzaSyB0ND7xOs3nkDUVTA_IzaJzChZLwfNiKDU"));

/*using System.Reflection;
using CommandLine;

string ApiKey = "", url = "", Id = "", UrlDownload = "";
ArgumentParser argumentParser = new ArgumentParser("DriveDownload","Crea una url para la descarga de archivos GDRIVE");
argumentParser.AddArgument("--key","-k","Api key de GDrive",Tipos.String);
argumentParser.AddArgument("--url","-u","Url del archivo compartido");
argumentParser.AddArgument("--filekey","-fk","Archivo que contiene la ApiKey");
argumentParser.CommandArgumentParser(args);

if (!argumentParser.Contains("--url"))
    throw new Exception("No se ha dado una url");
url = argumentParser.GetValue<string>("--url");
if (!url.Contains("https"))
        throw new Exception("Url invalida");

//Si la ApiKey se ingresa por consola
if(argumentParser.Contains("--key"))
{
    ApiKey = argumentParser.GetValue<string>("--key");
    foreach (string Split in url.Split('/'))
    {
        if (Split.Length > 20)
            Id = Split;
    }
    Console.WriteLine("El ID obtenido es {0}",Id);
    UrlDownload = String.Format("https://www.googleapis.com/drive/v3/files/{0}?alt=media&key={1}",Id,ApiKey);
    Console.WriteLine("URL: {0}", UrlDownload);
    
}
else if (argumentParser.Contains("--filekey"))
{
    string file = argumentParser.GetValue<string>("--filekey");
    if (!File.Exists(file))
        throw new FileNotFoundException("El archivo no existe");
    string[] apis = File.ReadAllLines(file);

    foreach (string key in apis)
    {
        if (key.Length > 25)
            ApiKey = key;
    }
    foreach (string Split in url.Split('/'))
    {
        if (Split.Length > 20)
            Id = Split;
    }
    Console.WriteLine("El ID obtenido es {0}",Id);
    UrlDownload = String.Format("https://www.googleapis.com/drive/v3/files/{0}?alt=media&key={1}",Id,ApiKey);
    Console.WriteLine("URL: {0}", UrlDownload);
}
else
{
    string dir = new FileInfo(Environment.ProcessPath).Directory.FullName;
    string file = Path.Combine(dir, "Apikey.api");
    if (!File.Exists(file))
        throw new FileNotFoundException("El archivo no existe");
    string[] apis = File.ReadAllLines(file);
    foreach (string key in apis)
    {
        if (key.Length > 25)
            ApiKey = key;
    }
    foreach (string Split in url.Split('/'))
    {
        if (Split.Length > 20)
            Id = Split;
    }
    Console.WriteLine("El ID obtenido es {0}",Id);
    UrlDownload = String.Format("https://www.googleapis.com/drive/v3/files/{0}?alt=media&key={1}",Id,ApiKey);
    Console.WriteLine("URL: {0}", UrlDownload);
}*/