﻿using System;
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
                float.TryParse(sx, out float fx);

                float.TryParse(sy, out float fy);

                if (!invertOrder)
                    returnVal = fx.CompareTo(fy);
                else returnVal = fy.CompareTo(fx);
            }
            else if (col == 4)
            {
                DateTime dtx = DateTime.MinValue;
                DateTime.TryParse(sx, out dtx);
                DateTime dty = DateTime.MinValue;
                DateTime.TryParse(sy, out dty);

                if (!invertOrder)
                    returnVal = dtx.CompareTo(dty);
                else returnVal = dty.CompareTo(dtx);

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