﻿// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\ocidl.h(6017,9)
using System;
using System.Globalization;
using System.Runtime.InteropServices;
using WicNet;
using WicNet.Utilities;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct PROPBAG2
    {
        public PROPBAG2_TYPE dwType;
        public PropertyType vt;
        public ushort cfType;
        public uint dwHint;
        [MarshalAs(UnmanagedType.LPWStr)] 
        public string pstrName;
        public Guid clsid;

        public object ChangeType(object value)
        {
            object changed;
            switch (vt)
            {
                case PropertyType.VT_UI1:
                    changed = Conversions.ChangeType<byte>(value, CultureInfo.InvariantCulture);
                    break;

                case PropertyType.VT_UI2:
                    changed = Conversions.ChangeType<ushort>(value, CultureInfo.InvariantCulture);
                    break;

                case PropertyType.VT_UI4:
                    changed = Conversions.ChangeType<uint>(value, CultureInfo.InvariantCulture);
                    break;

                case PropertyType.VT_UI8:
                    changed = Conversions.ChangeType<ulong>(value, CultureInfo.InvariantCulture);
                    break;

                case PropertyType.VT_I1:
                    changed = Conversions.ChangeType<sbyte>(value, CultureInfo.InvariantCulture);
                    break;

                case PropertyType.VT_I2:
                    changed = Conversions.ChangeType<short>(value, CultureInfo.InvariantCulture);
                    break;

                case PropertyType.VT_I4:
                    changed = Conversions.ChangeType<int>(value, CultureInfo.InvariantCulture);
                    break;

                case PropertyType.VT_I8:
                    changed = Conversions.ChangeType<long>(value, CultureInfo.InvariantCulture);
                    break;

                case PropertyType.VT_BOOL:
                    changed = Conversions.ChangeType<bool>(value, CultureInfo.InvariantCulture);
                    break;

                case PropertyType.VT_R4:
                    changed = Conversions.ChangeType<float>(value, CultureInfo.InvariantCulture);
                    break;

                case PropertyType.VT_R8:
                    changed = Conversions.ChangeType<double>(value, CultureInfo.InvariantCulture);
                    break;

                case PropertyType.VT_LPSTR:
                case PropertyType.VT_LPWSTR:
                case PropertyType.VT_BSTR:
                    changed = Conversions.ChangeType<string>(value, CultureInfo.InvariantCulture);
                    break;

                case PropertyType.VT_DECIMAL:
                    changed = Conversions.ChangeType<decimal>(value, CultureInfo.InvariantCulture);
                    break;

                case PropertyType.VT_DATE:
                    changed = Conversions.ChangeType<DateTime>(value, CultureInfo.InvariantCulture).ToOADate();
                    break;

                case PropertyType.VT_FILETIME:
                    changed = Conversions.ChangeType<DateTime>(value, CultureInfo.InvariantCulture).ToFileTime();
                    break;

                case PropertyType.VT_CLSID:
                    changed = Conversions.ChangeType<Guid>(value, CultureInfo.InvariantCulture);
                    break;

                default:
                    throw new NotSupportedException();
            }
            return changed;
        }
    }
}
