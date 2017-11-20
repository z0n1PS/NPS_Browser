using Microsoft.Win32;

public class Settings
{
    const string userRoot = "HKEY_CURRENT_USER\\SOFTWARE";
    const string subkey = "NoPayStationBrowser";
    const string keyName = userRoot + "\\" + subkey;

    public static Settings Instance;

    public string downloadDir;
    public string pkgPath;
    public string pkgParams;
    public string GamesUri, DLCUri, PSMUri, PSXUri, PSPUri, PSPDLCUri;
    public bool deleteAfterUnpack = false;
    public int simultaneousDl = 2;



    int _records = 0;

    public Settings()
    {
        Instance = this;

        //defaultRegion = Registry.GetValue(keyName, "region", "ALL")?.ToString();
        downloadDir = Registry.GetValue(keyName, "downloadDir", "")?.ToString();
        pkgPath = Registry.GetValue(keyName, "pkgPath", "")?.ToString();
        GamesUri = Registry.GetValue(keyName, "GamesUri", "")?.ToString();
        DLCUri = Registry.GetValue(keyName, "DLCUri", "")?.ToString();
        PSXUri = Registry.GetValue(keyName, "PSXUri", "")?.ToString();
        PSMUri = Registry.GetValue(keyName, "PSMUri", "")?.ToString();
        PSPUri = Registry.GetValue(keyName, "PSPUri", "")?.ToString();
        PSPDLCUri = Registry.GetValue(keyName, "PSPDLCUri", "")?.ToString();
        pkgParams = Registry.GetValue(keyName, "pkgParams", null)?.ToString();

        string simultanesulString = Registry.GetValue(keyName, "simultaneousDl", 2)?.ToString();

        if (!string.IsNullOrEmpty(simultanesulString))
            int.TryParse(simultanesulString, out simultaneousDl);
        else simultaneousDl = 2;

        string deleteAfterUnpackString = Registry.GetValue(keyName, "deleteAfterUnpack", false)?.ToString();
        if (!string.IsNullOrEmpty(deleteAfterUnpackString))
            bool.TryParse(deleteAfterUnpackString, out deleteAfterUnpack);
        else deleteAfterUnpack = true;


        // if (pkgParams == null) pkgParams = "--make-dirs=ux --license=\"{zRifKey}\" {pkgFile} \"{gameTitle} ({region}) [{titleID}]\"";
        if (pkgParams == null) pkgParams = "-x {pkgFile} \"{zRifKey}\"";
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
        if (PSXUri != null)
            Registry.SetValue(keyName, "PSXUri", PSXUri);

        if (PSMUri != null)
            Registry.SetValue(keyName, "PSMUri", PSMUri);

        if (PSPUri != null)
            Registry.SetValue(keyName, "PSPUri", PSPUri);
        if (PSPDLCUri != null)
            Registry.SetValue(keyName, "PSPDLCUri", PSPDLCUri);
        Registry.SetValue(keyName, "deleteAfterUnpack", deleteAfterUnpack);

        Registry.SetValue(keyName, "simultaneousDl", simultaneousDl);
    }
}

