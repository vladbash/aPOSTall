using System;

namespace aPOSTall.BL.ServiceTrackChecker.ServiceList
{
    interface IServiceProto
    {
        void CheckLocation();
        string TrackNumber { get; set; }
        string CurrentLocation { get; set; }
    }
}
