//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.2
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace  Nlc {

public class RESTfulBus : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal RESTfulBus(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(RESTfulBus obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~RESTfulBus() {
    Dispose(false);
  }

  public void Dispose() {
    Dispose(true);
    global::System.GC.SuppressFinalize(this);
  }

  protected virtual void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          NanolibPINVOKE.delete_RESTfulBus(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public string CONNECT_TIMEOUT_OPTION_NAME {
    get {
      string ret = NanolibPINVOKE.RESTfulBus_CONNECT_TIMEOUT_OPTION_NAME_get(swigCPtr);
      return ret;
    } 
  }

  public uint DEFAULT_CONNECT_TIMEOUT {
    get {
      uint ret = NanolibPINVOKE.RESTfulBus_DEFAULT_CONNECT_TIMEOUT_get(swigCPtr);
      return ret;
    } 
  }

  public string REQUEST_TIMEOUT_OPTION_NAME {
    get {
      string ret = NanolibPINVOKE.RESTfulBus_REQUEST_TIMEOUT_OPTION_NAME_get(swigCPtr);
      return ret;
    } 
  }

  public uint DEFAULT_REQUEST_TIMEOUT {
    get {
      uint ret = NanolibPINVOKE.RESTfulBus_DEFAULT_REQUEST_TIMEOUT_get(swigCPtr);
      return ret;
    } 
  }

  public string RESPONSE_TIMEOUT_OPTION_NAME {
    get {
      string ret = NanolibPINVOKE.RESTfulBus_RESPONSE_TIMEOUT_OPTION_NAME_get(swigCPtr);
      return ret;
    } 
  }

  public uint DEFAULT_RESPONSE_TIMEOUT {
    get {
      uint ret = NanolibPINVOKE.RESTfulBus_DEFAULT_RESPONSE_TIMEOUT_get(swigCPtr);
      return ret;
    } 
  }

  public RESTfulBus() : this(NanolibPINVOKE.new_RESTfulBus(), true) {
  }

}

}