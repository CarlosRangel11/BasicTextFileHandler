using System.ServiceModel;

namespace BasicTextFileHandler {
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1 {

        [OperationContract]
        void PutStringToFile(string fileName, string value);
        [OperationContract]
        string GetStringFromFile(string fileName);
    }
}
