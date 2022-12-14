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

public class ResultObjectSubEntry : Result {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal ResultObjectSubEntry(global::System.IntPtr cPtr, bool cMemoryOwn) : base(NanolibPINVOKE.ResultObjectSubEntry_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(ResultObjectSubEntry obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  protected override void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          NanolibPINVOKE.delete_ResultObjectSubEntry(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      base.Dispose(disposing);
    }
  }

  public ResultObjectSubEntry(ObjectSubEntry result_) : this(NanolibPINVOKE.new_ResultObjectSubEntry__SWIG_0(ObjectSubEntry.getCPtr(result_)), true) {
    if (NanolibPINVOKE.SWIGPendingException.Pending) throw NanolibPINVOKE.SWIGPendingException.Retrieve();
  }

  public ResultObjectSubEntry(string errorString_) : this(NanolibPINVOKE.new_ResultObjectSubEntry__SWIG_1(errorString_), true) {
    if (NanolibPINVOKE.SWIGPendingException.Pending) throw NanolibPINVOKE.SWIGPendingException.Retrieve();
  }

  public ResultObjectSubEntry(NlcErrorCode errCode, string errorString_) : this(NanolibPINVOKE.new_ResultObjectSubEntry__SWIG_2((int)errCode, errorString_), true) {
    if (NanolibPINVOKE.SWIGPendingException.Pending) throw NanolibPINVOKE.SWIGPendingException.Retrieve();
  }

  public ResultObjectSubEntry(NlcErrorCode errCode, uint exErrCode, string errorString_) : this(NanolibPINVOKE.new_ResultObjectSubEntry__SWIG_3((int)errCode, exErrCode, errorString_), true) {
    if (NanolibPINVOKE.SWIGPendingException.Pending) throw NanolibPINVOKE.SWIGPendingException.Retrieve();
  }

  public ResultObjectSubEntry(Result result) : this(NanolibPINVOKE.new_ResultObjectSubEntry__SWIG_4(Result.getCPtr(result)), true) {
    if (NanolibPINVOKE.SWIGPendingException.Pending) throw NanolibPINVOKE.SWIGPendingException.Retrieve();
  }

  public ObjectSubEntry getResult() {
    ObjectSubEntry ret = new ObjectSubEntry(NanolibPINVOKE.ResultObjectSubEntry_getResult(swigCPtr), false);
    return ret;
  }

}

}
