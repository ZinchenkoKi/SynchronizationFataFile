using System;
using PathFile;
using SynchronizationDataFile.Indications;

namespace SynchronizationDataFile
{
    public class Record
    {
        PathFile.Path path = new PathFile.Path();
        public void RecordFile(LocalFile localFile)
        {
            using (StreamWriter writer = new StreamWriter(path.GettingPath()))
            {
                writer.WriteLine(localFile.Hours);
                writer.WriteLine(localFile.Minutes);
                writer.WriteLine(localFile.Seconds);
            }
        }
    }
}
