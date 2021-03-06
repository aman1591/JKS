﻿//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated by a tool.
//     Runtime Version: 1.1.4322.2407
//
//     Changes to this file may cause incorrect behavior and will be lost if 
//     the code is regenerated.
// </autogenerated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by Microsoft.VSDesigner, Version 1.1.4322.2407.
// 
namespace CBSolutions.ETH.Web.WEBRef {
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
            this.Url = "http://vns75/WebService-File download/FileDownload.asmx";
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
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/UploadFileNew", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public bool UploadFileNew(string strFileName, [System.Xml.Serialization.XmlElementAttribute(DataType="base64Binary")] System.Byte[] objFile, string strReturn, string strChildBuyer) {
            object[] results = this.Invoke("UploadFileNew", new object[] {
                        strFileName,
                        objFile,
                        strReturn,
                        strChildBuyer});
            return ((bool)(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginUploadFileNew(string strFileName, System.Byte[] objFile, string strReturn, string strChildBuyer, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("UploadFileNew", new object[] {
                        strFileName,
                        objFile,
                        strReturn,
                        strChildBuyer}, callback, asyncState);
        }
        
        /// <remarks/>
        public bool EndUploadFileNew(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((bool)(results[0]));
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetPageCount", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public int GetPageCount(string file) {
            object[] results = this.Invoke("GetPageCount", new object[] {
                        file});
            return ((int)(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginGetPageCount(string file, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("GetPageCount", new object[] {
                        file}, callback, asyncState);
        }
        
        /// <remarks/>
        public int EndGetPageCount(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((int)(results[0]));
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetMultiPages", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute(DataType="base64Binary")]
        public System.Byte[] GetMultiPages(string sfile, int iIndex) {
            object[] results = this.Invoke("GetMultiPages", new object[] {
                        sfile,
                        iIndex});
            return ((System.Byte[])(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginGetMultiPages(string sfile, int iIndex, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("GetMultiPages", new object[] {
                        sfile,
                        iIndex}, callback, asyncState);
        }
        
        /// <remarks/>
        public System.Byte[] EndGetMultiPages(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((System.Byte[])(results[0]));
        }
    }
}
