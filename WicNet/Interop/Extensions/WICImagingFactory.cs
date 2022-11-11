﻿using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using WicNet.Utilities;

namespace DirectN
{
    public static class WICImagingFactory
    {
        public static IComObject<IWICPalette> CreatePalette() => WithFactory(f => f.CreatePalette());
        public static IComObject<IWICColorContext> CreateColorContext() => WithFactory(f => f.CreateColorContext());
        public static IComObject<IWICBitmapClipper> CreateBitmapClipper() => WithFactory(f => f.CreateBitmapClipper());
        public static IComObject<IWICBitmapFlipRotator> CreateBitmapFlipRotator() => WithFactory(f => f.CreateBitmapFlipRotator());
        public static IComObject<IWICBitmapScaler> CreateBitmapScaler() => WithFactory(f => f.CreateBitmapScaler());
        public static IComObject<IWICBitmap> CreateBitmap(int width, int height, Guid pixelFormat, WICBitmapCreateCacheOption option = WICBitmapCreateCacheOption.WICBitmapNoCache) => WithFactory(f => f.CreateBitmap(width, height, pixelFormat, option));
        public static IComObject<IWICBitmapDecoder> CreateDecoderFromFilename(string fileName, Guid? guidVendor = null, FileAccess desiredAccess = FileAccess.Read, WICDecodeOptions metadataOptions = WICDecodeOptions.WICDecodeMetadataCacheOnDemand) => WithFactory(f => f.CreateDecoderFromFilename(fileName, guidVendor, desiredAccess, metadataOptions));
        public static IComObject<IWICBitmapDecoder> CreateDecoderFromStream(IStream stream, Guid? guidVendor = null, WICDecodeOptions metadataOptions = WICDecodeOptions.WICDecodeMetadataCacheOnDemand) => WithFactory(f => f.CreateDecoderFromStream(stream, guidVendor, metadataOptions));
        public static IComObject<IWICBitmapDecoder> CreateDecoderFromFileHandle(IntPtr handle, Guid? guidVendor = null, WICDecodeOptions metadataOptions = WICDecodeOptions.WICDecodeMetadataCacheOnDemand) => WithFactory(f => f.CreateDecoderFromFileHandle(handle, guidVendor, metadataOptions));
        public static IComObject<IWICBitmapDecoder> CreateDecoderFromStream(Stream stream, Guid? guidVendor = null, WICDecodeOptions metadataOptions = WICDecodeOptions.WICDecodeMetadataCacheOnDemand) => WithFactory(f => f.CreateDecoderFromStream(new ManagedIStream(stream), guidVendor, metadataOptions));
        public static IComObject<IWICBitmapEncoder> CreateEncoder(Guid containerFormat) => WithFactory(f => f.CreateEncoder(containerFormat));
        public static IComObject<IWICBitmap> CreateBitmapFromHBITMAP(IntPtr bitmapHandle, WICBitmapAlphaChannelOption options = WICBitmapAlphaChannelOption.WICBitmapUseAlpha) => WithFactory(f => f.CreateBitmapFromHBITMAP(bitmapHandle, IntPtr.Zero, options));
        public static IComObject<IWICBitmap> CreateBitmapFromHBITMAP(IntPtr bitmapHandle, IntPtr paletteHandle, WICBitmapAlphaChannelOption options = WICBitmapAlphaChannelOption.WICBitmapUseAlpha) => WithFactory(f => f.CreateBitmapFromHBITMAP(bitmapHandle, paletteHandle, options));
        public static IComObject<IWICBitmap> CreateBitmapFromHICON(IntPtr iconHandle) => WithFactory(f => f.CreateBitmapFromHICON(iconHandle));
        public static IComObject<IWICBitmap> CreateBitmapFromMemory(int width, int height, Guid pixelFormat, int stride, byte[] buffer) => WithFactory(f => f.CreateBitmapFromMemory(width, height, pixelFormat, stride, buffer));
        public static IComObject<IWICBitmap> CreateBitmapFromSource(IComObject<IWICBitmapSource> source, WICBitmapCreateCacheOption option = WICBitmapCreateCacheOption.WICBitmapNoCache) => WithFactory(f => f.CreateBitmapFromSource(source?.Object, option));
        public static IComObject<IWICBitmap> CreateBitmapFromSourceRect(IComObject<IWICBitmapSource> source, int x, int y, int width, int height) => WithFactory(f => f.CreateBitmapFromSourceRect(source?.Object, x, y, width, height));
        public static IComObject<IWICImageEncoder> CreateImageEncoder(IComObject<ID2D1Device> device) => WithFactory2(f => f.CreateImageEncoder(device?.Object));

        public static IComObject<IWICColorContext>[] CreateColorContexts(int count) => WithFactory(f =>
        {
            if (count <= 0)
                throw new ArgumentOutOfRangeException(nameof(count));

            var colorContexts = new IComObject<IWICColorContext>[count];
            for (var i = 0; i < count; i++)
            {
                colorContexts[i] = f.CreateColorContext();
            }
            return colorContexts;
        });

        public static T WithFactory2<T>(Func<IWICImagingFactory2, T> func)
        {
            if (func == null)
                throw new ArgumentNullException(nameof(func));

            var factory = (IWICImagingFactory2)Activator.CreateInstance(Type.GetTypeFromCLSID(new Guid("CACAF262-9370-4615-A13B-9F5539DA4C0A")));
            try
            {
                return func(factory);
            }
            finally
            {
                Marshal.ReleaseComObject(factory);
            }
        }

        public static T WithFactory<T>(Func<IWICImagingFactory, T> func)
        {
            if (func == null)
                throw new ArgumentNullException(nameof(func));

            var factory = (IWICImagingFactory)Activator.CreateInstance(Type.GetTypeFromCLSID(new Guid("CACAF262-9370-4615-A13B-9F5539DA4C0A")));
            try
            {
                return func(factory);
            }
            finally
            {
                Marshal.ReleaseComObject(factory);
            }
        }

        public static void WithFactory2(Action<IWICImagingFactory2> action)
        {
            if (action == null)
                throw new ArgumentNullException(nameof(action));

            var factory = (IWICImagingFactory2)Activator.CreateInstance(Type.GetTypeFromCLSID(new Guid("CACAF262-9370-4615-A13B-9F5539DA4C0A")));
            try
            {
                action(factory);
            }
            finally
            {
                Marshal.ReleaseComObject(factory);
            }
        }

        public static void WithFactory(Action<IWICImagingFactory> action)
        {
            if (action == null)
                throw new ArgumentNullException(nameof(action));

            var factory = (IWICImagingFactory)Activator.CreateInstance(Type.GetTypeFromCLSID(new Guid("CACAF262-9370-4615-A13B-9F5539DA4C0A")));
            try
            {
                action(factory);
            }
            finally
            {
                Marshal.ReleaseComObject(factory);
            }
        }
    }
}
