namespace TestFileService {
    class Program {
        static void Main(string[] args) {

            FileService.Service1Client proxy = new FileService.Service1Client();

            Console.Write("Please input the name of the file that you want to write to: ");
            string fileName = Console.ReadLine();

            Console.Write("Please input string that you want to write to that file: ");
            string input = Console.ReadLine();

            proxy.PutStringToFile(fileName, input);

            Console.WriteLine("Here is what the file now contains: ");
            Console.WriteLine(proxy.GetStringFromFile(fileName));

            proxy.Close();
        }
    }
}