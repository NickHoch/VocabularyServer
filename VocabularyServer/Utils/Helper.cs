using System;
using System.IO;

namespace DAL.Utils
{
    public class Helper
    {
        public static string GetPathToBaseDirectory()
        {
            //string projectPath = Directory.GetParent(Directory.GetCurrentDirectory())
            //                              .Parent
            //                              .FullName;
            return Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.RelativeSearchPath, @"..\..\VocabularyServer\bin\Debug"));
        }
    }
}
