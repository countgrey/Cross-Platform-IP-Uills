using System.Net.NetworkInformation;
using System.Text;

namespace IPUills;

internal class PingSomething
{

    public static string PingCurrentAddress()
    {
        Ping ping = new();
        PingOptions options = new()
        {
            DontFragment = true
        };

        string data = "********************************";
        byte[] buffer = Encoding.ASCII.GetBytes(data);
        int timeout = 120;
        PingReply reply;

        if (IpAddressOperations.Address != " ")
        {
            reply = ping.Send(IpAddressOperations.Address, timeout, buffer, options);
            if (reply.Status == IPStatus.Success)
            {
                return $"Address: {reply.Address}      RoundTrip time: {reply.RoundtripTime} ms";
            }
        }

        

        return "Error";
    }
}
