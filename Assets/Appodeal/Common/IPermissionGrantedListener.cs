﻿using System.Diagnostics.CodeAnalysis;

namespace AppodealAds.Unity.Common
{
    [SuppressMessage("ReSharper", "InconsistentNaming")]
    [SuppressMessage("ReSharper", "UnusedMemberInSuper.Global")]
    public interface IPermissionGrantedListener
    {
        void writeExternalStorageResponse(int result);
        void accessCoarseLocationResponse(int result);
    }
}