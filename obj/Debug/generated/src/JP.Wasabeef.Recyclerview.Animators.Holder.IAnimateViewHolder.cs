using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace JP.Wasabeef.Recyclerview.Animators.Holder {

	// Metadata.xml XPath interface reference: path="/api/package[@name='jp.wasabeef.recyclerview.animators.holder']/interface[@name='AnimateViewHolder']"
	[Register ("jp/wasabeef/recyclerview/animators/holder/AnimateViewHolder", "", "JP.Wasabeef.Recyclerview.Animators.Holder.IAnimateViewHolderInvoker")]
	public partial interface IAnimateViewHolder : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='jp.wasabeef.recyclerview.animators.holder']/interface[@name='AnimateViewHolder']/method[@name='animateAddImpl' and count(parameter)=2 and parameter[1][@type='android.support.v7.widget.RecyclerView.ViewHolder'] and parameter[2][@type='android.support.v4.view.ViewPropertyAnimatorListener']]"
		[Register ("animateAddImpl", "(Landroid/support/v7/widget/RecyclerView$ViewHolder;Landroid/support/v4/view/ViewPropertyAnimatorListener;)V", "GetAnimateAddImpl_Landroid_support_v7_widget_RecyclerView_ViewHolder_Landroid_support_v4_view_ViewPropertyAnimatorListener_Handler:JP.Wasabeef.Recyclerview.Animators.Holder.IAnimateViewHolderInvoker, BindingRecyclerviewAnimators")]
		void AnimateAddImpl (global::Android.Support.V7.Widget.RecyclerView.ViewHolder p0, global::Android.Support.V4.View.IViewPropertyAnimatorListener p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='jp.wasabeef.recyclerview.animators.holder']/interface[@name='AnimateViewHolder']/method[@name='animateRemoveImpl' and count(parameter)=2 and parameter[1][@type='android.support.v7.widget.RecyclerView.ViewHolder'] and parameter[2][@type='android.support.v4.view.ViewPropertyAnimatorListener']]"
		[Register ("animateRemoveImpl", "(Landroid/support/v7/widget/RecyclerView$ViewHolder;Landroid/support/v4/view/ViewPropertyAnimatorListener;)V", "GetAnimateRemoveImpl_Landroid_support_v7_widget_RecyclerView_ViewHolder_Landroid_support_v4_view_ViewPropertyAnimatorListener_Handler:JP.Wasabeef.Recyclerview.Animators.Holder.IAnimateViewHolderInvoker, BindingRecyclerviewAnimators")]
		void AnimateRemoveImpl (global::Android.Support.V7.Widget.RecyclerView.ViewHolder p0, global::Android.Support.V4.View.IViewPropertyAnimatorListener p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='jp.wasabeef.recyclerview.animators.holder']/interface[@name='AnimateViewHolder']/method[@name='preAnimateAddImpl' and count(parameter)=1 and parameter[1][@type='android.support.v7.widget.RecyclerView.ViewHolder']]"
		[Register ("preAnimateAddImpl", "(Landroid/support/v7/widget/RecyclerView$ViewHolder;)V", "GetPreAnimateAddImpl_Landroid_support_v7_widget_RecyclerView_ViewHolder_Handler:JP.Wasabeef.Recyclerview.Animators.Holder.IAnimateViewHolderInvoker, BindingRecyclerviewAnimators")]
		void PreAnimateAddImpl (global::Android.Support.V7.Widget.RecyclerView.ViewHolder p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='jp.wasabeef.recyclerview.animators.holder']/interface[@name='AnimateViewHolder']/method[@name='preAnimateRemoveImpl' and count(parameter)=1 and parameter[1][@type='android.support.v7.widget.RecyclerView.ViewHolder']]"
		[Register ("preAnimateRemoveImpl", "(Landroid/support/v7/widget/RecyclerView$ViewHolder;)V", "GetPreAnimateRemoveImpl_Landroid_support_v7_widget_RecyclerView_ViewHolder_Handler:JP.Wasabeef.Recyclerview.Animators.Holder.IAnimateViewHolderInvoker, BindingRecyclerviewAnimators")]
		void PreAnimateRemoveImpl (global::Android.Support.V7.Widget.RecyclerView.ViewHolder p0);

	}

	[global::Android.Runtime.Register ("jp/wasabeef/recyclerview/animators/holder/AnimateViewHolder", DoNotGenerateAcw=true)]
	internal partial class IAnimateViewHolderInvoker : global::Java.Lang.Object, IAnimateViewHolder {
		static readonly JniPeerMembers _members = new XAPeerMembers ("jp/wasabeef/recyclerview/animators/holder/AnimateViewHolder", typeof (IAnimateViewHolderInvoker));

		static IntPtr java_class_ref {
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
			get { return class_ref; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		IntPtr class_ref;

		public static IAnimateViewHolder GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IAnimateViewHolder> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'jp.wasabeef.recyclerview.animators.holder.AnimateViewHolder'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IAnimateViewHolderInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_animateAddImpl_Landroid_support_v7_widget_RecyclerView_ViewHolder_Landroid_support_v4_view_ViewPropertyAnimatorListener_;
#pragma warning disable 0169
		static Delegate GetAnimateAddImpl_Landroid_support_v7_widget_RecyclerView_ViewHolder_Landroid_support_v4_view_ViewPropertyAnimatorListener_Handler ()
		{
			if (cb_animateAddImpl_Landroid_support_v7_widget_RecyclerView_ViewHolder_Landroid_support_v4_view_ViewPropertyAnimatorListener_ == null)
				cb_animateAddImpl_Landroid_support_v7_widget_RecyclerView_ViewHolder_Landroid_support_v4_view_ViewPropertyAnimatorListener_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLL_V (n_AnimateAddImpl_Landroid_support_v7_widget_RecyclerView_ViewHolder_Landroid_support_v4_view_ViewPropertyAnimatorListener_));
			return cb_animateAddImpl_Landroid_support_v7_widget_RecyclerView_ViewHolder_Landroid_support_v4_view_ViewPropertyAnimatorListener_;
		}

		static void n_AnimateAddImpl_Landroid_support_v7_widget_RecyclerView_ViewHolder_Landroid_support_v4_view_ViewPropertyAnimatorListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::JP.Wasabeef.Recyclerview.Animators.Holder.IAnimateViewHolder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Widget.RecyclerView.ViewHolder> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = (global::Android.Support.V4.View.IViewPropertyAnimatorListener)global::Java.Lang.Object.GetObject<global::Android.Support.V4.View.IViewPropertyAnimatorListener> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.AnimateAddImpl (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_animateAddImpl_Landroid_support_v7_widget_RecyclerView_ViewHolder_Landroid_support_v4_view_ViewPropertyAnimatorListener_;
		public unsafe void AnimateAddImpl (global::Android.Support.V7.Widget.RecyclerView.ViewHolder p0, global::Android.Support.V4.View.IViewPropertyAnimatorListener p1)
		{
			if (id_animateAddImpl_Landroid_support_v7_widget_RecyclerView_ViewHolder_Landroid_support_v4_view_ViewPropertyAnimatorListener_ == IntPtr.Zero)
				id_animateAddImpl_Landroid_support_v7_widget_RecyclerView_ViewHolder_Landroid_support_v4_view_ViewPropertyAnimatorListener_ = JNIEnv.GetMethodID (class_ref, "animateAddImpl", "(Landroid/support/v7/widget/RecyclerView$ViewHolder;Landroid/support/v4/view/ViewPropertyAnimatorListener;)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_animateAddImpl_Landroid_support_v7_widget_RecyclerView_ViewHolder_Landroid_support_v4_view_ViewPropertyAnimatorListener_, __args);
		}

		static Delegate cb_animateRemoveImpl_Landroid_support_v7_widget_RecyclerView_ViewHolder_Landroid_support_v4_view_ViewPropertyAnimatorListener_;
#pragma warning disable 0169
		static Delegate GetAnimateRemoveImpl_Landroid_support_v7_widget_RecyclerView_ViewHolder_Landroid_support_v4_view_ViewPropertyAnimatorListener_Handler ()
		{
			if (cb_animateRemoveImpl_Landroid_support_v7_widget_RecyclerView_ViewHolder_Landroid_support_v4_view_ViewPropertyAnimatorListener_ == null)
				cb_animateRemoveImpl_Landroid_support_v7_widget_RecyclerView_ViewHolder_Landroid_support_v4_view_ViewPropertyAnimatorListener_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLL_V (n_AnimateRemoveImpl_Landroid_support_v7_widget_RecyclerView_ViewHolder_Landroid_support_v4_view_ViewPropertyAnimatorListener_));
			return cb_animateRemoveImpl_Landroid_support_v7_widget_RecyclerView_ViewHolder_Landroid_support_v4_view_ViewPropertyAnimatorListener_;
		}

		static void n_AnimateRemoveImpl_Landroid_support_v7_widget_RecyclerView_ViewHolder_Landroid_support_v4_view_ViewPropertyAnimatorListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::JP.Wasabeef.Recyclerview.Animators.Holder.IAnimateViewHolder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Widget.RecyclerView.ViewHolder> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = (global::Android.Support.V4.View.IViewPropertyAnimatorListener)global::Java.Lang.Object.GetObject<global::Android.Support.V4.View.IViewPropertyAnimatorListener> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.AnimateRemoveImpl (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_animateRemoveImpl_Landroid_support_v7_widget_RecyclerView_ViewHolder_Landroid_support_v4_view_ViewPropertyAnimatorListener_;
		public unsafe void AnimateRemoveImpl (global::Android.Support.V7.Widget.RecyclerView.ViewHolder p0, global::Android.Support.V4.View.IViewPropertyAnimatorListener p1)
		{
			if (id_animateRemoveImpl_Landroid_support_v7_widget_RecyclerView_ViewHolder_Landroid_support_v4_view_ViewPropertyAnimatorListener_ == IntPtr.Zero)
				id_animateRemoveImpl_Landroid_support_v7_widget_RecyclerView_ViewHolder_Landroid_support_v4_view_ViewPropertyAnimatorListener_ = JNIEnv.GetMethodID (class_ref, "animateRemoveImpl", "(Landroid/support/v7/widget/RecyclerView$ViewHolder;Landroid/support/v4/view/ViewPropertyAnimatorListener;)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_animateRemoveImpl_Landroid_support_v7_widget_RecyclerView_ViewHolder_Landroid_support_v4_view_ViewPropertyAnimatorListener_, __args);
		}

		static Delegate cb_preAnimateAddImpl_Landroid_support_v7_widget_RecyclerView_ViewHolder_;
#pragma warning disable 0169
		static Delegate GetPreAnimateAddImpl_Landroid_support_v7_widget_RecyclerView_ViewHolder_Handler ()
		{
			if (cb_preAnimateAddImpl_Landroid_support_v7_widget_RecyclerView_ViewHolder_ == null)
				cb_preAnimateAddImpl_Landroid_support_v7_widget_RecyclerView_ViewHolder_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_PreAnimateAddImpl_Landroid_support_v7_widget_RecyclerView_ViewHolder_));
			return cb_preAnimateAddImpl_Landroid_support_v7_widget_RecyclerView_ViewHolder_;
		}

		static void n_PreAnimateAddImpl_Landroid_support_v7_widget_RecyclerView_ViewHolder_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::JP.Wasabeef.Recyclerview.Animators.Holder.IAnimateViewHolder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Widget.RecyclerView.ViewHolder> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.PreAnimateAddImpl (p0);
		}
#pragma warning restore 0169

		IntPtr id_preAnimateAddImpl_Landroid_support_v7_widget_RecyclerView_ViewHolder_;
		public unsafe void PreAnimateAddImpl (global::Android.Support.V7.Widget.RecyclerView.ViewHolder p0)
		{
			if (id_preAnimateAddImpl_Landroid_support_v7_widget_RecyclerView_ViewHolder_ == IntPtr.Zero)
				id_preAnimateAddImpl_Landroid_support_v7_widget_RecyclerView_ViewHolder_ = JNIEnv.GetMethodID (class_ref, "preAnimateAddImpl", "(Landroid/support/v7/widget/RecyclerView$ViewHolder;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_preAnimateAddImpl_Landroid_support_v7_widget_RecyclerView_ViewHolder_, __args);
		}

		static Delegate cb_preAnimateRemoveImpl_Landroid_support_v7_widget_RecyclerView_ViewHolder_;
#pragma warning disable 0169
		static Delegate GetPreAnimateRemoveImpl_Landroid_support_v7_widget_RecyclerView_ViewHolder_Handler ()
		{
			if (cb_preAnimateRemoveImpl_Landroid_support_v7_widget_RecyclerView_ViewHolder_ == null)
				cb_preAnimateRemoveImpl_Landroid_support_v7_widget_RecyclerView_ViewHolder_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_PreAnimateRemoveImpl_Landroid_support_v7_widget_RecyclerView_ViewHolder_));
			return cb_preAnimateRemoveImpl_Landroid_support_v7_widget_RecyclerView_ViewHolder_;
		}

		static void n_PreAnimateRemoveImpl_Landroid_support_v7_widget_RecyclerView_ViewHolder_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::JP.Wasabeef.Recyclerview.Animators.Holder.IAnimateViewHolder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Widget.RecyclerView.ViewHolder> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.PreAnimateRemoveImpl (p0);
		}
#pragma warning restore 0169

		IntPtr id_preAnimateRemoveImpl_Landroid_support_v7_widget_RecyclerView_ViewHolder_;
		public unsafe void PreAnimateRemoveImpl (global::Android.Support.V7.Widget.RecyclerView.ViewHolder p0)
		{
			if (id_preAnimateRemoveImpl_Landroid_support_v7_widget_RecyclerView_ViewHolder_ == IntPtr.Zero)
				id_preAnimateRemoveImpl_Landroid_support_v7_widget_RecyclerView_ViewHolder_ = JNIEnv.GetMethodID (class_ref, "preAnimateRemoveImpl", "(Landroid/support/v7/widget/RecyclerView$ViewHolder;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_preAnimateRemoveImpl_Landroid_support_v7_widget_RecyclerView_ViewHolder_, __args);
		}

	}
}
