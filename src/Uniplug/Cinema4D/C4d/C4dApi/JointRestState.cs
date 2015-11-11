/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 3.0.2
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace C4d {

public class JointRestState : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal JointRestState(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(JointRestState obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~JointRestState() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          C4dApiPINVOKE.delete_JointRestState(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public JointRestState() : this(C4dApiPINVOKE.new_JointRestState(), true) {
  }

  public Fusee.Math.double4x4 /* Matrix_cstype */ m_bMg {
    /* <Matrix_csvarin> */
    set 
	{
       double[] adbl_value;
       unsafe 
	   {
		   adbl_value = Fusee.Math.ArrayConvert.double4x4ToArrayDoubleC4DLayout(value);
           fixed (double *pdbl_value = adbl_value) 
		   {
              C4dApiPINVOKE.JointRestState_m_bMg_set(swigCPtr, (global::System.IntPtr) pdbl_value /*  Matrix_csin */);
		   }
	   }
    }  /* </Matrix_csvarin> */   
   /* <Matrix_csvarout> */
   get
   {  
      C34M ret_c34m = C4dApiPINVOKE.JointRestState_m_bMg_get(swigCPtr);
	  Fusee.Math.double4x4 ret;
	  unsafe {ret = Fusee.Math.ArrayConvert.ArrayDoubleC4DLayoutTodouble4x4(ret_c34m.m);}
      return ret;   
   } /* <Matrix_csvarout> */ 
  }

  public Fusee.Math.double4x4 /* Matrix_cstype */ m_bMi {
    /* <Matrix_csvarin> */
    set 
	{
       double[] adbl_value;
       unsafe 
	   {
		   adbl_value = Fusee.Math.ArrayConvert.double4x4ToArrayDoubleC4DLayout(value);
           fixed (double *pdbl_value = adbl_value) 
		   {
              C4dApiPINVOKE.JointRestState_m_bMi_set(swigCPtr, (global::System.IntPtr) pdbl_value /*  Matrix_csin */);
		   }
	   }
    }  /* </Matrix_csvarin> */   
   /* <Matrix_csvarout> */
   get
   {  
      C34M ret_c34m = C4dApiPINVOKE.JointRestState_m_bMi_get(swigCPtr);
	  Fusee.Math.double4x4 ret;
	  unsafe {ret = Fusee.Math.ArrayConvert.ArrayDoubleC4DLayoutTodouble4x4(ret_c34m.m);}
      return ret;   
   } /* <Matrix_csvarout> */ 
  }

  public Fusee.Math.double4x4 /* Matrix_cstype */ m_oMg {
    /* <Matrix_csvarin> */
    set 
	{
       double[] adbl_value;
       unsafe 
	   {
		   adbl_value = Fusee.Math.ArrayConvert.double4x4ToArrayDoubleC4DLayout(value);
           fixed (double *pdbl_value = adbl_value) 
		   {
              C4dApiPINVOKE.JointRestState_m_oMg_set(swigCPtr, (global::System.IntPtr) pdbl_value /*  Matrix_csin */);
		   }
	   }
    }  /* </Matrix_csvarin> */   
   /* <Matrix_csvarout> */
   get
   {  
      C34M ret_c34m = C4dApiPINVOKE.JointRestState_m_oMg_get(swigCPtr);
	  Fusee.Math.double4x4 ret;
	  unsafe {ret = Fusee.Math.ArrayConvert.ArrayDoubleC4DLayoutTodouble4x4(ret_c34m.m);}
      return ret;   
   } /* <Matrix_csvarout> */ 
  }

  public Fusee.Math.double4x4 /* Matrix_cstype */ m_oMi {
    /* <Matrix_csvarin> */
    set 
	{
       double[] adbl_value;
       unsafe 
	   {
		   adbl_value = Fusee.Math.ArrayConvert.double4x4ToArrayDoubleC4DLayout(value);
           fixed (double *pdbl_value = adbl_value) 
		   {
              C4dApiPINVOKE.JointRestState_m_oMi_set(swigCPtr, (global::System.IntPtr) pdbl_value /*  Matrix_csin */);
		   }
	   }
    }  /* </Matrix_csvarin> */   
   /* <Matrix_csvarout> */
   get
   {  
      C34M ret_c34m = C4dApiPINVOKE.JointRestState_m_oMi_get(swigCPtr);
	  Fusee.Math.double4x4 ret;
	  unsafe {ret = Fusee.Math.ArrayConvert.ArrayDoubleC4DLayoutTodouble4x4(ret_c34m.m);}
      return ret;   
   } /* <Matrix_csvarout> */ 
  }

  public double m_Len {
    set {
      C4dApiPINVOKE.JointRestState_m_Len_set(swigCPtr, value);
    } 
    get {
      double ret = C4dApiPINVOKE.JointRestState_m_Len_get(swigCPtr);
      return ret;
    } 
  }

}

}
