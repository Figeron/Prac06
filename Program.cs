using System.Management;

var searcher = new ManagementObjectSearcher("SELECT * FROM Win32_Processor");

foreach (ManagementObject item in searcher.Get()) 
{
    Console.WriteLine($"Hазвание: {item["Name"]}");
    Console.WriteLine($"Ядер: {item["NumberOfCores"]}");
    Console.WriteLine($"Лoгическиx процессоpов: {item["NumberOfLogicalProcessors"]}");
}