namespace RobotControlSystem.Models
{
    public class PushTaskInfoRequest
    {
        public TaskChainPo taskChainPo { get; set; }
        public TaskPo taskPo { get; set; }
    }

    public class TaskChainPo
    {
        public long id { get; set; }
        public long areaId { get; set; }
        public string? name { get; set; }
        public long createTime { get; set; }
        public long? amrId { get; set; }
        public long? finishTime { get; set; }
        public int status { get; set; }
    }

    public class TaskPo
    {
        public long? id { get; set; }
        public string? taskType { get; set; }
        public string? endPointCode { get; set; }
        public long? mapId { get; set; }
        public int? status { get; set; }
        public long? startTime { get; set; }
        public long? finishTime { get; set; }
        public int? loading { get; set; }
        public string? extend { get; set; }
    }

    public class PushTaskInfoResponse
    {
        public string receive { get; set; }
    }

    public class GetMapVertexesRequest
    {
        public long mapId { get; set; }
    }

    public class GetMapVertexesResponse
    {
        public long id { get; set; }
        public string code { get; set; }
        public string alias { get; set; }
        public string description { get; set; }
        public double x { get; set; }
        public double y { get; set; }
        public double theta { get; set; }
        public int type { get; set; }
        public int loading { get; set; }
        public int docking_direction { get; set; }
        public double docking_x { get; set; }
        public double docking_y { get; set; }
        public double docking_theta { get; set; }
        public double outbound_x { get; set; }
        public double outbound_y { get; set; }
        public double outbound_theta { get; set; }
        public int force_load { get; set; }
        public double reloc_threshold { get; set; }
        public int forbidden_back { get; set; }
        public int allow_park { get; set; }
        public string extend { get; set; }
        public long map_id { get; set; }
    }
}
