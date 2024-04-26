namespace RobotControlSystem.Models
{
    public class OnlineAmrResponse
    {
        public string errMsg { get; set; }
        public string errCode { get; set; }
        public bool state { get; set; }
        public List<AmrData> data { get; set; }
    }

    public class AmrData
    {
        public AmrException amrException { get; set; }
        public long areaId { get; set; }
        public double batteryPercentile { get; set; }
        public Coordinate coordinate { get; set; }
        public string id { get; set; }
        public string ip { get; set; }
        public long mapId { get; set; }
        public string name { get; set; }
        public string mapName { get; set; }
        public string state { get; set; }
        public long stateId { get; set; }
    }

    public class AmrException
    {
        public List<string>? exception { get; set; }
        public long? level { get; set; }
    }

    public class Coordinate
    {
        public double theta { get; set; }
        public double x { get; set; }
        public double y { get; set; }
    }

    public class AmrTaskCommandPauseRequest
    {
        public long amrId { get; set; }
    }

    public class AmrTaskCommandPauseResponse
    {
        public string errMsg { get; set; }
        public string errCode { get; set; }
        public bool state { get; set; }
        public string data { get; set; }
    }

    public class AmrTaskCommandResumeReqeust
    {
        public long amrId { get; set; }
    }

    public class AmrTaskCommandResumeResponse
    {
        public string errMsg { get; set; }
        public string errCode { get; set; }
        public bool state { get; set; }
        public string data { get; set; }
    }
}
