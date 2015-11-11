/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 3.0.2
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace C4d {

public class GeMarker : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal GeMarker(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(GeMarker obj) {
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

  public static GeMarker Alloc() {
    global::System.IntPtr cPtr = C4dApiPINVOKE.GeMarker_Alloc();
    GeMarker ret = (cPtr == global::System.IntPtr.Zero) ? null : new GeMarker(cPtr, false);
    return ret;
  }

  public static void Free(SWIGTYPE_p_p_GeMarker obj) {
    C4dApiPINVOKE.GeMarker_Free(SWIGTYPE_p_p_GeMarker.getCPtr(obj));
    if (C4dApiPINVOKE.SWIGPendingException.Pending) throw C4dApiPINVOKE.SWIGPendingException.Retrieve();
  }

  public bool Content() {
    bool ret = C4dApiPINVOKE.GeMarker_Content(swigCPtr);
    return ret;
  }

  public bool IsEqual(GeMarker m) {
    bool ret = C4dApiPINVOKE.GeMarker_IsEqual(swigCPtr, GeMarker.getCPtr(m));
    if (C4dApiPINVOKE.SWIGPendingException.Pending) throw C4dApiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int Compare(GeMarker m) {
    int ret = C4dApiPINVOKE.GeMarker_Compare(swigCPtr, GeMarker.getCPtr(m));
    if (C4dApiPINVOKE.SWIGPendingException.Pending) throw C4dApiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void Set(GeMarker m) {
    C4dApiPINVOKE.GeMarker_Set(swigCPtr, GeMarker.getCPtr(m));
    if (C4dApiPINVOKE.SWIGPendingException.Pending) throw C4dApiPINVOKE.SWIGPendingException.Retrieve();
  }

  public bool Read(HyperFile hf) {
    bool ret = C4dApiPINVOKE.GeMarker_Read(swigCPtr, HyperFile.getCPtr(hf));
    return ret;
  }

  public bool Write(HyperFile hf) {
    bool ret = C4dApiPINVOKE.GeMarker_Write(swigCPtr, HyperFile.getCPtr(hf));
    return ret;
  }

  public void GetMemory(SWIGTYPE_p_p_void data, SWIGTYPE_p_Int32 size) {
    C4dApiPINVOKE.GeMarker_GetMemory(swigCPtr, SWIGTYPE_p_p_void.getCPtr(data), SWIGTYPE_p_Int32.getCPtr(size));
    if (C4dApiPINVOKE.SWIGPendingException.Pending) throw C4dApiPINVOKE.SWIGPendingException.Retrieve();
  }

}

}
