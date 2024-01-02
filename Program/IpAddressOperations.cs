namespace IPUills;

internal class IpAddressOperations
{
    private static string address = "8.8.8.8";

    public static string Address
    {
        get
        {
            return address;
        }
        
        set
        {
            if (verify(value))
            {
                address = value;
            }

            else
            {
                address = " ";
            }
        } 
    }

    private static bool verify(string str)
    {
        if (str.Contains('.'))
        {
            string[] addr = str.Split('.');
            if (addr.Length == 2)
            {
                if (!(addr[1].Any(char.IsDigit) || addr[1].Contains(' ')))
                {
                    return true;
                }
            }

            if (addr.Length == 4)
            {
                bool cool = true;
                foreach (string s in addr)
                {
                    if (s.Contains(' ') || s.Any(char.IsLetter)) 
                    {
                        cool = false;
                    }
                }
                return cool;
            }
        }

        return false;
    }
}