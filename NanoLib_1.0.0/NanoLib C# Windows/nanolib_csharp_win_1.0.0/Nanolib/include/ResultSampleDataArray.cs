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

public class ResultSampleDataArray : Result {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal ResultSampleDataArray(global::System.IntPtr cPtr, bool cMemoryOwn) : base(NanolibPINVOKE.ResultSampleDataArray_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(ResultSampleDataArray obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  protected override void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          NanolibPINVOKE.delete_ResultSampleDataArray(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      base.Dispose(disposing);
    }
  }

  public ResultSampleDataArray() : this(NanolibPINVOKE.new_ResultSampleDataArray__SWIG_0(), true) {
  }

  public ResultSampleDataArray(SampleDataVector dataArray) : this(NanolibPINVOKE.new_ResultSampleDataArray__SWIG_1(SampleDataVector.getCPtr(dataArray)), true) {
    if (NanolibPINVOKE.SWIGPendingException.Pending) throw NanolibPINVOKE.SWIGPendingException.Retrieve();
  }

  public ResultSampleDataArray(string errorDesc, NlcErrorCode errorCode, uint extendedErrorCode) : this(NanolibPINVOKE.new_ResultSampleDataArray__SWIG_2(errorDesc, (int)errorCode, extendedErrorCode), true) {
    if (NanolibPINVOKE.SWIGPendingException.Pending) throw NanolibPINVOKE.SWIGPendingException.Retrieve();
  }

  public ResultSampleDataArray(string errorDesc, NlcErrorCode errorCode) : this(NanolibPINVOKE.new_ResultSampleDataArray__SWIG_3(errorDesc, (int)errorCode), true) {
    if (NanolibPINVOKE.SWIGPendingException.Pending) throw NanolibPINVOKE.SWIGPendingException.Retrieve();
  }

  public ResultSampleDataArray(string errorDesc) : this(NanolibPINVOKE.new_ResultSampleDataArray__SWIG_4(errorDesc), true) {
    if (NanolibPINVOKE.SWIGPendingException.Pending) throw NanolibPINVOKE.SWIGPendingException.Retrieve();
  }

  public ResultSampleDataArray(ResultSampleDataArray other) : this(NanolibPINVOKE.new_ResultSampleDataArray__SWIG_5(ResultSampleDataArray.getCPtr(other)), true) {
    if (NanolibPINVOKE.SWIGPendingException.Pending) throw NanolibPINVOKE.SWIGPendingException.Retrieve();
  }

  public ResultSampleDataArray(Result result) : this(NanolibPINVOKE.new_ResultSampleDataArray__SWIG_6(Result.getCPtr(result)), true) {
    if (NanolibPINVOKE.SWIGPendingException.Pending) throw NanolibPINVOKE.SWIGPendingException.Retrieve();
  }

  public SampleDataVector getResult() {
    SampleDataVector ret = new SampleDataVector(NanolibPINVOKE.ResultSampleDataArray_getResult(swigCPtr), false);
    return ret;
  }

}

}
