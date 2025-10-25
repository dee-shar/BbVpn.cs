# BbVpn.cs
Mobile-API for [BBVpn](https://play.google.com/store/apps/details?id=bbv.avdev.bbvpn) completely unlimited and free VPN client for Android devices that allows you to unblock geo-restricted websites and apps

## Example
```cs
using System;
using BbVpnApi;

namespace Application
{
    internal class Program
    {
        static async Task Main()
        {
            var api = new BbVpn();
            string servers = await api.GetServers("token");
            Console.WriteLine(servers);
        }
    }
}
```
