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

public class ObjectSubEntry : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal ObjectSubEntry(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(ObjectSubEntry obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~ObjectSubEntry() {
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
          NanolibPINVOKE.delete_ObjectSubEntry(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public ObjectSubEntry() : this(NanolibPINVOKE.new_ObjectSubEntry(), true) {
  }

  public virtual string getName() {
    string ret = NanolibPINVOKE.ObjectSubEntry_getName(swigCPtr);
    return ret;
  }

  public virtual byte getSubIndex() {
    byte ret = NanolibPINVOKE.ObjectSubEntry_getSubIndex(swigCPtr);
    return ret;
  }

  public virtual ObjectEntryDataType getDataType() {
    ObjectEntryDataType ret = (ObjectEntryDataType)NanolibPINVOKE.ObjectSubEntry_getDataType(swigCPtr);
    return ret;
  }

  public virtual ObjectSdoAccessAttribute getSdoAccess() {
    ObjectSdoAccessAttribute ret = (ObjectSdoAccessAttribute)NanolibPINVOKE.ObjectSubEntry_getSdoAccess(swigCPtr);
    return ret;
  }

  public virtual ObjectPdoAccessAttribute getPdoAccess() {
    ObjectPdoAccessAttribute ret = (ObjectPdoAccessAttribute)NanolibPINVOKE.ObjectSubEntry_getPdoAccess(swigCPtr);
    return ret;
  }

  public virtual uint getBitLength() {
    uint ret = NanolibPINVOKE.ObjectSubEntry_getBitLength(swigCPtr);
    return ret;
  }

  public virtual ResultInt getDefaultValueAsNumeric(string key) {
    ResultInt ret = new ResultInt(NanolibPINVOKE.ObjectSubEntry_getDefaultValueAsNumeric(swigCPtr, key), true);
    if (NanolibPINVOKE.SWIGPendingException.Pending) throw NanolibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual ResultString getDefaultValueAsString(string key) {
    ResultString ret = new ResultString(NanolibPINVOKE.ObjectSubEntry_getDefaultValueAsString(swigCPtr, key), true);
    if (NanolibPINVOKE.SWIGPendingException.Pending) throw NanolibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual StringStringMap getDefaultValues() {
    StringStringMap ret = new StringStringMap(NanolibPINVOKE.ObjectSubEntry_getDefaultValues(swigCPtr), true);
    return ret;
  }

  public virtual ResultInt readNumber() {
    ResultInt ret = new ResultInt(NanolibPINVOKE.ObjectSubEntry_readNumber(swigCPtr), true);
    return ret;
  }

  public virtual ResultString readString() {
    ResultString ret = new ResultString(NanolibPINVOKE.ObjectSubEntry_readString(swigCPtr), true);
    return ret;
  }

  public virtual ResultArrayByte readBytes() {
    ResultArrayByte ret = new ResultArrayByte(NanolibPINVOKE.ObjectSubEntry_readBytes(swigCPtr), true);
    return ret;
  }

  public virtual ResultVoid writeNumber(long value) {
    ResultVoid ret = new ResultVoid(NanolibPINVOKE.ObjectSubEntry_writeNumber(swigCPtr, value), true);
    return ret;
  }

  public virtual ResultVoid writeBytes(ByteVector data) {
    ResultVoid ret = new ResultVoid(NanolibPINVOKE.ObjectSubEntry_writeBytes(swigCPtr, ByteVector.getCPtr(data)), true);
    if (NanolibPINVOKE.SWIGPendingException.Pending) throw NanolibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

}