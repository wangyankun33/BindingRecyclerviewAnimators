//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

#nullable restore
using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace JP.Wasabeef.Recyclerview.Adapters {

	// Metadata.xml XPath class reference: path="/api/package[@name='jp.wasabeef.recyclerview.adapters']/class[@name='SlideInBottomAnimationAdapter']"
	[global::Android.Runtime.Register ("jp/wasabeef/recyclerview/adapters/SlideInBottomAnimationAdapter", DoNotGenerateAcw=true)]
	public partial class SlideInBottomAnimationAdapter : global::JP.Wasabeef.Recyclerview.Adapters.AnimationAdapter {
		static readonly JniPeerMembers _members = new XAPeerMembers ("jp/wasabeef/recyclerview/adapters/SlideInBottomAnimationAdapter", typeof (SlideInBottomAnimationAdapter));

		internal static new IntPtr class_ref {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		protected SlideInBottomAnimationAdapter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='jp.wasabeef.recyclerview.adapters']/class[@name='SlideInBottomAnimationAdapter']/constructor[@name='SlideInBottomAnimationAdapter' and count(parameter)=1 and parameter[1][@type='android.support.v7.widget.RecyclerView.Adapter']]"
		[Register (".ctor", "(Landroid/support/v7/widget/RecyclerView$Adapter;)V", "")]
		public unsafe SlideInBottomAnimationAdapter (global::Android.Support.V7.Widget.RecyclerView.Adapter adapter) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/support/v7/widget/RecyclerView$Adapter;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((adapter == null) ? IntPtr.Zero : ((global::Java.Lang.Object) adapter).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (adapter);
			}
		}

		static Delegate cb_getAnimators_Landroid_view_View_;
#pragma warning disable 0169
		static Delegate GetGetAnimators_Landroid_view_View_Handler ()
		{
			if (cb_getAnimators_Landroid_view_View_ == null)
				cb_getAnimators_Landroid_view_View_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_L (n_GetAnimators_Landroid_view_View_));
			return cb_getAnimators_Landroid_view_View_;
		}

		static IntPtr n_GetAnimators_Landroid_view_View_ (IntPtr jnienv, IntPtr native__this, IntPtr native_view)
		{
			var __this = global::Java.Lang.Object.GetObject<global::JP.Wasabeef.Recyclerview.Adapters.SlideInBottomAnimationAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var view = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_view, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewArray (__this.GetAnimators (view));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='jp.wasabeef.recyclerview.adapters']/class[@name='SlideInBottomAnimationAdapter']/method[@name='getAnimators' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
		[Register ("getAnimators", "(Landroid/view/View;)[Landroid/animation/Animator;", "GetGetAnimators_Landroid_view_View_Handler")]
		protected override unsafe global::Android.Animation.Animator[] GetAnimators (global::Android.Views.View view)
		{
			const string __id = "getAnimators.(Landroid/view/View;)[Landroid/animation/Animator;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((view == null) ? IntPtr.Zero : ((global::Java.Lang.Object) view).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (global::Android.Animation.Animator[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Android.Animation.Animator));
			} finally {
				global::System.GC.KeepAlive (view);
			}
		}

	}
}
