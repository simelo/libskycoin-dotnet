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

public class wallet__UxBalance : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal wallet__UxBalance(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(wallet__UxBalance obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~wallet__UxBalance() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          skycoinPINVOKE.delete_wallet__UxBalance(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public SWIGTYPE_p_GoUint8_ Hash {
    set {
      skycoinPINVOKE.set_wallet__UxBalance_Hash(swigCPtr, SWIGTYPE_p_GoUint8_.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = skycoinPINVOKE.get_wallet__UxBalance_Hash(swigCPtr);
      SWIGTYPE_p_GoUint8_ ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_GoUint8_(cPtr, false);
      return ret;
    } 
  }

  public long BkSeq {
    set {
      skycoinPINVOKE.set_wallet__UxBalance_BkSeq(swigCPtr, value);
    } 
    get {
      long ret = skycoinPINVOKE.get_wallet__UxBalance_BkSeq(swigCPtr);
      return ret;
    } 
  }

  public cipher__Address Address {
    set {
      skycoinPINVOKE.set_wallet__UxBalance_Address(swigCPtr, cipher__Address.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = skycoinPINVOKE.get_wallet__UxBalance_Address(swigCPtr);
      cipher__Address ret = (cPtr == global::System.IntPtr.Zero) ? null : new cipher__Address(cPtr, false);
      return ret;
    } 
  }

  public long Coins {
    set {
      skycoinPINVOKE.set_wallet__UxBalance_Coins(swigCPtr, value);
    } 
    get {
      long ret = skycoinPINVOKE.get_wallet__UxBalance_Coins(swigCPtr);
      return ret;
    } 
  }

  public long Hours {
    set {
      skycoinPINVOKE.set_wallet__UxBalance_Hours(swigCPtr, value);
    } 
    get {
      long ret = skycoinPINVOKE.get_wallet__UxBalance_Hours(swigCPtr);
      return ret;
    } 
  }

  public wallet__UxBalance() : this(skycoinPINVOKE.new_wallet__UxBalance(), true) {
  }

}

}
