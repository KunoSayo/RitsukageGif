﻿using System;
using System.Runtime.InteropServices;

namespace RitsukageGif.Native
{
    internal class DwmApi
    {
        private const string DllName = "dwmapi.dll";

        [DllImport(DllName)]
        public static extern int DwmGetWindowAttribute(IntPtr window, int attribute, out bool value, int size);

        [DllImport(DllName)]
        public static extern int DwmGetWindowAttribute(IntPtr window, int attribute, ref Rect value, int size);
    }
}
