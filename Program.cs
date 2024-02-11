namespace ImageDownloader;

public class Program
{
    static bool _isProgarammEnd = false;
    static CancellationTokenSource cts = new CancellationTokenSource();

    static void Main()
    {
        List<Task> downloadTasks = new List<Task>();
        var imagesStore = new Store();
        var downloadFile = new ImageDownloader();
        downloadFile.ImageStarted += (string fileName) =>
        {
            Console.WriteLine($"Скачивание файла {fileName} началось");
        };
        downloadFile.ImageCompleted += (string fileName) =>
        {
            Console.WriteLine($"Скачивание файла{fileName} закончилось");
        };
        foreach (var img in imagesStore.Images)
        {
            downloadTasks.Add(downloadFile.Download(img.Key, img.Value, cts.Token));
        }

        Console.WriteLine("Нажмите клавишу A для выхода или любую другую клавишу для проверки статуса скачивания");
        while (!_isProgarammEnd)
        {
            var command = Console.ReadLine();
            if (command == "A")
            {
                _isProgarammEnd = true;
                cts.Cancel();
            }
                
            else
            {
                foreach (var task in downloadTasks)
                {
                    Console.WriteLine(task.IsCompleted);
                }
            }
        }

        Console.WriteLine("Работа приложения окончена");
    }
}