using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankSystem.GlobalClasses
{
    //D:\Projects\ProjectBankSystem\
    public class clsUtil
    {
        static public bool CreateImageIfDoesnotExist(string Path)
        {
            // check if Directory exist 
            if (!Directory.Exists(Path))
            {
                try
                {
                    // now we create new Directory.
                    Directory.CreateDirectory(Path);
                    return true;
                }
                catch (IOException ex)
                {
                    return false;
                }
            }
            return true;
        }
        static public string GenerateCUID()
        {
            Guid guid = Guid.NewGuid();

            return guid.ToString();
        }

        static public string RepleceImageWithCUID(string ImagePath)
        {
            string FileName = ImagePath;
            FileInfo Fi = new FileInfo(FileName);
            // exstension : If Photo arr jpeg || jpg|| ecs...
            string extens = Fi.Extension;
            return GenerateCUID() + extens;
        }
        static public bool CopyImageToProjectFolder(ref string ImagePath)
        {
            // define FileName for ImagePath
            string DestinationFolder = @"D:\Projects\ProjectBankSystem\ImagePeople\";
            if (!CreateImageIfDoesnotExist(DestinationFolder))
                return false;
            // define Folder
            string DestinationFile = DestinationFolder + RepleceImageWithCUID(ImagePath);
            try
            {
                File.Copy(ImagePath, DestinationFile, true);
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.Message + "Error in Copy Image");
                return false;
            }
            ImagePath = DestinationFile;
            return true;
        }

    }

}
