using System.Collections.Generic;
using System.Linq;

namespace NPS
{
    public class Item
    {
        public string TitleId, Region, TitleName, zRfi, pkg, DownloadDir;
        public System.DateTime lastModifyDate = System.DateTime.MinValue;
        public int DLCs { get { return DlcItm.Count; } }
        public List<Item> DlcItm = new List<Item>();

        public Item(string TitleId, string Region, string TitleName, string pkg, string zrif)
        {
            this.TitleId = TitleId;
            this.Region = Region;
            this.TitleName = TitleName;
            this.pkg = pkg;
            this.zRfi = zrif;
        }

        public void CalculateDlCs(Item[] dlcDbs)
        {
            //this.DLCs = 0;

            foreach (Item i in dlcDbs)
            {
                if (i.Region == this.Region && i.TitleId.Contains(this.TitleId))
                {
                    this.DlcItm.Add(i);
                    //this.DLCs++;
                }
            }
        }

        public bool CompareName(string name)
        {
            name = name.ToLower();

            if (this.TitleId.ToLower().Contains(name)) return true;
            if (this.TitleName.ToLower().Contains(name)) return true;
            return false;
        }

        public void setDownloadDir(string downloadDir)
        {
            this.DownloadDir = downloadDir;
        }
    }


}
