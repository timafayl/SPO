#region

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

#endregion

namespace TravelingSuccessCalculationView
{
    [Serializable]
    public class RecentFiles
    {
        #region - Private fields -

        private List<string> _recentFiles = new List<string>();

        private string _path = Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "recentFiles.txt");

        #endregion

        public List<string> GetRecentFilesList()
        {
            return _recentFiles.ToList();
        }

        public void AddToRecentFiles(string filePath)
        {
            if (filePath != null)
            {
                if (_recentFiles.Contains(filePath))
                    _recentFiles.RemoveAt(_recentFiles.IndexOf(filePath));
                _recentFiles.Insert(0, filePath);
                if (_recentFiles.Count > 4)
                    for (var i = 4; i < _recentFiles.Count; i++)
                        _recentFiles.RemoveAt(i);
            }
        }

        public void RecentFilesSerialize()
        {
            Serializer.Serialize(_recentFiles, _path);
        }

        public void RecentFilesDeserialize()
        {
            Serializer.Deserialize(ref _recentFiles, _path);
        }
    }
}