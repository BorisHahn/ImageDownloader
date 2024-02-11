using System.Net;

namespace ImageDownloader;

public class ImageDownloader
{
    public event Action<string> ImageStarted;
    public event Action<string> ImageCompleted;

    public async Task Download(string fileName, string remoteUri, CancellationToken cancellationToken)
    {
        try
        {
            if (cancellationToken.IsCancellationRequested)
            {
                Console.WriteLine($"Скачивание файла {fileName} прервано");
                return;
            }
            else
            {
                var myWebClient = new WebClient();
                ImageStarted.Invoke(fileName);
                await myWebClient.DownloadFileTaskAsync(remoteUri, fileName);
                ImageCompleted.Invoke(fileName);
            }
        }
        catch (OperationCanceledException)
        {
        }
    }
}