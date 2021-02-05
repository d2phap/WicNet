﻿using System;

namespace WicNet.Tests
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var bmp = WicBitmapSource.Load(@"SamsungSGH-I777.jpg"))
            {
                var reader = bmp.GetMetadataReader();
                //var th = bmp.GetThumbnail();

                foreach (var kv in reader.Enumerate(true))
                {
                    Console.WriteLine(kv.Key + "=" + kv.Value);
                }
            }

            using (var decoder = WicBitmapDecoder.Load(@"SamsungSGH-I777.jpg"))
            {
                //Console.WriteLine(decoder.GetMetadataQueryReader());
            }
        }
    }
}
