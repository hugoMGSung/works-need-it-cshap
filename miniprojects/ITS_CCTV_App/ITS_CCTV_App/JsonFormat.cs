namespace ITS_CCTV_App
{
    public class CctvData
    {
        public string RoadsectionId { get; set; }
        public string CoordX { get; set; }
        public string CoordY { get; set; }
        public string CctvResolution { get; set; }
        public string FileCreateTime { get; set; }
        public string CctvType { get; set; }
        public string CctvFormat { get; set; }
        public string CctvName { get; set; }
        public string CctvUrl { get; set; }

        public override string ToString()
        {
            return string.Format($"{CctvName}");
        }
    }
}
