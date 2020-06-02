using Implem.Pleasanter.Libraries.Requests;
using Implem.Pleasanter.Models;
using System;
using System.Linq;
using System.Net;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;
namespace Implem.Pleasanter.Libraries.DataSources
{
    public class Mediline
    {
        public Context context;
        public string message;

        public Mediline(Context _context, string _message)
        {
            message = _message;
            context = _context;
        }

        public void Send(string address)
        {
            foreach (var url in address.Split(',').Select(x => x.Trim()))
            {
                Task.Run(() =>
                {
                    try
                    {
                        /// Sort out the SSL/TLS error.
                        ServicePointManager.ServerCertificateValidationCallback += (Send, ValidateRemoteCertificate, chain, sslPolicyErrors) => { return true; };

                        using (var client = new WebClient())
                        {
                            string json = Newtonsoft.Json.JsonConvert.SerializeObject(new { message });
                            client.Headers[HttpRequestHeader.ContentType] = "application/json;charset=UTF-8";
                            client.Headers[HttpRequestHeader.Accept] = "application/json";
                            client.Encoding = Encoding.UTF8;
                            client.UploadString(url, "POST", json);
                        }
                    }
                    catch (Exception e)
                    {
                        new SysLogModel(context, e);
                    }
                });
            }
        }
    }
}
