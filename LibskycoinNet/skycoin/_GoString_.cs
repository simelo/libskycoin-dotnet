//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace skycoin {

public class _GoString_ : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal _GoString_(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(_GoString_ obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~_GoString_() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          skycoinPINVOKE.delete__GoString_(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public int SetString(string str) {
    int ret = skycoinPINVOKE._GoString__SetString(swigCPtr, str);
    return ret;
  }

  public string getString() {
    string ret = skycoinPINVOKE._GoString__getString(swigCPtr);
    return ret;
  }

  public int isEqual(_GoString_ string2) {
    int ret = skycoinPINVOKE._GoString__isEqual(swigCPtr, _GoString_.getCPtr(string2));
    return ret;
  }

  public string p {
    set {
      skycoinPINVOKE.set__GoString__p(swigCPtr, value);
    } 
    get {
      string ret = skycoinPINVOKE.get__GoString__p(swigCPtr);
      return ret;
    } 
  }

  public int n {
    set {
      skycoinPINVOKE.set__GoString__n(swigCPtr, value);
    } 
    get {
      int ret = skycoinPINVOKE.get__GoString__n(swigCPtr);
      return ret;
    } 
  }

  public _GoString_() : this(skycoinPINVOKE.new__GoString_(), true) {
  }

}

}
