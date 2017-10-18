using System;
using System.Collections;
using System.Windows.Forms;

namespace NPS
{
    class ListViewItemComparer : IComparer
    {
        private int col;
        private bool invertOrder = false;
        public ListViewItemComparer()
        {
            col = 0;
        }
        public ListViewItemComparer(int column, bool invertedOrder)
        {
            col = column;
            invertOrder = invertedOrder;

        }
        public int Compare(object x, object y)
        {
            int returnVal = -1;

            string sx = ((ListViewItem)x).SubItems[col].Text;
            string sy = ((ListViewItem)y).SubItems[col].Text;

            if (col == 3)
            {
                float fx = 0;
                float.TryParse(sx, out fx);

                float fy = 0;
                float.TryParse(sy, out fy);

                if (!invertOrder)
                    returnVal = fx.CompareTo(fy);
                else returnVal = fy.CompareTo(fx);
            }
            else
            {
                if (!invertOrder)
                    returnVal = String.Compare(sx, sy);
                else
                    returnVal = String.Compare(sy, sx);
            }
            return returnVal;
        }
    }


}
