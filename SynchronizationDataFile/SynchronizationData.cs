using System;
using SynchronizationDataFile.Indications;

namespace SynchronizationDataFile
{
    public class SynchronizationData
    {
        LocalFile localFile = new LocalFile();
        GoogleDriveFile googleDriveFile = new GoogleDriveFile();
        Comparison comparison = new Comparison();
        UpdatingIndicators updatingIndicators = new UpdatingIndicators();
        ReadingFile readingFile = new ReadingFile();
        Record record = new Record();
        public void Synchronization()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Введите Id файла из Гугл диска.");
            string fileId = Console.ReadLine();
            Console.WriteLine("Загрузка...");
            SynchronizationFile(fileId);
        }

        private void SynchronizationFile(string fileId)
        {
           Console.ForegroundColor = ConsoleColor.Green;
           Console.WriteLine("\n\tДанные на Гугл диске:");
           googleDriveFile = readingFile.Reading(googleDriveFile, fileId);
           Console.WriteLine($"\tЧасы - {googleDriveFile.Hours}\n\tМинуты - {googleDriveFile.Minutes} \n\tСекунды - {googleDriveFile.Seconds}");
           Console.WriteLine("\n\tЛокальные данные:");
           localFile = readingFile.Reading(localFile);
           Console.WriteLine($"\tЧасы - {localFile.Hours}\n\tМинуты - {localFile.Minutes} \n\tСекунды - {localFile.Seconds}");
          
          
           bool flag = comparison.ComparisonData(googleDriveFile, localFile);
           if (flag) 
           {
                localFile = updatingIndicators.Update(googleDriveFile, localFile);
                record.RecordFile(localFile);
           }
        }
    }
}
