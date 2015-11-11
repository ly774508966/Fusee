/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 3.0.2
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace C4d {

public class BaseTag : BaseList2D {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal BaseTag(global::System.IntPtr cPtr, bool cMemoryOwn) : base(C4dApiPINVOKE.BaseTag_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(BaseTag obj) {
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

  public new static BaseTag Alloc(int type) {
    global::System.IntPtr cPtr = C4dApiPINVOKE.BaseTag_Alloc(type);
    BaseTag ret = (BaseTag) C4dApiPINVOKE.InstantiateConcreteTag(cPtr, false);
    return ret;
}

  public static void Free(SWIGTYPE_p_p_BaseTag bl) {
    C4dApiPINVOKE.BaseTag_Free(SWIGTYPE_p_p_BaseTag.getCPtr(bl));
    if (C4dApiPINVOKE.SWIGPendingException.Pending) throw C4dApiPINVOKE.SWIGPendingException.Retrieve();
  }

  public new BaseTag GetNext() {
    global::System.IntPtr cPtr = C4dApiPINVOKE.BaseTag_GetNext(swigCPtr);
    BaseTag ret = (BaseTag) C4dApiPINVOKE.InstantiateConcreteTag(cPtr, false);
    return ret;
}

  public new BaseTag GetPred() {
    global::System.IntPtr cPtr = C4dApiPINVOKE.BaseTag_GetPred(swigCPtr);
    BaseTag ret = (BaseTag) C4dApiPINVOKE.InstantiateConcreteTag(cPtr, false);
    return ret;
}

  public BaseObject GetObject() {
    global::System.IntPtr cPtr = C4dApiPINVOKE.BaseTag_GetObject(swigCPtr);
    BaseObject ret = (BaseObject) C4dApiPINVOKE.InstantiateConcreteObject(cPtr, false);
    return ret;
}

  public BaseTag GetOrigin() {
    global::System.IntPtr cPtr = C4dApiPINVOKE.BaseTag_GetOrigin(swigCPtr);
    BaseTag ret = (BaseTag) C4dApiPINVOKE.InstantiateConcreteTag(cPtr, false);
    return ret;
}

}

}
