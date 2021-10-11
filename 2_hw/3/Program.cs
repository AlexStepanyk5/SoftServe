using System;

    enum HTTPError
    {
        Bad_Request = 400,
        Unauthorized = 401,
        Payment_Required = 402,
        Forbidden = 403,
        Not_Found = 404,
        Method_Not_Allowed = 405

    };

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input the number of error: ");
            int error = int.Parse(Console.ReadLine());

            Console.WriteLine($"Your error is \"{(HTTPError)error}\"");
        }
    }