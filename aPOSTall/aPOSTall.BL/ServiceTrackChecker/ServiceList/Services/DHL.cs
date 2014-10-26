using System;
using xNet.Net;
using xNet.Text;

namespace aPOSTall.BL.ServiceTrackChecker.ServiceList.Services
{
    class Dhl:IServiceProto
    {
        public Dhl(string track)
        {
            TrackNumber = track;
        }
        public string TrackNumber { get; set; }
        public string CurrentLocation { get; set; }

        public void CheckLocation()
        {
            try
            {
                using (var request = new HttpRequest())
                {
                    request.UserAgent = HttpHelper.RandomUserAgent();

                }
            }
            catch
            {
            }
        }
    }
}
