namespace TravelingSuccessCalculationView
{
    public class RecentFiles
    {
        private string _recentItem;
        private string _recentFilePath;

        public string RecentItem
        {
            get { return _recentItem; }
            set { _recentItem = value; }
        }

        public string RecentFilePath
        {
            get { return _recentFilePath; }
            set { _recentFilePath = value; }
        }

        public RecentFiles(string recentItem, string recentFilePath)
        {
            RecentItem = recentItem;
            RecentFilePath = recentFilePath;
        }
    }
}
