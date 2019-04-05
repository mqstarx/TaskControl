using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace CoreL
{
    [Serializable]
    public class UFiles
    {

        private List<FileToUpdate> m_FilesList;
        public UFiles()
        {
            FilesList = new List<FileToUpdate>();
        }

        public List<FileToUpdate> FilesList
        {
            get
            {
                return m_FilesList;
            }

            set
            {
                m_FilesList = value;
            }
        }
    }

    [Serializable]
    public class FileToUpdate
    {
        private byte[] m_FileData;
        private string m_FileName;

        public static string StartupPath = Application.StartupPath;

        public FileToUpdate(string path)
        {
            if (File.Exists(path))
            {
                FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.Read);
                FileData = new byte[fs.Length];
                fs.Read(FileData, 0, (int)fs.Length);
                FileInfo fi = new FileInfo(path);
                m_FileName = fi.Name;
                fs.Close();
            }
        }

        public byte[] FileData
        {
            get
            {
                return m_FileData;
            }

            set
            {
                m_FileData = value;
            }
        }

        public string FileName
        {
            get
            {
                return m_FileName;
            }

            set
            {
                m_FileName = value;
            }
        }
        public override string ToString()
        {
            return m_FileName;
        }

        /// <summary>
        /// заменить файл с текущим имененм по заданному пути
        /// </summary>
        /// <param name="path">путь к старому файлу</param>
        public void Update(string path)
        {
            if(File.Exists(path))
            {
                File.Delete(path);
                FileStream fs = new FileStream(path, FileMode.CreateNew, FileAccess.Write);
                fs.Write(m_FileData, 0, m_FileData.Length);
                fs.Close();


            }
        }
    }
}
