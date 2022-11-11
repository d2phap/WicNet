﻿using System;
using System.Runtime.InteropServices;

namespace WicNet
{
    [StructLayout(LayoutKind.Sequential)]
    public struct WicColor : IEquatable<WicColor>
    {
        public byte R;
        public byte G;
        public byte B;
        public byte A;

        public WicColor(byte r, byte g, byte b)
            : this(255, r, g, b)
        {
        }

        public WicColor(byte a, byte r, byte g, byte b)
        {
            A = a;
            R = r;
            G = g;
            B = b;
        }

        public int ToArgb()
        {
            var ui = (uint)A << 24 | (uint)R << 16 | (uint)G << 8 | B;
            return (int)ui;
        }

        public static WicColor FromArgb(int argb) => FromArgb(argb);
        public static WicColor FromArgb(uint argb) => new WicColor((byte)(argb >> 24), (byte)((argb >> 16) & 255), (byte)((argb >> 8) & 255), (byte)(argb & 255));
        public static WicColor FromArgb(int r, int g, int b) => FromArgb(255, (byte)r, (byte)g, (byte)b);
        public static WicColor FromArgb(int a, int r, int g, int b) => FromArgb((byte)a, (byte)r, (byte)g, (byte)b);
        public static WicColor FromArgb(byte r, byte g, byte b) => FromArgb(255, r, g, b);

        public override bool Equals(object obj) => obj is WicColor color && Equals(color);

        public bool Equals(WicColor other) => other.R == R && other.G == G && other.B == B & other.R == R;
        public override int GetHashCode() => R.GetHashCode() ^ G.GetHashCode() ^ B.GetHashCode() ^ A.GetHashCode();
        public override string ToString() => string.Format("#{0:X2}{1:X2}{2:X2}{3:X2}", A, R, G, B);

        public static bool operator ==(WicColor left, WicColor right) => left.Equals(right);
        public static bool operator !=(WicColor left, WicColor right) => !(left == right);
    }
}
