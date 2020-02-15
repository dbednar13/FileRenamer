using System.IO;
using System.Linq;

namespace FileRenamer
{
    class FileRenamer
    {
        static void Main(string[] args)
        {
            if(args.Length == 0)
            {
                return;
            }

            var dicrectories = Directory.EnumerateDirectories(args[0]);

            foreach(var directory in dicrectories)
            {
                var nameIndex = directory.LastIndexOf('\\');
                var name = directory.Substring(nameIndex + 1);
                var source = Directory.EnumerateFiles(directory).FirstOrDefault();
                var sourceIndex = source.LastIndexOf('.');
                var extension = source.Substring(sourceIndex +1);
                File.Move(source, $"{directory}\\{name}.{extension}");
            }
        }
    }
}
