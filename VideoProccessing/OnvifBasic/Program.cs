using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Text;

namespace OnvifBasic
{
    class OnvifDevice
    {
        static UriBuilder deviceUri;
        static onvif.Media2Client media;
        static onvif.MediaProfile[] profiles;

        List<string> profileList = new List<string>();
        String[] prms = { };

        static string _host, _admin, _password, _uriString;


        public OnvifDevice(string host, string admin, string password, string uriString)
        {
            _host = host;
            _admin = admin;
            _password = password;
            _uriString = uriString;
        }


        public void RunOnvif()
        {
            deviceUri = new UriBuilder(_uriString);
            string[] add = _host.Split(':');
            deviceUri.Host = add[0];

            if (add.Length == 2)
                deviceUri.Port = Convert.ToInt32(add[1]);

            Binding binding;
            HttpTransportBindingElement httpTransport = new HttpTransportBindingElement();
            httpTransport.AuthenticationScheme = System.Net.AuthenticationSchemes.Digest;
            binding = new CustomBinding(new TextMessageEncodingBindingElement(MessageVersion.Soap12WSAddressing10, Encoding.UTF8), httpTransport);

            device.DeviceClient device = new device.DeviceClient(binding, new EndpointAddress($"http://{_host}/onvif/device_service"));
            device.Service[] services = device.GetServices(false);

            device.Service xmedia = services.FirstOrDefault(s => s.Namespace == "http://www.onvif.org/ver20/media/wsdl");

            if (xmedia != null)
            {
                media = new onvif.Media2Client(binding, new EndpointAddress(xmedia.XAddr));
                media.ClientCredentials.HttpDigest.ClientCredential.UserName = _admin;
                media.ClientCredentials.HttpDigest.ClientCredential.Password = _password;
                media.ClientCredentials.HttpDigest.AllowedImpersonationLevel = System.Security.Principal.TokenImpersonationLevel.Impersonation;
                try
                {
                    profiles = media.GetProfiles(null, null);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"{ex}");
                }


                if (profiles != null)
                {
                    foreach (var p in profiles)
                    {
                        profileList.Add(p.Name.ToString());
                        //Console.WriteLine(p.Name);
                    }
                }

            }

        }

        public List<string> GetProfiles()
        {
            return profileList;
        }


        public void RunStreamer(String[] recordParams)
        {
            UriBuilder uri = new UriBuilder(media.GetStreamUri("RtspOverHttp", profiles[1].token));
            uri.Host = deviceUri.Host;
            uri.Port = deviceUri.Port;
            uri.Scheme = "rtsp";

            Console.WriteLine($"rstp://{uri.Host}:{uri.Port}/{uri.Path}");

            List<string> options = new List<string>();
            options.Add(":rtsp-http");
            options.Add(":rtsp-http-port=" + uri.Port);
            options.Add(":rtsp-user=" + _admin);
            options.Add(":rtsp-pwd=" + _password);

            if (recordParams.Length != 0)
            {
                foreach (string param in recordParams)
                {
                    options.Add(param);
                }
            }
        }

        public void GetStreamer()
        {
            RunStreamer(prms);
        }

    }

    class Program
    {


        static void Main(string[] args)
        {
            var deviceUriString = "http://onvif/device_service";
            string username = "admin";
            string password = "97315star";
            string address = "220.130.148.107:80";

            OnvifDevice onvifDevice = new OnvifDevice(address, username, password, deviceUriString);
            onvifDevice.RunOnvif();
            List<string> profiles =  onvifDevice.GetProfiles();
    



            foreach (var p in profiles) Console.WriteLine(p);

            onvifDevice.GetStreamer();

            Console.ReadLine();
        }
    }
}


//var profileList = new List<string>();

//deviceUri = new UriBuilder("http://onvif/device_service");
//string _username = "admin";
//string _password = "97315star";
//string address = "220.130.148.107:80";
//string[] add = address.Split(':');
//deviceUri.Host = add[0];

//if (add.Length == 2)
//    deviceUri.Port = Convert.ToInt32(add[1]);

//Binding binding;
//HttpTransportBindingElement httpTransport = new HttpTransportBindingElement();
//httpTransport.AuthenticationScheme = System.Net.AuthenticationSchemes.Digest;
//binding = new CustomBinding(new TextMessageEncodingBindingElement(MessageVersion.Soap12WSAddressing10, Encoding.UTF8), httpTransport);

//device.DeviceClient device = new device.DeviceClient(binding, new EndpointAddress($"http://{address}/onvif/device_service"));
//device.Service[] services = device.GetServices(false);

//device.Service xmedia = services.FirstOrDefault(s => s.Namespace == "http://www.onvif.org/ver20/media/wsdl");

//if (xmedia != null)
//{
//    media = new onvif.Media2Client(binding, new EndpointAddress(xmedia.XAddr));
//    media.ClientCredentials.HttpDigest.ClientCredential.UserName = _username;
//    media.ClientCredentials.HttpDigest.ClientCredential.Password = _password;
//    media.ClientCredentials.HttpDigest.AllowedImpersonationLevel = System.Security.Principal.TokenImpersonationLevel.Impersonation;
//    try
//    {
//        profiles = media.GetProfiles(null, null);
//    }
//    catch (Exception ex)
//    {
//        Console.WriteLine($"{ex}");
//    }


//    if (profiles != null)
//    {
//        foreach (var p in profiles)
//        {
//            profileList.Add(p.ToString());
//            Console.WriteLine(p.Name);
//        }
//    }

//}