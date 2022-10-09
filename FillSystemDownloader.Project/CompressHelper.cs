using Ionic.Zip;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FillSystemDownloader.Project
{
    /// <summary>
    /// 压缩包解压类
    /// </summary>
    public class CompressHelper
    {
        //public static void Decompression(string fileName)
        //{
        //    FileInfo fileInfo = new FileInfo(fileName);

        //    using (Stream stream = File.OpenRead(fileName))
        //    {
        //        var reader = ReaderFactory.Open(stream);
        //        while (reader.MoveToNextEntry())
        //        {
        //            if (!reader.Entry.IsDirectory)
        //            {
        //                reader.WriteEntryToDirectory(fileInfo.DirectoryName);
        //            }
        //        }
        //    }
        //}

        /// <summary>
        /// 解压压缩文件
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public static bool Decompression(String fileName)
        {
            try
            {
                FileInfo fileInfo = new FileInfo(fileName);
                Encoding encoding = Encoding.GetEncoding("GBK");

                var options = new ReadOptions { StatusMessageWriter = System.Console.Out, Encoding = encoding };
                using (ZipFile zip = ZipFile.Read(fileName, options))
                {
                    zip.AlternateEncoding = encoding;
                    foreach (var f in zip.Entries)
                    {
                        //一个个解压
                        f.Extract(fileInfo.DirectoryName, ExtractExistingFileAction.OverwriteSilently);
                    }

                    return true;
                }
            }
            catch (Exception ex)
            {

                return false;
            }
        }
    }
}
