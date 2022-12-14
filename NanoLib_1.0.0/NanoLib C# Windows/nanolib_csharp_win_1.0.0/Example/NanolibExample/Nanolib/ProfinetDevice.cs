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

public class ProfinetDevice : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal ProfinetDevice(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(ProfinetDevice obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~ProfinetDevice() {
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
          NanolibPINVOKE.delete_ProfinetDevice(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public string deviceName {
    set {
      NanolibPINVOKE.ProfinetDevice_deviceName_set(swigCPtr, value);
      if (NanolibPINVOKE.SWIGPendingException.Pending) throw NanolibPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      string ret = NanolibPINVOKE.ProfinetDevice_deviceName_get(swigCPtr);
      if (NanolibPINVOKE.SWIGPendingException.Pending) throw NanolibPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public string deviceVendor {
    set {
      NanolibPINVOKE.ProfinetDevice_deviceVendor_set(swigCPtr, value);
      if (NanolibPINVOKE.SWIGPendingException.Pending) throw NanolibPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      string ret = NanolibPINVOKE.ProfinetDevice_deviceVendor_get(swigCPtr);
      if (NanolibPINVOKE.SWIGPendingException.Pending) throw NanolibPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public MacAddress macAddress {
    set {
      NanolibPINVOKE.ProfinetDevice_macAddress_set(swigCPtr, MacAddress.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NanolibPINVOKE.ProfinetDevice_macAddress_get(swigCPtr);
      MacAddress ret = (cPtr == global::System.IntPtr.Zero) ? null : new MacAddress(cPtr, false);
      return ret;
    } 
  }

  public uint ipAddress {
    set {
      NanolibPINVOKE.ProfinetDevice_ipAddress_set(swigCPtr, value);
    } 
    get {
      uint ret = NanolibPINVOKE.ProfinetDevice_ipAddress_get(swigCPtr);
      return ret;
    } 
  }

  public uint netMask {
    set {
      NanolibPINVOKE.ProfinetDevice_netMask_set(swigCPtr, value);
    } 
    get {
      uint ret = NanolibPINVOKE.ProfinetDevice_netMask_get(swigCPtr);
      return ret;
    } 
  }

  public uint defaultGateway {
    set {
      NanolibPINVOKE.ProfinetDevice_defaultGateway_set(swigCPtr, value);
    } 
    get {
      uint ret = NanolibPINVOKE.ProfinetDevice_defaultGateway_get(swigCPtr);
      return ret;
    } 
  }

  public ProfinetDevice() : this(NanolibPINVOKE.new_ProfinetDevice(), true) {
  }

}

}
