/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 3.0.2
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace C4d {

public class MultipassObject : BaseList2D {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal MultipassObject(global::System.IntPtr cPtr, bool cMemoryOwn) : base(C4dApiPINVOKE.MultipassObject_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(MultipassObject obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          throw new global::System.MethodAccessException("C++ destructor does not have public access");
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public new MultipassObject GetNext() {
    global::System.IntPtr cPtr = C4dApiPINVOKE.MultipassObject_GetNext(swigCPtr);
    MultipassObject ret = (cPtr == global::System.IntPtr.Zero) ? null : new MultipassObject(cPtr, false);
    return ret;
  }

  public new MultipassObject GetPred() {
    global::System.IntPtr cPtr = C4dApiPINVOKE.MultipassObject_GetPred(swigCPtr);
    MultipassObject ret = (cPtr == global::System.IntPtr.Zero) ? null : new MultipassObject(cPtr, false);
    return ret;
  }

}

}
