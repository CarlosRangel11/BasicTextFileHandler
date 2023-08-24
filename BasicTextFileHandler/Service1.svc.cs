using System;
using System.Web;
using System.IO;
using System.Data;

namespace BasicTextFileHandler {
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1 {
        public void PutStringToFile(string fileName, string value) {
            string fileLocation = Path.Combine(HttpRuntime.AppDomainAppPath, @"App_Data");
            fileLocation = Path.Combine(fileLocation, fileName);

            if (File.Exists(fileLocation)) {
                File.Delete(fileLocation);
            }
            using (StreamWriter sw = File.CreateText(fileLocation)) {
                sw.WriteLine(value);
                sw.Close();
            }
        }

        public string GetStringFromFile(string fileName) {
            string fileLocation = Path.Combine(HttpRuntime.AppDomainAppPath, @"App_Data");
            fileLocation = Path.Combine(fileLocation, fileName);

            if (!File.Exists(fileLocation)) {
                return "File not found. . . ";
            }
            using (StreamReader sr = File.OpenText(fileLocation)) {
                string s = "";
                s = sr.ReadLine();
                return s;
            }
        }
    }
}
