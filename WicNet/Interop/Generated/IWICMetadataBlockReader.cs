﻿// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\wincodecsdk.h(294,5)
using System;
using System.Runtime.InteropServices;

namespace WicNet.Interop
{
    [Guid("feaa2a8d-b3f3-43e4-b25c-d1de990a1ae1"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IWICMetadataBlockReader
    {
        [PreserveSig]
        HRESULT GetContainerFormat(/* [out] __RPC__out */ out Guid pguidContainerFormat);
        
        [PreserveSig]
        HRESULT GetCount(/* [out] __RPC__out */ out uint pcCount);
        
        [PreserveSig]
        HRESULT GetReaderByIndex(/* [in] */ uint nIndex, /* [out] __RPC__deref_out_opt */ out IWICMetadataReader ppIMetadataReader);
        
        [PreserveSig]
        HRESULT GetEnumerator(/* [out] __RPC__deref_out_opt */ out IntPtr ppIEnumMetadata);
    }
}
