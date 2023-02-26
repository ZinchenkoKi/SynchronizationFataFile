using System;
using SynchronizationDataFile.Indications;
using PathFile;
using System.Net;

namespace SynchronizationDataFile
{
    public class ReadingFile
    {
        PathFile.Path localPath = new PathFile.Path();
        public LocalFile Reading(LocalFile localFile)
        {
            using (StreamReader reader = new StreamReader(localPath.GettingPath()))
            {
                localFile.Hours = Convert.ToInt32(reader.ReadLine());
                localFile.Minutes = Convert.ToInt32(reader.ReadLine());
                localFile.Seconds = Convert.ToInt32(reader.ReadLine());
            }
                return localFile;
        }

        public GoogleDriveFile Reading(GoogleDriveFile googleDriveFile, string fileId)
        {
            if (fileId == null) 
            {
                throw new ArgumentNullException();
            }
            string path = "StopwatchData.txt";
            string uriString = $"https://drive.google.com/uc?export=download&id={fileId}";
            WebClient myWebClient = new WebClient();
            myWebClient.DownloadFile(uriString, path);
            Stream myStreamReader = myWebClient.OpenRead(uriString);
          
            using (StreamReader reader = new StreamReader(path))
            {
                googleDriveFile.Hours = Convert.ToInt32(reader.ReadLine());
                googleDriveFile.Minutes = Convert.ToInt32(reader.ReadLine());
                googleDriveFile.Seconds = Convert.ToInt32(reader.ReadLine());
            }
            return googleDriveFile;
        }
    }
}
