using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Settings
{
    const string userRoot = "HKEY_CURRENT_USER\\SOFTWARE";
    const string subkey = "NoPayStationBrowser";
    const string keyName = userRoot + "\\" + subkey;

    public static Settings instance;

    public string downloadDir;
    public string pkgPath;
    public string pkgParams;
    public string GamesUri, DLCUri, PSMUri;
    public bool deleteAfterUnpack = false;
    public int simultaneousDl = 2;

    public int records
    {
        get { return _records; }
        set
        {
            _records = value;
            Registry.SetValue(keyName, "records", value);
        }
    }

    int _records = 0;

    public Settings()
    {
        instance = this;
        //defaultRegion = Registry.GetValue(keyName, "region", "ALL")?.ToString();
        downloadDir = Registry.GetValue(keyName, "downloadDir", "")?.ToString();
        pkgPath = Registry.GetValue(keyName, "pkgPath", "")?.ToString();
        GamesUri = Registry.GetValue(keyName, "GamesUri", "")?.ToString();
        DLCUri = Registry.GetValue(keyName, "DLCUri", "")?.ToString();
        PSMUri = Registry.GetValue(keyName, "PSMUri", "")?.ToString();
        pkgParams = Registry.GetValue(keyName, "pkgParams", null)?.ToString();



        string simultanesulString = Registry.GetValue(keyName, "simultaneousDl", 2)?.ToString();

        if (!string.IsNullOrEmpty(simultanesulString))
            int.TryParse(simultanesulString, out simultaneousDl);
        else simultaneousDl = 2;

        string deleteAfterUnpackString = Registry.GetValue(keyName, "deleteAfterUnpack", false)?.ToString();
        if (!string.IsNullOrEmpty(deleteAfterUnpackString))
            bool.TryParse(deleteAfterUnpackString, out deleteAfterUnpack);
        else deleteAfterUnpack = true;

        var rec = Registry.GetValue(keyName, "records", null)?.ToString();
        if (rec != null) int.TryParse(rec, out _records);

        if (pkgParams == null) pkgParams = "{pkgFile} --make-dirs=ux --license=\"{zRifKey}\"";


    }

    public void Store()
    {
        if (downloadDir != null)
            Registry.SetValue(keyName, "downloadDir", downloadDir);
        if (pkgPath != null)
            Registry.SetValue(keyName, "pkgPath", pkgPath);
        if (pkgParams != null)
            Registry.SetValue(keyName, "pkgParams", pkgParams);

        if (GamesUri != null)
            Registry.SetValue(keyName, "GamesUri", GamesUri);
        if (DLCUri != null)
            Registry.SetValue(keyName, "DLCUri", DLCUri);

        if (PSMUri != null)
            Registry.SetValue(keyName, "PSMUri", PSMUri);

        Registry.SetValue(keyName, "deleteAfterUnpack", deleteAfterUnpack);

        Registry.SetValue(keyName, "simultaneousDl", simultaneousDl);
    }





}
