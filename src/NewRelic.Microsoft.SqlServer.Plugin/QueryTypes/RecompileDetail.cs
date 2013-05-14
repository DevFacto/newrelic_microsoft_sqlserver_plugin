using NewRelic.Microsoft.SqlServer.Plugin.Core;

namespace NewRelic.Microsoft.SqlServer.Plugin.QueryTypes
{
    [Query("RecompileDetail.sql", "Component/RecompileDetail/{MetricName}/{DatabaseName}", QueryName = "Recompile Detail", Enabled = false)]
    internal class RecompileDetail : RecompileQueryBase
    {
        public int BucketID { get; set; }
        public int UseCounts { get; set; }
        public int SizeInBytes { get; set; }
        public string ObjectType { get; set; }
        public string Text { get; set; }
    }
}
