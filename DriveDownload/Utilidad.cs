using System.Text.RegularExpressions;

namespace DriveDownload;

public class Utilidad
{
    private string ApiKey { get; set; }
    private string Id { get; set; }
    private string urlDownload { get; set; }

    public string Crear(string url, string Id,string ApiKey)
    {
        this.Id = Id;
        this.ApiKey = ApiKey;
        foreach (string Split in url.Split('/'))
        {
            if (Split.Length > 20)
                this.Id = Split;
        }
        string UrlDownload = String.Format("https://www.googleapis.com/drive/v3/files/{0}?alt=media&key={1}",Id,ApiKey);
        urlDownload = UrlDownload;
        return urlDownload;
    }
    public bool CheckUrl(string url)
    {
        if(url.StartsWith("https://www.googleapis.com/drive/v3/files/"))
            if(Id.Length>20)
                if (ApiKey.Length > 20)
                    return true;
        return false;
    }
    public void SetApiKey(string ApiKey)
    {
        this.ApiKey = ApiKey;
    }

    public string GetApiKey()
    {
        return this.ApiKey;
    }

    public void SetId(string Id)
    {
        this.Id = Id;
    }

    public string GetId()
    {
        return this.Id;
    }

    public string GetUrlDownload()
    {
        return this.urlDownload;
    }
}