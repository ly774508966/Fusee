/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 3.0.2
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace C4d {

public class CommandInformationData : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CommandInformationData(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CommandInformationData obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CommandInformationData() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          C4dApiPINVOKE.delete_CommandInformationData(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public int command_id {
    set {
      C4dApiPINVOKE.CommandInformationData_command_id_set(swigCPtr, value);
    } 
    get {
      int ret = C4dApiPINVOKE.CommandInformationData_command_id_get(swigCPtr);
      return ret;
    } 
  }

  public int managergroup {
    set {
      C4dApiPINVOKE.CommandInformationData_managergroup_set(swigCPtr, value);
    } 
    get {
      int ret = C4dApiPINVOKE.CommandInformationData_managergroup_get(swigCPtr);
      return ret;
    } 
  }

  public int parentid {
    set {
      C4dApiPINVOKE.CommandInformationData_parentid_set(swigCPtr, value);
    } 
    get {
      int ret = C4dApiPINVOKE.CommandInformationData_parentid_get(swigCPtr);
      return ret;
    } 
  }

  public CommandInformationData() : this(C4dApiPINVOKE.new_CommandInformationData(), true) {
  }

}

}
