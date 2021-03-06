﻿//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated by a tool.
//     Runtime Version: 1.1.4322.573
//
//     Changes to this file may cause incorrect behavior and will be lost if 
//     the code is regenerated.
// </autogenerated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by Microsoft.VSDesigner, Version 1.1.4322.573.
// 
namespace CBSolutions.ETH.Web.WEBRef2 {
    using System.Diagnostics;
    using System.Xml.Serialization;
    using System;
    using System.Web.Services.Protocols;
    using System.ComponentModel;
    using System.Web.Services;
    
    
    /// <remarks/>
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="FileDownloadSoap", Namespace="http://tempuri.org/")]
    public class FileDownload : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        /// <remarks/>
        public FileDownload() {
            this.Url = "http://vns7/WebService-File download2/FileDownload2.asmx";
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/RemoveFile", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public bool RemoveFile(string FName) {
            object[] results = this.Invoke("RemoveFile", new object[] {
                        FName});
            return ((bool)(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginRemoveFile(string FName, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("RemoveFile", new object[] {
                        FName}, callback, asyncState);
        }
        
        /// <remarks/>
        public bool EndRemoveFile(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((bool)(results[0]));
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/DownloadFile", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute(DataType="base64Binary")]
        public System.Byte[] DownloadFile(string FName) {
            object[] results = this.Invoke("DownloadFile", new object[] {
                        FName});
            return ((System.Byte[])(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginDownloadFile(string FName, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("DownloadFile", new object[] {
                        FName}, callback, asyncState);
        }
        
        /// <remarks/>
        public System.Byte[] EndDownloadFile(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((System.Byte[])(results[0]));
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/UploadFile", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public bool UploadFile(string strFileName, [System.Xml.Serialization.XmlElementAttribute(DataType="base64Binary")] System.Byte[] objFile, string strReturn) {
            object[] results = this.Invoke("UploadFile", new object[] {
                        strFileName,
                        objFile,
                        strReturn});
            return ((bool)(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginUploadFile(string strFileName, System.Byte[] objFile, string strReturn, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("UploadFile", new object[] {
                        strFileName,
                        objFile,
                        strReturn}, callback, asyncState);
        }
        
        /// <remarks/>
        public bool EndUploadFile(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((bool)(results[0]));
        }
    }
}
