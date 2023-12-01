namespace RobotControlSystem.Models
{
    public class ReassignTasks
    {
        public string taskType { get; set; }
        public long mapId { get; set; }
        public string endPointCode { get; set; }
    }

    public class ReassignByAmrIdRequest
    {
        public long amrId { get; set; }
        public double? sequence { get; set; }
        public bool isRetained { get; set; }
        public ReassignTasks reassignTasks { get; set; }
    }

    public class ReassignByAmrIdResponse
    {
        public string errMsg { get; set; }
        public string errCode { get; set; }
        public bool state { get; set; }
        public ulong data { get; set; }
    }

    public class ReassignByTaskChainIdRequest
    {
        public long taskChainId { get; set; }
        public double? sequence { get; set; }
        public bool isRetained { get; set; }
        public ReassignTasks reassignTasks { get; set; }
    }

    public class ReassignByTaskChainIdResponse
    {
        public string errMsg { get; set; }
        public string errCode { get; set; }
        public bool state { get; set; }
    }

    public class EndFinishPauseIsFalseTaskRequest
    {
        public long id { get; set; }
    }

    public class EndFinishPauseIsFalseTaskResponse
    {
        public string errMsg { get; set; }
        public string errCode { get; set; }
        public bool state { get; set; }
    }
}
