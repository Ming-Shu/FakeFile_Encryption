using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace FakeFile_Encryption
{
    class FileIO
    {
        public void FakeFileEncrypted(string sourceFilePath, string packFilePath, string targetPath)
        {
            try
            {
                byte[] dataSourceFile = File.ReadAllBytes(sourceFilePath);
                byte[] dataPackFile = File.ReadAllBytes(packFilePath);
                byte[] dataSourceExtensionFile = System.Text.Encoding.Default.GetBytes(Path.GetExtension(sourceFilePath));
                int sourceExtensionFileLength = System.Convert.ToInt32(Path.GetExtension(sourceFilePath).Length);

                using (FileStream newFile = new FileStream(targetPath, FileMode.OpenOrCreate, FileAccess.ReadWrite))
                {
                    using (BinaryWriter newFileWriter = new BinaryWriter(newFile))
                    {                        
                        
                        newFileWriter.Write(dataPackFile);
                        newFileWriter.Write("MingEdit");
                        newFileWriter.Write(sourceExtensionFileLength);
                        newFileWriter.Write(dataSourceExtensionFile);
                        newFileWriter.Write(dataSourceFile);
                    }
                    newFile.Close();
                }

            }catch (Exception e){
                throw e;
            }
        }

        public StatusFlags.Type FileDecrypted(string fakeFilePath,string keyFilePath, string newFilePath)
        {
            try
            {
               byte[] dataFakeFile = File.ReadAllBytes(fakeFilePath);
                FileInfo fileInfo = new FileInfo(keyFilePath);
                int keyFileLength = (int)fileInfo.Length;              
                
                if (dataFakeFile[keyFileLength+1] == 'M' && dataFakeFile[keyFileLength + 2] == 'i' && dataFakeFile[keyFileLength + 3] == 'n' && dataFakeFile[keyFileLength + 4] == 'g' && dataFakeFile[keyFileLength + 5] == 'E' && dataFakeFile[keyFileLength + 6] == 'd' && dataFakeFile[keyFileLength + 7] == 'i' && dataFakeFile[keyFileLength + 8] == 't')
                {
                    int ExtensionFileLength = dataFakeFile[keyFileLength + 8 + 1] + dataFakeFile[keyFileLength + 8 + 2] + dataFakeFile[keyFileLength + 8 + 3] + dataFakeFile[keyFileLength + 8 + 4];
                    FileInfo fakeFileInfo = new FileInfo(fakeFilePath);
                    int unpackFileLength = (int)fakeFileInfo.Length - keyFileLength - 9 -sizeof(int) - ExtensionFileLength;
                    byte[] ExtensionFile = new byte[ExtensionFileLength];
                    byte[] unpackDataFile = new byte[unpackFileLength];
                    for (int i = 0; i < unpackFileLength + ExtensionFileLength; i++)
                    {
                        if (i < ExtensionFileLength)
                            ExtensionFile[i] = dataFakeFile[keyFileLength + 9 + sizeof(int) + i];
                        if(i>=ExtensionFileLength && i<(int)fakeFileInfo.Length )
                            unpackDataFile[i - ExtensionFileLength] = dataFakeFile[keyFileLength + 8 + sizeof(int) + 1 + i];

                    }
                    
                    string newFileName = newFilePath + "\\"+ Path.GetFileNameWithoutExtension(keyFilePath)+"_unpackFile" + System.Text.Encoding.Default.GetString(ExtensionFile);
                    using (FileStream newFile = new FileStream(newFileName, FileMode.OpenOrCreate, FileAccess.ReadWrite))
                    {
                        using (BinaryWriter newFileWriter = new BinaryWriter(newFile))
                        {                                                       
                            newFileWriter.Write(unpackDataFile);
                        }
                        newFile.Close();
                    }
                }
                else
                {
                    return StatusFlags.Type.Warning;
                }               
            }
            catch (Exception)
            {
                return StatusFlags.Type.Exception;
            }

            return StatusFlags.Type.OK;
        }
    }
}
