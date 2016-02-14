using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfServiceLibraryRestJson
{
    //aggiungo un commento
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface ISrvRestJson
    {
        //[OperationContract]
        //string GetData(int value);

        //[OperationContract]
        //CompositeType GetDataUsingDataContract(CompositeType composite);


        //RequestFormat=WebMessageFormat.Json
        [OperationContract]
        [WebGet(ResponseFormat=WebMessageFormat.Json) ]
        string GetEcho(string pEcho);

        [OperationContract]
        [WebGet(ResponseFormat = WebMessageFormat.Json)]
        string GetEcho2(string pEcho);

        [OperationContract]
        [WebGet(ResponseFormat = WebMessageFormat.Json)]
        string GetEcho3(string pEcho);



        //[OperationContract]
        //[WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json,
        //    UriTemplate = "/ChiamataJsonComplessa", ResponseFormat = WebMessageFormat.Json)]
        [OperationContract]
        [WebInvoke ( Method="POST", RequestFormat=WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        string DoPost(ParemterForPost pParemterForPost);

        // TODO: Add your service operations here
    }


    [DataContract]
    public class ParemterForPost
    {
        [DataMember]
        public string par1 { get; set; }
        [DataMember]
        public string par2 { get; set; }
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    // You can add XSD files into the project. After building the project, you can directly use the data types defined there, with the namespace "WcfServiceLibraryRestJson.ContractType".
    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }
}
