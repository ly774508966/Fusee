/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 3.0.2
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace C4d {

public class CAnimInfo : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CAnimInfo(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CAnimInfo obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          throw new global::System.MethodAccessException("C++ destructor does not have public access");
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public BaseDocument doc {
    set {
      C4dApiPINVOKE.CAnimInfo_doc_set(swigCPtr, BaseDocument.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = C4dApiPINVOKE.CAnimInfo_doc_get(swigCPtr);
      BaseDocument ret = (cPtr == global::System.IntPtr.Zero) ? null : new BaseDocument(cPtr, false);
      return ret;
    } 
  }

  public BaseList2D op {
    set {
      C4dApiPINVOKE.CAnimInfo_op_set(swigCPtr, BaseList2D.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = C4dApiPINVOKE.CAnimInfo_op_get(swigCPtr);
      BaseList2D ret = (cPtr == global::System.IntPtr.Zero) ? null : new BaseList2D(cPtr, false);
      return ret;
    } 
  }

  public BaseTime otime {
    set {
      C4dApiPINVOKE.CAnimInfo_otime_set(swigCPtr, BaseTime.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = C4dApiPINVOKE.CAnimInfo_otime_get(swigCPtr);
      BaseTime ret = (cPtr == global::System.IntPtr.Zero) ? null : new BaseTime(cPtr, false);
      return ret;
    } 
  }

  public double xtime {
    set {
      C4dApiPINVOKE.CAnimInfo_xtime_set(swigCPtr, value);
    } 
    get {
      double ret = C4dApiPINVOKE.CAnimInfo_xtime_get(swigCPtr);
      return ret;
    } 
  }

  public double fac {
    set {
      C4dApiPINVOKE.CAnimInfo_fac_set(swigCPtr, value);
    } 
    get {
      double ret = C4dApiPINVOKE.CAnimInfo_fac_get(swigCPtr);
      return ret;
    } 
  }

  public double rel {
    set {
      C4dApiPINVOKE.CAnimInfo_rel_set(swigCPtr, value);
    } 
    get {
      double ret = C4dApiPINVOKE.CAnimInfo_rel_get(swigCPtr);
      return ret;
    } 
  }

  public CKey k1 {
    set {
      C4dApiPINVOKE.CAnimInfo_k1_set(swigCPtr, CKey.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = C4dApiPINVOKE.CAnimInfo_k1_get(swigCPtr);
      CKey ret = (cPtr == global::System.IntPtr.Zero) ? null : new CKey(cPtr, false);
      return ret;
    } 
  }

  public CKey k2 {
    set {
      C4dApiPINVOKE.CAnimInfo_k2_set(swigCPtr, CKey.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = C4dApiPINVOKE.CAnimInfo_k2_get(swigCPtr);
      CKey ret = (cPtr == global::System.IntPtr.Zero) ? null : new CKey(cPtr, false);
      return ret;
    } 
  }

  public int k1idx {
    set {
      C4dApiPINVOKE.CAnimInfo_k1idx_set(swigCPtr, value);
    } 
    get {
      int ret = C4dApiPINVOKE.CAnimInfo_k1idx_get(swigCPtr);
      return ret;
    } 
  }

  public int k2idx {
    set {
      C4dApiPINVOKE.CAnimInfo_k2idx_set(swigCPtr, value);
    } 
    get {
      int ret = C4dApiPINVOKE.CAnimInfo_k2idx_get(swigCPtr);
      return ret;
    } 
  }

  public int cycle {
    set {
      C4dApiPINVOKE.CAnimInfo_cycle_set(swigCPtr, value);
    } 
    get {
      int ret = C4dApiPINVOKE.CAnimInfo_cycle_get(swigCPtr);
      return ret;
    } 
  }

}

}
