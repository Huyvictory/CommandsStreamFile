namespace CopyCommand
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var source = @"C:\Users\vomin\OneDrive\HuyvictoryPC\.NET Basics\test.txt";
            var target = @"C:\Users\vomin\OneDrive\HuyvictoryPC\.NET Basics\test-copy.txt";

            // buffer memory for file copy operation
            var bufferMemory = new byte[1024];
            var inputStreamOpenFile = File.OpenRead(source);
            var outputStreamWriteFile = File.OpenWrite(target);

            // Read file and push into buffer memory
            int n = inputStreamOpenFile.Read(bufferMemory, 0, bufferMemory.Length);

            // File is not read completely
            while (n > 0)
            {
                Console.WriteLine(n.ToString());

                outputStreamWriteFile.Write(bufferMemory, 0, n);

                n = inputStreamOpenFile.Read(bufferMemory, 0, bufferMemory.Length);
            }

            inputStreamOpenFile.Close();
            outputStreamWriteFile.Close();
        }
    }
}
