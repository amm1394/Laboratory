using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Classes
{
    public static class Compressor
    {
        public static List<CompressedFile> CompressFile(String SoureFilePath, String OutputFileName)
        {
            List<CompressedFile> Files = new List<CompressedFile>();
            Xceed.Zip.Licenser.LicenseKey = "ZIN54-KHDSY-HSD01-RGGA";
            Xceed.FileSystem.AbstractFolder dest = new Xceed.FileSystem.DiskFolder(String.Format("{0}Zipoutput\\", System.IO.Path.GetTempPath()));

            Xceed.Zip.ZipArchive archive = new Xceed.Zip.ZipArchive(dest.GetFile(String.Format("{0}.zip", OutputFileName)));
            archive.SplitSize = 9 * 1024 * 1024;
            archive.SplitNameFormat = Xceed.Zip.SplitNameFormat.WinZip;

            Xceed.FileSystem.AbstractFolder Source = new Xceed.FileSystem.DiskFolder(SoureFilePath);
            foreach (Xceed.FileSystem.AbstractFile file in Source.GetFiles(false, "*.Pdf"))
            {
                file.CopyTo(archive, true);
                file.Delete();
            }

            foreach (Xceed.FileSystem.AbstractFile file in dest.GetFiles(false, String.Format("{0}.*", OutputFileName)))
            {
                Files.Add(new CompressedFile(System.IO.File.ReadAllBytes(file.FullName), file.Name));
                file.Delete();
            }

            Files.Reverse();
            return Files;
        }
    }
}
