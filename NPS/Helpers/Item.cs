using System.Linq;

namespace NPS
{
    public class Item
    {
        public string TitleId, Region, TitleName, zRfi, pkg;
        public System.DateTime lastModifyDate = System.DateTime.MinValue;
        public int DLCs = 0;

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
            this.DLCs = 0;
            foreach (Item i in dlcDbs)
            {
                if (i.Region == this.Region && i.TitleId.Contains(this.TitleId))
                {
                    this.DLCs++;
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
    }


}
