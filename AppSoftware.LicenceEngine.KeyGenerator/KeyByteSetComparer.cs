﻿#region usings

using System;
using System.Collections;

using AppSoftware.LicenceEngine.Common;

#endregion

namespace AppSoftware.LicenceEngine.KeyGenerator
{
    public class KeyByteSetComparer : IComparer
    {
        public int Compare(object x, object y)
        {
            KeyByteSet kbs1 = (KeyByteSet) x;
            KeyByteSet kbs2 = (KeyByteSet) y;

            if (kbs1 == null || kbs2 == null)
            {
                throw new ArgumentNullException();
            }

            if (kbs1.KeyByteNo > kbs2.KeyByteNo)
            {
                return 1;
            }

            if (kbs1.KeyByteNo < kbs2.KeyByteNo)
            {
                return -1;
            }

            return 0;
        }
    }
}
