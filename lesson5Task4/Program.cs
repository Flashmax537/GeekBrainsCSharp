using System.IO;
using System.Linq;

namespace lesson5Task4
{
    class Program
    {
        static void Main()
        {
            #region Создание тестовой дериктории

            var currentDirectory = Directory.GetCurrentDirectory();

            if (!Directory.Exists(currentDirectory + "/Tree")) Directory.CreateDirectory(currentDirectory + "/Tree");
            if (!Directory.Exists(currentDirectory + "/Tree/Dir1")) Directory.CreateDirectory(currentDirectory + "/Tree/Dir1");
            if (!File.Exists(currentDirectory + "/Tree/file.txt")) File.Create(currentDirectory + "/Tree/file.txt");
            if (!File.Exists(currentDirectory + "/Tree/binary.bin")) File.Create(currentDirectory + "/Tree/binary.bin");
            if (!Directory.Exists(currentDirectory + "/Tree/Dir1/Dir2")) Directory.CreateDirectory(currentDirectory + "/Tree/Dir1/Dir2");
            if (!File.Exists(currentDirectory + "/Tree/Dir1/file1.txt")) File.Create(currentDirectory + "/Tree/Dir1/file1.txt");
            if (!Directory.Exists(currentDirectory + "/Tree/Dir1/Dir2/Dir3")) Directory.CreateDirectory(currentDirectory + "/Tree/Dir1/Dir2/Dir3");
            if (!Directory.Exists(currentDirectory + "/Tree/Dir1/Dir2/newDir")) Directory.CreateDirectory(currentDirectory + "/Tree/Dir1/Dir2/newDir");
            if (!Directory.Exists(currentDirectory + "/Tree/Dir1/Dir2/newDir/newDir2")) Directory.CreateDirectory(currentDirectory + "/Tree/Dir1/Dir2/newDir/newDir2");
            if (!File.Exists(currentDirectory + "/Tree/Dir1/Dir2/newDir/newDir2/newfile.docx")) File.Create(currentDirectory + "/Tree/Dir1/Dir2/newDir/newDir2/newfile.docx");
            if (!File.Exists(currentDirectory + "/Tree/Dir1/Dir2/file2.txt")) File.Create(currentDirectory + "/Tree/Dir1/Dir2/file2.txt");
            if (!File.Exists(currentDirectory + "/Tree/Dir1/Dir2/Dir3/file3.txt")) File.Create(currentDirectory + "/Tree/Dir1/Dir2/Dir3/file3.txt");
            
            #endregion

            #region Без рекурсии

            string filename = "TreeWithoutRecursion.txt";
            string startDirectory = currentDirectory + "/Tree";
            var directoryInfo = new DirectoryInfo(startDirectory);
            var dirInfos = directoryInfo.GetFileSystemInfos().ToList();
            File.WriteAllText(filename, startDirectory + "\n");
            string prefix;

            foreach (var dirInfo in dirInfos)
            {
                if (dirInfo.Attributes == FileAttributes.Directory)
                {
                    prefix = dirInfo == dirInfos.Last() ? "└── " : "├── ";
                    File.AppendAllText(filename, prefix + dirInfo.Name + "\n");
                    var directoryInfo2 = new DirectoryInfo(dirInfo.FullName);
                    var dirInfos2 = directoryInfo2.GetFileSystemInfos().ToList();

                    foreach (var dirInfo2 in dirInfos2)
                    {
                        if (dirInfo2.Attributes == FileAttributes.Directory)
                        {
                            prefix = dirInfo == dirInfos.Last() ? "    " : "│   ";
                            prefix = dirInfo2 == dirInfos2.Last() ? prefix + "└── " : prefix + "├── ";
                            File.AppendAllText(filename, prefix + dirInfo2.Name + "\n");
                            var directoryInfo3 = new DirectoryInfo(dirInfo2.FullName);
                            var dirInfos3 = directoryInfo3.GetFileSystemInfos().ToList();

                            foreach (var dirInfo3 in dirInfos3)
                            {
                                if (dirInfo3.Attributes == FileAttributes.Directory)
                                {
                                    prefix = dirInfo == dirInfos.Last() ? "    " : "│   ";
                                    prefix = dirInfo2 == dirInfos2.Last() ? prefix + "    " : prefix + "│   ";
                                    prefix = dirInfo3 == dirInfos3.Last() ? prefix + "└── " : prefix + "├── ";
                                    File.AppendAllText(filename, prefix + dirInfo3.Name + "\n");
                                }
                                else
                                {
                                    prefix = dirInfo == dirInfos.Last() ? "    " : "│   ";
                                    prefix = dirInfo2 == dirInfos2.Last() ? prefix + "    " : prefix + "│   ";
                                    prefix = dirInfo3 == dirInfos3.Last() ? prefix + "└── " : prefix + "├── ";
                                    File.AppendAllText(filename, prefix + dirInfo3.Name + "\n");
                                }
                            }
                        }
                        else
                        {
                            prefix = dirInfo == dirInfos.Last() ? "    " : "│   ";
                            prefix = dirInfo2 == dirInfos2.Last() ? prefix + "└── " : prefix + "├── ";
                            File.AppendAllText(filename, prefix + dirInfo2.Name + "\n");
                        }
                    }
                }
                else
                {
                    prefix = dirInfo == dirInfos.Last() ? "└── " : "├── ";
                    File.AppendAllText(filename, prefix + dirInfo.Name + "\n");
                }
            }

            #endregion

            #region С рекурсией

            File.WriteAllText("TreeWithRecursion.txt", startDirectory + "\n");
            PrintTree(startDirectory, "TreeWithRecursion.txt");

            #endregion
        }

        /// <summary>
        /// Отрисовка дерева
        /// </summary>
        /// <param name="startDirectory">Начальная директория</param>
        /// <param name="filename"></param>
        /// <param name="prefix">Префикс для отрисовки веток</param>
        static void PrintTree(string startDirectory, string filename, string prefix = "")
        {
            var directoryInfo = new DirectoryInfo(startDirectory);
            var fileSystemInfo = directoryInfo.GetFileSystemInfos().ToList();

            for (int i = 0; i < fileSystemInfo.Count; i++)
            {
                if (i == fileSystemInfo.Count - 1)
                {
                    File.AppendAllText(filename, prefix + "└── ");
                    File.AppendAllText(filename, fileSystemInfo[i].Name + "\n");
                    if (fileSystemInfo[i].Attributes == FileAttributes.Directory)
                    {
                        PrintTree(fileSystemInfo[i].FullName, filename, prefix + "    ");
                    }
                }
                else
                {
                    File.AppendAllText(filename, prefix + "├── ");
                    File.AppendAllText(filename, fileSystemInfo[i].Name + "\n");
                    if (fileSystemInfo[i].Attributes == FileAttributes.Directory)
                    {
                        PrintTree(fileSystemInfo[i].FullName, filename, prefix + "│   ");
                    }
                }
            }
        }
    }
}
