/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 3.0.2
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace C4d {

public class DynamicDescription : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal DynamicDescription(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(DynamicDescription obj) {
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

  public DescID Alloc(BaseContainer datadescription) {
    DescID ret = new DescID(C4dApiPINVOKE.DynamicDescription_Alloc(swigCPtr, BaseContainer.getCPtr(datadescription)), true);
    if (C4dApiPINVOKE.SWIGPendingException.Pending) throw C4dApiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool Set(DescID descid, BaseContainer datadescription, BaseList2D bl) {
    bool ret = C4dApiPINVOKE.DynamicDescription_Set(swigCPtr, DescID.getCPtr(descid), BaseContainer.getCPtr(datadescription), BaseList2D.getCPtr(bl));
    if (C4dApiPINVOKE.SWIGPendingException.Pending) throw C4dApiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public BaseContainer Find(DescID descid) {
    global::System.IntPtr cPtr = C4dApiPINVOKE.DynamicDescription_Find(swigCPtr, DescID.getCPtr(descid));
    BaseContainer ret = (cPtr == global::System.IntPtr.Zero) ? null : new BaseContainer(cPtr, false);
    if (C4dApiPINVOKE.SWIGPendingException.Pending) throw C4dApiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool Remove(DescID descid) {
    bool ret = C4dApiPINVOKE.DynamicDescription_Remove(swigCPtr, DescID.getCPtr(descid));
    if (C4dApiPINVOKE.SWIGPendingException.Pending) throw C4dApiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool CopyTo(DynamicDescription dest) {
    bool ret = C4dApiPINVOKE.DynamicDescription_CopyTo(swigCPtr, DynamicDescription.getCPtr(dest));
    return ret;
  }

  public SWIGTYPE_p_void BrowseInit() {
    global::System.IntPtr cPtr = C4dApiPINVOKE.DynamicDescription_BrowseInit(swigCPtr);
    SWIGTYPE_p_void ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_void(cPtr, false);
    return ret;
  }

  public bool BrowseGetNext(SWIGTYPE_p_void handle, DescID id, SWIGTYPE_p_p_BaseContainer data) {
    bool ret = C4dApiPINVOKE.DynamicDescription_BrowseGetNext(swigCPtr, SWIGTYPE_p_void.getCPtr(handle), DescID.getCPtr(id), SWIGTYPE_p_p_BaseContainer.getCPtr(data));
    return ret;
  }

  public void BrowseFree(SWIGTYPE_p_p_void handle) {
    C4dApiPINVOKE.DynamicDescription_BrowseFree(swigCPtr, SWIGTYPE_p_p_void.getCPtr(handle));
    if (C4dApiPINVOKE.SWIGPendingException.Pending) throw C4dApiPINVOKE.SWIGPendingException.Retrieve();
  }

  public bool FillDefaultContainer(BaseContainer res, int type, string /* constString&_cstype */ name) {
    bool ret = C4dApiPINVOKE.DynamicDescription_FillDefaultContainer(swigCPtr, BaseContainer.getCPtr(res), type, name);
    if (C4dApiPINVOKE.SWIGPendingException.Pending) throw C4dApiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public uint GetDirty() {
    uint ret = C4dApiPINVOKE.DynamicDescription_GetDirty(swigCPtr);
    return ret;
  }

}

}
