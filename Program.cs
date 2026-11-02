using System.Management;

var osSearcher = new ManagementObjectSearcher("SELECT * FROM Win32_OperatingSystem");

foreach (ManagementObject os in osSearcher.Get()) {
    Console.WriteLine($"OC: {os["Caption"]}"); 
    Console.WriteLine($"Версия: {os["Version"]}");
}