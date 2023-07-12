namespace UploadService
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var myUploadService1 = UploadService.GetInstance().TimesCalled();
            var myUploadService2 = UploadService.GetInstance().TimesCalled();

            Console.WriteLine(myUploadService1);
            Console.WriteLine(myUploadService2);
        }
    }
}