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

public class ResultSamplerState : Result {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal ResultSamplerState(global::System.IntPtr cPtr, bool cMemoryOwn) : base(NanolibPINVOKE.ResultSamplerState_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(ResultSamplerState obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  protected override void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          NanolibPINVOKE.delete_ResultSamplerState(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      base.Dispose(disposing);
    }
  }

  public ResultSamplerState(SamplerState state) : this(NanolibPINVOKE.new_ResultSamplerState__SWIG_0((int)state), true) {
  }

  public ResultSamplerState(string errorDesc, NlcErrorCode errorCode, uint extendedErrorCode) : this(NanolibPINVOKE.new_ResultSamplerState__SWIG_1(errorDesc, (int)errorCode, extendedErrorCode), true) {
    if (NanolibPINVOKE.SWIGPendingException.Pending) throw NanolibPINVOKE.SWIGPendingException.Retrieve();
  }

  public ResultSamplerState(string errorDesc, NlcErrorCode errorCode) : this(NanolibPINVOKE.new_ResultSamplerState__SWIG_2(errorDesc, (int)errorCode), true) {
    if (NanolibPINVOKE.SWIGPendingException.Pending) throw NanolibPINVOKE.SWIGPendingException.Retrieve();
  }

  public ResultSamplerState(string errorDesc) : this(NanolibPINVOKE.new_ResultSamplerState__SWIG_3(errorDesc), true) {
    if (NanolibPINVOKE.SWIGPendingException.Pending) throw NanolibPINVOKE.SWIGPendingException.Retrieve();
  }

  public ResultSamplerState(ResultSamplerState other) : this(NanolibPINVOKE.new_ResultSamplerState__SWIG_4(ResultSamplerState.getCPtr(other)), true) {
    if (NanolibPINVOKE.SWIGPendingException.Pending) throw NanolibPINVOKE.SWIGPendingException.Retrieve();
  }

  public ResultSamplerState(Result result) : this(NanolibPINVOKE.new_ResultSamplerState__SWIG_5(Result.getCPtr(result)), true) {
    if (NanolibPINVOKE.SWIGPendingException.Pending) throw NanolibPINVOKE.SWIGPendingException.Retrieve();
  }

  public SamplerState getResult() {
    SamplerState ret = (SamplerState)NanolibPINVOKE.ResultSamplerState_getResult(swigCPtr);
    return ret;
  }

}

}