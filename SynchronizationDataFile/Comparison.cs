using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SynchronizationDataFile.Indications;

namespace SynchronizationDataFile
{
    public class Comparison
    {
        public bool ComparisonData(GoogleDriveFile googleDriveFile, LocalFile localFile)
        {
            if(googleDriveFile.Hours > localFile.Hours) return true;
            return false;
        }
    }
}
