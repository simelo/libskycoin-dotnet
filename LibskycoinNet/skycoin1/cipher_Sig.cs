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

public class cipher_Sig : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal cipher_Sig(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(cipher_Sig obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~cipher_Sig() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          skycoinPINVOKE.delete_cipher_Sig(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public int isEqual(cipher_Sig a) {
    int ret = skycoinPINVOKE.cipher_Sig_isEqual(swigCPtr, cipher_Sig.getCPtr(a));
    return ret;
  }

  public void assignFrom(SWIGTYPE_p_void data) {
    skycoinPINVOKE.cipher_Sig_assignFrom(swigCPtr, SWIGTYPE_p_void.getCPtr(data));
  }

  public void assignTo(SWIGTYPE_p_void data) {
    skycoinPINVOKE.cipher_Sig_assignTo(swigCPtr, SWIGTYPE_p_void.getCPtr(data));
  }

  public SWIGTYPE_p_unsigned_char data {
    set {
      skycoinPINVOKE.cipher_Sig_data_set(swigCPtr, SWIGTYPE_p_unsigned_char.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = skycoinPINVOKE.cipher_Sig_data_get(swigCPtr);
      SWIGTYPE_p_unsigned_char ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_unsigned_char(cPtr, false);
      return ret;
    } 
  }

  public cipher_Sig() : this(skycoinPINVOKE.new_cipher_Sig(), true) {
  }

}

}
