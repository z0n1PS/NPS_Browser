using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

[System.Serializable]
public class History
{

    public static History I
    {
        get
        {
            if (_i == null)
            {
                Load();
            }
            return _i;
        }
    }

    static History _i;
    public const int ver = 1;
    public List<NPS.DownloadWorker> currentlyDownloading = new List<NPS.DownloadWorker>();
    public List<NPS.Item> completedDownloading = new List<NPS.Item>();

    static string path = "history.dat";

    public static void Load()
    {
        if (System.IO.File.Exists(path))
        {
            var stream = File.OpenRead(path);
            var formatter = new BinaryFormatter();
            _i = (History)formatter.Deserialize(stream);
            stream.Close();
        }
        else _i = new History();
    }

    public void Save()
    {
        FileStream stream = File.Create(path);
        var formatter = new BinaryFormatter();
        formatter.Serialize(stream, this);
        stream.Close();
    }


}




