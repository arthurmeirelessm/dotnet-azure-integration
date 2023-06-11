// See https://aka.ms/new-console-template for more information
using DotNetEnv;



DotNetEnv.Env.Load();



Console.WriteLine(Environment.GetEnvironmentVariable("ACCOUNTENDPOINT"));



