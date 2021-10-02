using System.Net;
using System.Text;

namespace LiquidSoap
{
    public class SoapListener
    {
        private HttpListener _httpListener;
        private bool _stop;

        public SoapListener(string[] urls)
        {
            _httpListener = new HttpListener();
            foreach (string url in urls)
            {
                _httpListener.Prefixes.Add(url);
            }
        }
        
        
    }
}