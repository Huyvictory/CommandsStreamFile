using System.IO;

namespace DirComand
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var path = "C:\\Users\\vomin\\OneDrive\\Hình ảnh\\Ảnh chụp màn hình";

            var dir = new DirectoryInfo(path);

            var directories = dir.GetDirectories();

            foreach (var directory in directories)
            {
                Console.WriteLine($"{directory.LastWriteTime.ToString("MM/dd/yyyy")} {directory.LastWriteTime.ToString("HH:mm")} <DIR> {directory.Name}");
            }

            var files = dir.GetFiles();

            foreach (var file in files)
            {
                Console.WriteLine($"{file.LastWriteTime.ToString("MM/dd/yyyy")} {file.LastWriteTime.ToString("HH:mm")}  {file.Length.ToString("#,###")}      {file.Name}");
            }
        }
    }
}
