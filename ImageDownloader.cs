using System.Net;

namespace ImageDownloader;

public class ImageDownloader
{
    public event Action<string> ImageStarted;
    public event Action<string> ImageCompleted;

    public async Task Download(string fileName, string remoteUri)
    {
        var myWebClient = new WebClient();
        ImageStarted.Invoke(fileName);
        await myWebClient.DownloadFileTaskAsync(remoteUri, fileName);
        ImageCompleted.Invoke(fileName);
    }
}