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

namespace JP.Wasabeef.Recyclerview.Animators {

	// Metadata.xml XPath class reference: path="/api/package[@name='jp.wasabeef.recyclerview.animators']/class[@name='ScaleInLeftAnimator']"
	[global::Android.Runtime.Register ("jp/wasabeef/recyclerview/animators/ScaleInLeftAnimator", DoNotGenerateAcw=true)]
	public partial class ScaleInLeftAnimator : global::JP.Wasabeef.Recyclerview.Animators.BaseItemAnimator {
		static readonly JniPeerMembers _members = new XAPeerMembers ("jp/wasabeef/recyclerview/animators/ScaleInLeftAnimator", typeof (ScaleInLeftAnimator));

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

		protected ScaleInLeftAnimator (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='jp.wasabeef.recyclerview.animators']/class[@name='ScaleInLeftAnimator']/constructor[@name='ScaleInLeftAnimator' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ScaleInLeftAnimator () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "()V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), null);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='jp.wasabeef.recyclerview.animators']/class[@name='ScaleInLeftAnimator']/constructor[@name='ScaleInLeftAnimator' and count(parameter)=1 and parameter[1][@type='android.view.animation.Interpolator']]"
		[Register (".ctor", "(Landroid/view/animation/Interpolator;)V", "")]
		public unsafe ScaleInLeftAnimator (global::Android.Views.Animations.IInterpolator interpolator) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/view/animation/Interpolator;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((interpolator == null) ? IntPtr.Zero : ((global::Java.Lang.Object) interpolator).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (interpolator);
			}
		}

		static Delegate cb_animateAddImpl_Landroid_support_v7_widget_RecyclerView_ViewHolder_;
#pragma warning disable 0169
		static Delegate GetAnimateAddImpl_Landroid_support_v7_widget_RecyclerView_ViewHolder_Handler ()
		{
			if (cb_animateAddImpl_Landroid_support_v7_widget_RecyclerView_ViewHolder_ == null)
				cb_animateAddImpl_Landroid_support_v7_widget_RecyclerView_ViewHolder_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_AnimateAddImpl_Landroid_support_v7_widget_RecyclerView_ViewHolder_));
			return cb_animateAddImpl_Landroid_support_v7_widget_RecyclerView_ViewHolder_;
		}

		static void n_AnimateAddImpl_Landroid_support_v7_widget_RecyclerView_ViewHolder_ (IntPtr jnienv, IntPtr native__this, IntPtr native_holder)
		{
			var __this = global::Java.Lang.Object.GetObject<global::JP.Wasabeef.Recyclerview.Animators.ScaleInLeftAnimator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var holder = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Widget.RecyclerView.ViewHolder> (native_holder, JniHandleOwnership.DoNotTransfer);
			__this.AnimateAddImpl (holder);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='jp.wasabeef.recyclerview.animators']/class[@name='ScaleInLeftAnimator']/method[@name='animateAddImpl' and count(parameter)=1 and parameter[1][@type='android.support.v7.widget.RecyclerView.ViewHolder']]"
		[Register ("animateAddImpl", "(Landroid/support/v7/widget/RecyclerView$ViewHolder;)V", "GetAnimateAddImpl_Landroid_support_v7_widget_RecyclerView_ViewHolder_Handler")]
		protected override unsafe void AnimateAddImpl (global::Android.Support.V7.Widget.RecyclerView.ViewHolder holder)
		{
			const string __id = "animateAddImpl.(Landroid/support/v7/widget/RecyclerView$ViewHolder;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((holder == null) ? IntPtr.Zero : ((global::Java.Lang.Object) holder).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (holder);
			}
		}

		static Delegate cb_animateRemoveImpl_Landroid_support_v7_widget_RecyclerView_ViewHolder_;
#pragma warning disable 0169
		static Delegate GetAnimateRemoveImpl_Landroid_support_v7_widget_RecyclerView_ViewHolder_Handler ()
		{
			if (cb_animateRemoveImpl_Landroid_support_v7_widget_RecyclerView_ViewHolder_ == null)
				cb_animateRemoveImpl_Landroid_support_v7_widget_RecyclerView_ViewHolder_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_AnimateRemoveImpl_Landroid_support_v7_widget_RecyclerView_ViewHolder_));
			return cb_animateRemoveImpl_Landroid_support_v7_widget_RecyclerView_ViewHolder_;
		}

		static void n_AnimateRemoveImpl_Landroid_support_v7_widget_RecyclerView_ViewHolder_ (IntPtr jnienv, IntPtr native__this, IntPtr native_holder)
		{
			var __this = global::Java.Lang.Object.GetObject<global::JP.Wasabeef.Recyclerview.Animators.ScaleInLeftAnimator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var holder = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Widget.RecyclerView.ViewHolder> (native_holder, JniHandleOwnership.DoNotTransfer);
			__this.AnimateRemoveImpl (holder);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='jp.wasabeef.recyclerview.animators']/class[@name='ScaleInLeftAnimator']/method[@name='animateRemoveImpl' and count(parameter)=1 and parameter[1][@type='android.support.v7.widget.RecyclerView.ViewHolder']]"
		[Register ("animateRemoveImpl", "(Landroid/support/v7/widget/RecyclerView$ViewHolder;)V", "GetAnimateRemoveImpl_Landroid_support_v7_widget_RecyclerView_ViewHolder_Handler")]
		protected override unsafe void AnimateRemoveImpl (global::Android.Support.V7.Widget.RecyclerView.ViewHolder holder)
		{
			const string __id = "animateRemoveImpl.(Landroid/support/v7/widget/RecyclerView$ViewHolder;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((holder == null) ? IntPtr.Zero : ((global::Java.Lang.Object) holder).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (holder);
			}
		}

	}
}
