using System.Net;

internal class Program
{
    private static void Main(string[] args)
    {
        //Test Case
        Console.WriteLine(IpCheck.IsValidIp("0.0.0.0"));
        Console.WriteLine(IpCheck.IsValidIp("12.255.56.1"));
        Console.WriteLine(IpCheck.IsValidIp("137.255.156.100"));
        Console.WriteLine(IpCheck.IsValidIp(""));
        Console.WriteLine(IpCheck.IsValidIp("abc.def.ghi.jkl"));
        Console.WriteLine(IpCheck.IsValidIp("123.456.789.0"));
        Console.WriteLine(IpCheck.IsValidIp("12.34.56"));
        Console.WriteLine(IpCheck.IsValidIp("12.34.56.00"));
        Console.WriteLine(IpCheck.IsValidIp("12.34.56.7.8"));
        Console.WriteLine(IpCheck.IsValidIp("12.34.256.78"));
        Console.WriteLine(IpCheck.IsValidIp("1234.34.56"));
        Console.WriteLine(IpCheck.IsValidIp("pr12.34.56.78"));
        Console.WriteLine(IpCheck.IsValidIp("12.34.56.78sf"));
        Console.WriteLine(IpCheck.IsValidIp("12.34.56 .1"));
        Console.WriteLine(IpCheck.IsValidIp("12.34.56.-1"));
        Console.WriteLine(IpCheck.IsValidIp("80.077.157.53"));

    }
}
class IpCheck
{
    public static bool IsValidIp(string ipAddres)
    {
        foreach (var item in ipAddres.Split("."))
        {
            if (item != "" && item.ToCharArray()[0] == '0' && item.ToCharArray().Length > 1) return false;
        }
        if (ipAddres.Split(".").Length < 4 || ipAddres.Split(".").Contains("00")) return false;
        return IPAddress.TryParse(ipAddres, out var ip);
    }

}