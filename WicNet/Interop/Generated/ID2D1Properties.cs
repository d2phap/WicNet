﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d2d1_1.h(1024,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    /// <summary>
    /// Represents a set of run-time bindable and discoverable properties that allow a data-driven application to modify the state of a Direct2D effect.
    /// </summary>
    [ComImport, Guid("483473d7-cd46-4f9d-9d3a-3112aa80159d"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID2D1Properties
    {
        [PreserveSig]
        int GetPropertyCount();
        
        [PreserveSig]
        HRESULT GetPropertyName(int index, /* _Out_writes_(nameCount) */ [MarshalAs(UnmanagedType.LPWStr)] string name, int nameCount);
        
        [PreserveSig]
        int GetPropertyNameLength(int index);
        
        [PreserveSig]
        D2D1_PROPERTY_TYPE GetType(int index);
        
        [PreserveSig]
        int GetPropertyIndex(/* _In_ */ [MarshalAs(UnmanagedType.LPWStr)] string name);
        
        [PreserveSig]
        HRESULT SetValueByName(/* _In_ */ [MarshalAs(UnmanagedType.LPWStr)] string name, D2D1_PROPERTY_TYPE type, /* _In_reads_(dataSize) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 3)] byte[] data, int dataSize);
        
        [PreserveSig]
        HRESULT SetValue(int index, D2D1_PROPERTY_TYPE type, /* _In_reads_(dataSize) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 3)] byte[] data, int dataSize);
        
        [PreserveSig]
        HRESULT GetValueByName(/* _In_ */ [MarshalAs(UnmanagedType.LPWStr)] string name, D2D1_PROPERTY_TYPE type, /* _Out_writes_(dataSize) */ [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 3)] byte[] data, int dataSize);
        
        [PreserveSig]
        HRESULT GetValue(int index, D2D1_PROPERTY_TYPE type, /* _Out_writes_(dataSize) */ [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 3)] byte[] data, int dataSize);
        
        [PreserveSig]
        int GetValueSize(int index);
        
        [PreserveSig]
        HRESULT GetSubProperties(int index, /* _COM_Outptr_result_maybenull_ */ out ID2D1Properties subProperties);
    }
}
