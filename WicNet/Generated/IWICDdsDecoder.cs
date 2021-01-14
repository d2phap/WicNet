﻿// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\wincodec.h(7831,5)
using System;
using System.Runtime.InteropServices;

namespace WicNet
{
    [Guid("409cd537-8532-40cb-9774-e2feb2df4e9c"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IWICDdsDecoder
    {
        [PreserveSig]
        HRESULT GetParameters(/* [out] __RPC__out */ out WICDdsParameters pParameters);
        
        [PreserveSig]
        HRESULT GetFrame(/* [in] */ uint arrayIndex, /* [in] */ uint mipLevel, /* [in] */ uint sliceIndex, /* [retval][out] __RPC__deref_out_opt */ out IWICBitmapFrameDecode ppIBitmapFrame);
    }
}
