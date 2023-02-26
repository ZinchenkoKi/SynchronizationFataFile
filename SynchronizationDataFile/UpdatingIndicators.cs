using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SynchronizationDataFile.Indications;

namespace SynchronizationDataFile
{
    public class UpdatingIndicators
    {
        public LocalFile Update(GoogleDriveFile googleDriveFile, LocalFile localFile)
        {
            localFile.Hours = googleDriveFile.Hours;
            localFile.Minutes = googleDriveFile.Minutes;
            localFile.Seconds = googleDriveFile.Seconds;
            return localFile;
        }
    }
}
