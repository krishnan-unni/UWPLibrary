using System;
using System.Threading.Tasks;
using Windows.Storage;

namespace UWPLibrary
{
    public class FileAccessor
    {
        public async Task CreateFile(string filename)
        {
            StorageFolder storageFolder = ApplicationData.Current.LocalFolder;
            await storageFolder.CreateFileAsync(filename, CreationCollisionOption.ReplaceExisting);

        }

        public async Task WriteToFile(string filename, string data)
        {
            StorageFolder storageFolder = ApplicationData.Current.LocalFolder;
            StorageFile sampleFile = await storageFolder.GetFileAsync(filename);
            await FileIO.WriteTextAsync(sampleFile, data);
        }

        public async Task<string> ReadFromFile(string filename)
        {
            StorageFolder storageFolder = ApplicationData.Current.LocalFolder;
            StorageFile sampleFile = await storageFolder.GetFileAsync(filename);
            string text = await FileIO.ReadTextAsync(sampleFile);
            return text;
        }
    }
}
