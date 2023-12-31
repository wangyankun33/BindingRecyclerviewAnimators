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

	// Metadata.xml XPath class reference: path="/api/package[@name='jp.wasabeef.recyclerview.animators']/class[@name='BaseItemAnimator']"
	[global::Android.Runtime.Register ("jp/wasabeef/recyclerview/animators/BaseItemAnimator", DoNotGenerateAcw=true)]
	public abstract partial class BaseItemAnimator : global::Android.Support.V7.Widget.SimpleItemAnimator {

		// Metadata.xml XPath field reference: path="/api/package[@name='jp.wasabeef.recyclerview.animators']/class[@name='BaseItemAnimator']/field[@name='mAddAnimations']"
		[Register ("mAddAnimations")]
		protected global::System.Collections.IList MAddAnimations {
			get {
				const string __id = "mAddAnimations.Ljava/util/ArrayList;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Android.Runtime.JavaList.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mAddAnimations.Ljava/util/ArrayList;";

				IntPtr native_value = global::Android.Runtime.JavaList.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='jp.wasabeef.recyclerview.animators']/class[@name='BaseItemAnimator']/field[@name='mInterpolator']"
		[Register ("mInterpolator")]
		protected global::Android.Views.Animations.IInterpolator MInterpolator {
			get {
				const string __id = "mInterpolator.Landroid/view/animation/Interpolator;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Android.Views.Animations.IInterpolator> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mInterpolator.Landroid/view/animation/Interpolator;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='jp.wasabeef.recyclerview.animators']/class[@name='BaseItemAnimator']/field[@name='mRemoveAnimations']"
		[Register ("mRemoveAnimations")]
		protected global::System.Collections.IList MRemoveAnimations {
			get {
				const string __id = "mRemoveAnimations.Ljava/util/ArrayList;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Android.Runtime.JavaList.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mRemoveAnimations.Ljava/util/ArrayList;";

				IntPtr native_value = global::Android.Runtime.JavaList.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("jp/wasabeef/recyclerview/animators/BaseItemAnimator", typeof (BaseItemAnimator));

		internal static IntPtr class_ref {
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

		protected BaseItemAnimator (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='jp.wasabeef.recyclerview.animators']/class[@name='BaseItemAnimator']/constructor[@name='BaseItemAnimator' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe BaseItemAnimator () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		static Delegate cb_isRunning;
#pragma warning disable 0169
		static Delegate GetIsRunningHandler ()
		{
			if (cb_isRunning == null)
				cb_isRunning = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_Z (n_IsRunning));
			return cb_isRunning;
		}

		static bool n_IsRunning (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::JP.Wasabeef.Recyclerview.Animators.BaseItemAnimator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsRunning;
		}
#pragma warning restore 0169

		public override unsafe bool IsRunning {
			// Metadata.xml XPath method reference: path="/api/package[@name='jp.wasabeef.recyclerview.animators']/class[@name='BaseItemAnimator']/method[@name='isRunning' and count(parameter)=0]"
			[Register ("isRunning", "()Z", "GetIsRunningHandler")]
			get {
				const string __id = "isRunning.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_animateAdd_Landroid_support_v7_widget_RecyclerView_ViewHolder_;
#pragma warning disable 0169
		static Delegate GetAnimateAdd_Landroid_support_v7_widget_RecyclerView_ViewHolder_Handler ()
		{
			if (cb_animateAdd_Landroid_support_v7_widget_RecyclerView_ViewHolder_ == null)
				cb_animateAdd_Landroid_support_v7_widget_RecyclerView_ViewHolder_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_Z (n_AnimateAdd_Landroid_support_v7_widget_RecyclerView_ViewHolder_));
			return cb_animateAdd_Landroid_support_v7_widget_RecyclerView_ViewHolder_;
		}

		static bool n_AnimateAdd_Landroid_support_v7_widget_RecyclerView_ViewHolder_ (IntPtr jnienv, IntPtr native__this, IntPtr native_holder)
		{
			var __this = global::Java.Lang.Object.GetObject<global::JP.Wasabeef.Recyclerview.Animators.BaseItemAnimator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var holder = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Widget.RecyclerView.ViewHolder> (native_holder, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.AnimateAdd (holder);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='jp.wasabeef.recyclerview.animators']/class[@name='BaseItemAnimator']/method[@name='animateAdd' and count(parameter)=1 and parameter[1][@type='android.support.v7.widget.RecyclerView.ViewHolder']]"
		[Register ("animateAdd", "(Landroid/support/v7/widget/RecyclerView$ViewHolder;)Z", "GetAnimateAdd_Landroid_support_v7_widget_RecyclerView_ViewHolder_Handler")]
		public override unsafe bool AnimateAdd (global::Android.Support.V7.Widget.RecyclerView.ViewHolder holder)
		{
			const string __id = "animateAdd.(Landroid/support/v7/widget/RecyclerView$ViewHolder;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((holder == null) ? IntPtr.Zero : ((global::Java.Lang.Object) holder).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (holder);
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

		static void n_AnimateAddImpl_Landroid_support_v7_widget_RecyclerView_ViewHolder_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::JP.Wasabeef.Recyclerview.Animators.BaseItemAnimator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Widget.RecyclerView.ViewHolder> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AnimateAddImpl (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='jp.wasabeef.recyclerview.animators']/class[@name='BaseItemAnimator']/method[@name='animateAddImpl' and count(parameter)=1 and parameter[1][@type='android.support.v7.widget.RecyclerView.ViewHolder']]"
		[Register ("animateAddImpl", "(Landroid/support/v7/widget/RecyclerView$ViewHolder;)V", "GetAnimateAddImpl_Landroid_support_v7_widget_RecyclerView_ViewHolder_Handler")]
		protected abstract void AnimateAddImpl (global::Android.Support.V7.Widget.RecyclerView.ViewHolder p0);

		static Delegate cb_animateChange_Landroid_support_v7_widget_RecyclerView_ViewHolder_Landroid_support_v7_widget_RecyclerView_ViewHolder_IIII;
#pragma warning disable 0169
		static Delegate GetAnimateChange_Landroid_support_v7_widget_RecyclerView_ViewHolder_Landroid_support_v7_widget_RecyclerView_ViewHolder_IIIIHandler ()
		{
			if (cb_animateChange_Landroid_support_v7_widget_RecyclerView_ViewHolder_Landroid_support_v7_widget_RecyclerView_ViewHolder_IIII == null)
				cb_animateChange_Landroid_support_v7_widget_RecyclerView_ViewHolder_Landroid_support_v7_widget_RecyclerView_ViewHolder_IIII = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLLIIII_Z (n_AnimateChange_Landroid_support_v7_widget_RecyclerView_ViewHolder_Landroid_support_v7_widget_RecyclerView_ViewHolder_IIII));
			return cb_animateChange_Landroid_support_v7_widget_RecyclerView_ViewHolder_Landroid_support_v7_widget_RecyclerView_ViewHolder_IIII;
		}

		static bool n_AnimateChange_Landroid_support_v7_widget_RecyclerView_ViewHolder_Landroid_support_v7_widget_RecyclerView_ViewHolder_IIII (IntPtr jnienv, IntPtr native__this, IntPtr native_oldHolder, IntPtr native_newHolder, int fromX, int fromY, int toX, int toY)
		{
			var __this = global::Java.Lang.Object.GetObject<global::JP.Wasabeef.Recyclerview.Animators.BaseItemAnimator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var oldHolder = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Widget.RecyclerView.ViewHolder> (native_oldHolder, JniHandleOwnership.DoNotTransfer);
			var newHolder = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Widget.RecyclerView.ViewHolder> (native_newHolder, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.AnimateChange (oldHolder, newHolder, fromX, fromY, toX, toY);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='jp.wasabeef.recyclerview.animators']/class[@name='BaseItemAnimator']/method[@name='animateChange' and count(parameter)=6 and parameter[1][@type='android.support.v7.widget.RecyclerView.ViewHolder'] and parameter[2][@type='android.support.v7.widget.RecyclerView.ViewHolder'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int'] and parameter[6][@type='int']]"
		[Register ("animateChange", "(Landroid/support/v7/widget/RecyclerView$ViewHolder;Landroid/support/v7/widget/RecyclerView$ViewHolder;IIII)Z", "GetAnimateChange_Landroid_support_v7_widget_RecyclerView_ViewHolder_Landroid_support_v7_widget_RecyclerView_ViewHolder_IIIIHandler")]
		public override unsafe bool AnimateChange (global::Android.Support.V7.Widget.RecyclerView.ViewHolder oldHolder, global::Android.Support.V7.Widget.RecyclerView.ViewHolder newHolder, int fromX, int fromY, int toX, int toY)
		{
			const string __id = "animateChange.(Landroid/support/v7/widget/RecyclerView$ViewHolder;Landroid/support/v7/widget/RecyclerView$ViewHolder;IIII)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [6];
				__args [0] = new JniArgumentValue ((oldHolder == null) ? IntPtr.Zero : ((global::Java.Lang.Object) oldHolder).Handle);
				__args [1] = new JniArgumentValue ((newHolder == null) ? IntPtr.Zero : ((global::Java.Lang.Object) newHolder).Handle);
				__args [2] = new JniArgumentValue (fromX);
				__args [3] = new JniArgumentValue (fromY);
				__args [4] = new JniArgumentValue (toX);
				__args [5] = new JniArgumentValue (toY);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (oldHolder);
				global::System.GC.KeepAlive (newHolder);
			}
		}

		static Delegate cb_animateMove_Landroid_support_v7_widget_RecyclerView_ViewHolder_IIII;
#pragma warning disable 0169
		static Delegate GetAnimateMove_Landroid_support_v7_widget_RecyclerView_ViewHolder_IIIIHandler ()
		{
			if (cb_animateMove_Landroid_support_v7_widget_RecyclerView_ViewHolder_IIII == null)
				cb_animateMove_Landroid_support_v7_widget_RecyclerView_ViewHolder_IIII = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLIIII_Z (n_AnimateMove_Landroid_support_v7_widget_RecyclerView_ViewHolder_IIII));
			return cb_animateMove_Landroid_support_v7_widget_RecyclerView_ViewHolder_IIII;
		}

		static bool n_AnimateMove_Landroid_support_v7_widget_RecyclerView_ViewHolder_IIII (IntPtr jnienv, IntPtr native__this, IntPtr native_holder, int fromX, int fromY, int toX, int toY)
		{
			var __this = global::Java.Lang.Object.GetObject<global::JP.Wasabeef.Recyclerview.Animators.BaseItemAnimator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var holder = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Widget.RecyclerView.ViewHolder> (native_holder, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.AnimateMove (holder, fromX, fromY, toX, toY);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='jp.wasabeef.recyclerview.animators']/class[@name='BaseItemAnimator']/method[@name='animateMove' and count(parameter)=5 and parameter[1][@type='android.support.v7.widget.RecyclerView.ViewHolder'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int']]"
		[Register ("animateMove", "(Landroid/support/v7/widget/RecyclerView$ViewHolder;IIII)Z", "GetAnimateMove_Landroid_support_v7_widget_RecyclerView_ViewHolder_IIIIHandler")]
		public override unsafe bool AnimateMove (global::Android.Support.V7.Widget.RecyclerView.ViewHolder holder, int fromX, int fromY, int toX, int toY)
		{
			const string __id = "animateMove.(Landroid/support/v7/widget/RecyclerView$ViewHolder;IIII)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue ((holder == null) ? IntPtr.Zero : ((global::Java.Lang.Object) holder).Handle);
				__args [1] = new JniArgumentValue (fromX);
				__args [2] = new JniArgumentValue (fromY);
				__args [3] = new JniArgumentValue (toX);
				__args [4] = new JniArgumentValue (toY);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (holder);
			}
		}

		static Delegate cb_animateRemove_Landroid_support_v7_widget_RecyclerView_ViewHolder_;
#pragma warning disable 0169
		static Delegate GetAnimateRemove_Landroid_support_v7_widget_RecyclerView_ViewHolder_Handler ()
		{
			if (cb_animateRemove_Landroid_support_v7_widget_RecyclerView_ViewHolder_ == null)
				cb_animateRemove_Landroid_support_v7_widget_RecyclerView_ViewHolder_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_Z (n_AnimateRemove_Landroid_support_v7_widget_RecyclerView_ViewHolder_));
			return cb_animateRemove_Landroid_support_v7_widget_RecyclerView_ViewHolder_;
		}

		static bool n_AnimateRemove_Landroid_support_v7_widget_RecyclerView_ViewHolder_ (IntPtr jnienv, IntPtr native__this, IntPtr native_holder)
		{
			var __this = global::Java.Lang.Object.GetObject<global::JP.Wasabeef.Recyclerview.Animators.BaseItemAnimator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var holder = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Widget.RecyclerView.ViewHolder> (native_holder, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.AnimateRemove (holder);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='jp.wasabeef.recyclerview.animators']/class[@name='BaseItemAnimator']/method[@name='animateRemove' and count(parameter)=1 and parameter[1][@type='android.support.v7.widget.RecyclerView.ViewHolder']]"
		[Register ("animateRemove", "(Landroid/support/v7/widget/RecyclerView$ViewHolder;)Z", "GetAnimateRemove_Landroid_support_v7_widget_RecyclerView_ViewHolder_Handler")]
		public override unsafe bool AnimateRemove (global::Android.Support.V7.Widget.RecyclerView.ViewHolder holder)
		{
			const string __id = "animateRemove.(Landroid/support/v7/widget/RecyclerView$ViewHolder;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((holder == null) ? IntPtr.Zero : ((global::Java.Lang.Object) holder).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
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

		static void n_AnimateRemoveImpl_Landroid_support_v7_widget_RecyclerView_ViewHolder_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::JP.Wasabeef.Recyclerview.Animators.BaseItemAnimator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Widget.RecyclerView.ViewHolder> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AnimateRemoveImpl (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='jp.wasabeef.recyclerview.animators']/class[@name='BaseItemAnimator']/method[@name='animateRemoveImpl' and count(parameter)=1 and parameter[1][@type='android.support.v7.widget.RecyclerView.ViewHolder']]"
		[Register ("animateRemoveImpl", "(Landroid/support/v7/widget/RecyclerView$ViewHolder;)V", "GetAnimateRemoveImpl_Landroid_support_v7_widget_RecyclerView_ViewHolder_Handler")]
		protected abstract void AnimateRemoveImpl (global::Android.Support.V7.Widget.RecyclerView.ViewHolder p0);

		static Delegate cb_endAnimation_Landroid_support_v7_widget_RecyclerView_ViewHolder_;
#pragma warning disable 0169
		static Delegate GetEndAnimation_Landroid_support_v7_widget_RecyclerView_ViewHolder_Handler ()
		{
			if (cb_endAnimation_Landroid_support_v7_widget_RecyclerView_ViewHolder_ == null)
				cb_endAnimation_Landroid_support_v7_widget_RecyclerView_ViewHolder_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_EndAnimation_Landroid_support_v7_widget_RecyclerView_ViewHolder_));
			return cb_endAnimation_Landroid_support_v7_widget_RecyclerView_ViewHolder_;
		}

		static void n_EndAnimation_Landroid_support_v7_widget_RecyclerView_ViewHolder_ (IntPtr jnienv, IntPtr native__this, IntPtr native_item)
		{
			var __this = global::Java.Lang.Object.GetObject<global::JP.Wasabeef.Recyclerview.Animators.BaseItemAnimator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var item = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Widget.RecyclerView.ViewHolder> (native_item, JniHandleOwnership.DoNotTransfer);
			__this.EndAnimation (item);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='jp.wasabeef.recyclerview.animators']/class[@name='BaseItemAnimator']/method[@name='endAnimation' and count(parameter)=1 and parameter[1][@type='android.support.v7.widget.RecyclerView.ViewHolder']]"
		[Register ("endAnimation", "(Landroid/support/v7/widget/RecyclerView$ViewHolder;)V", "GetEndAnimation_Landroid_support_v7_widget_RecyclerView_ViewHolder_Handler")]
		public override unsafe void EndAnimation (global::Android.Support.V7.Widget.RecyclerView.ViewHolder item)
		{
			const string __id = "endAnimation.(Landroid/support/v7/widget/RecyclerView$ViewHolder;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((item == null) ? IntPtr.Zero : ((global::Java.Lang.Object) item).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (item);
			}
		}

		static Delegate cb_endAnimations;
#pragma warning disable 0169
		static Delegate GetEndAnimationsHandler ()
		{
			if (cb_endAnimations == null)
				cb_endAnimations = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_V (n_EndAnimations));
			return cb_endAnimations;
		}

		static void n_EndAnimations (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::JP.Wasabeef.Recyclerview.Animators.BaseItemAnimator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.EndAnimations ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='jp.wasabeef.recyclerview.animators']/class[@name='BaseItemAnimator']/method[@name='endAnimations' and count(parameter)=0]"
		[Register ("endAnimations", "()V", "GetEndAnimationsHandler")]
		public override unsafe void EndAnimations ()
		{
			const string __id = "endAnimations.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_getAddDelay_Landroid_support_v7_widget_RecyclerView_ViewHolder_;
#pragma warning disable 0169
		static Delegate GetGetAddDelay_Landroid_support_v7_widget_RecyclerView_ViewHolder_Handler ()
		{
			if (cb_getAddDelay_Landroid_support_v7_widget_RecyclerView_ViewHolder_ == null)
				cb_getAddDelay_Landroid_support_v7_widget_RecyclerView_ViewHolder_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_J (n_GetAddDelay_Landroid_support_v7_widget_RecyclerView_ViewHolder_));
			return cb_getAddDelay_Landroid_support_v7_widget_RecyclerView_ViewHolder_;
		}

		static long n_GetAddDelay_Landroid_support_v7_widget_RecyclerView_ViewHolder_ (IntPtr jnienv, IntPtr native__this, IntPtr native_holder)
		{
			var __this = global::Java.Lang.Object.GetObject<global::JP.Wasabeef.Recyclerview.Animators.BaseItemAnimator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var holder = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Widget.RecyclerView.ViewHolder> (native_holder, JniHandleOwnership.DoNotTransfer);
			long __ret = __this.GetAddDelay (holder);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='jp.wasabeef.recyclerview.animators']/class[@name='BaseItemAnimator']/method[@name='getAddDelay' and count(parameter)=1 and parameter[1][@type='android.support.v7.widget.RecyclerView.ViewHolder']]"
		[Register ("getAddDelay", "(Landroid/support/v7/widget/RecyclerView$ViewHolder;)J", "GetGetAddDelay_Landroid_support_v7_widget_RecyclerView_ViewHolder_Handler")]
		protected virtual unsafe long GetAddDelay (global::Android.Support.V7.Widget.RecyclerView.ViewHolder holder)
		{
			const string __id = "getAddDelay.(Landroid/support/v7/widget/RecyclerView$ViewHolder;)J";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((holder == null) ? IntPtr.Zero : ((global::Java.Lang.Object) holder).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (holder);
			}
		}

		static Delegate cb_getRemoveDelay_Landroid_support_v7_widget_RecyclerView_ViewHolder_;
#pragma warning disable 0169
		static Delegate GetGetRemoveDelay_Landroid_support_v7_widget_RecyclerView_ViewHolder_Handler ()
		{
			if (cb_getRemoveDelay_Landroid_support_v7_widget_RecyclerView_ViewHolder_ == null)
				cb_getRemoveDelay_Landroid_support_v7_widget_RecyclerView_ViewHolder_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_J (n_GetRemoveDelay_Landroid_support_v7_widget_RecyclerView_ViewHolder_));
			return cb_getRemoveDelay_Landroid_support_v7_widget_RecyclerView_ViewHolder_;
		}

		static long n_GetRemoveDelay_Landroid_support_v7_widget_RecyclerView_ViewHolder_ (IntPtr jnienv, IntPtr native__this, IntPtr native_holder)
		{
			var __this = global::Java.Lang.Object.GetObject<global::JP.Wasabeef.Recyclerview.Animators.BaseItemAnimator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var holder = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Widget.RecyclerView.ViewHolder> (native_holder, JniHandleOwnership.DoNotTransfer);
			long __ret = __this.GetRemoveDelay (holder);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='jp.wasabeef.recyclerview.animators']/class[@name='BaseItemAnimator']/method[@name='getRemoveDelay' and count(parameter)=1 and parameter[1][@type='android.support.v7.widget.RecyclerView.ViewHolder']]"
		[Register ("getRemoveDelay", "(Landroid/support/v7/widget/RecyclerView$ViewHolder;)J", "GetGetRemoveDelay_Landroid_support_v7_widget_RecyclerView_ViewHolder_Handler")]
		protected virtual unsafe long GetRemoveDelay (global::Android.Support.V7.Widget.RecyclerView.ViewHolder holder)
		{
			const string __id = "getRemoveDelay.(Landroid/support/v7/widget/RecyclerView$ViewHolder;)J";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((holder == null) ? IntPtr.Zero : ((global::Java.Lang.Object) holder).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (holder);
			}
		}

		static Delegate cb_preAnimateAddImpl_Landroid_support_v7_widget_RecyclerView_ViewHolder_;
#pragma warning disable 0169
		static Delegate GetPreAnimateAddImpl_Landroid_support_v7_widget_RecyclerView_ViewHolder_Handler ()
		{
			if (cb_preAnimateAddImpl_Landroid_support_v7_widget_RecyclerView_ViewHolder_ == null)
				cb_preAnimateAddImpl_Landroid_support_v7_widget_RecyclerView_ViewHolder_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_PreAnimateAddImpl_Landroid_support_v7_widget_RecyclerView_ViewHolder_));
			return cb_preAnimateAddImpl_Landroid_support_v7_widget_RecyclerView_ViewHolder_;
		}

		static void n_PreAnimateAddImpl_Landroid_support_v7_widget_RecyclerView_ViewHolder_ (IntPtr jnienv, IntPtr native__this, IntPtr native_holder)
		{
			var __this = global::Java.Lang.Object.GetObject<global::JP.Wasabeef.Recyclerview.Animators.BaseItemAnimator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var holder = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Widget.RecyclerView.ViewHolder> (native_holder, JniHandleOwnership.DoNotTransfer);
			__this.PreAnimateAddImpl (holder);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='jp.wasabeef.recyclerview.animators']/class[@name='BaseItemAnimator']/method[@name='preAnimateAddImpl' and count(parameter)=1 and parameter[1][@type='android.support.v7.widget.RecyclerView.ViewHolder']]"
		[Register ("preAnimateAddImpl", "(Landroid/support/v7/widget/RecyclerView$ViewHolder;)V", "GetPreAnimateAddImpl_Landroid_support_v7_widget_RecyclerView_ViewHolder_Handler")]
		protected virtual unsafe void PreAnimateAddImpl (global::Android.Support.V7.Widget.RecyclerView.ViewHolder holder)
		{
			const string __id = "preAnimateAddImpl.(Landroid/support/v7/widget/RecyclerView$ViewHolder;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((holder == null) ? IntPtr.Zero : ((global::Java.Lang.Object) holder).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (holder);
			}
		}

		static Delegate cb_preAnimateRemoveImpl_Landroid_support_v7_widget_RecyclerView_ViewHolder_;
#pragma warning disable 0169
		static Delegate GetPreAnimateRemoveImpl_Landroid_support_v7_widget_RecyclerView_ViewHolder_Handler ()
		{
			if (cb_preAnimateRemoveImpl_Landroid_support_v7_widget_RecyclerView_ViewHolder_ == null)
				cb_preAnimateRemoveImpl_Landroid_support_v7_widget_RecyclerView_ViewHolder_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_PreAnimateRemoveImpl_Landroid_support_v7_widget_RecyclerView_ViewHolder_));
			return cb_preAnimateRemoveImpl_Landroid_support_v7_widget_RecyclerView_ViewHolder_;
		}

		static void n_PreAnimateRemoveImpl_Landroid_support_v7_widget_RecyclerView_ViewHolder_ (IntPtr jnienv, IntPtr native__this, IntPtr native_holder)
		{
			var __this = global::Java.Lang.Object.GetObject<global::JP.Wasabeef.Recyclerview.Animators.BaseItemAnimator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var holder = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Widget.RecyclerView.ViewHolder> (native_holder, JniHandleOwnership.DoNotTransfer);
			__this.PreAnimateRemoveImpl (holder);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='jp.wasabeef.recyclerview.animators']/class[@name='BaseItemAnimator']/method[@name='preAnimateRemoveImpl' and count(parameter)=1 and parameter[1][@type='android.support.v7.widget.RecyclerView.ViewHolder']]"
		[Register ("preAnimateRemoveImpl", "(Landroid/support/v7/widget/RecyclerView$ViewHolder;)V", "GetPreAnimateRemoveImpl_Landroid_support_v7_widget_RecyclerView_ViewHolder_Handler")]
		protected virtual unsafe void PreAnimateRemoveImpl (global::Android.Support.V7.Widget.RecyclerView.ViewHolder holder)
		{
			const string __id = "preAnimateRemoveImpl.(Landroid/support/v7/widget/RecyclerView$ViewHolder;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((holder == null) ? IntPtr.Zero : ((global::Java.Lang.Object) holder).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (holder);
			}
		}

		static Delegate cb_runPendingAnimations;
#pragma warning disable 0169
		static Delegate GetRunPendingAnimationsHandler ()
		{
			if (cb_runPendingAnimations == null)
				cb_runPendingAnimations = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_V (n_RunPendingAnimations));
			return cb_runPendingAnimations;
		}

		static void n_RunPendingAnimations (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::JP.Wasabeef.Recyclerview.Animators.BaseItemAnimator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RunPendingAnimations ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='jp.wasabeef.recyclerview.animators']/class[@name='BaseItemAnimator']/method[@name='runPendingAnimations' and count(parameter)=0]"
		[Register ("runPendingAnimations", "()V", "GetRunPendingAnimationsHandler")]
		public override unsafe void RunPendingAnimations ()
		{
			const string __id = "runPendingAnimations.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_setInterpolator_Landroid_view_animation_Interpolator_;
#pragma warning disable 0169
		static Delegate GetSetInterpolator_Landroid_view_animation_Interpolator_Handler ()
		{
			if (cb_setInterpolator_Landroid_view_animation_Interpolator_ == null)
				cb_setInterpolator_Landroid_view_animation_Interpolator_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_SetInterpolator_Landroid_view_animation_Interpolator_));
			return cb_setInterpolator_Landroid_view_animation_Interpolator_;
		}

		static void n_SetInterpolator_Landroid_view_animation_Interpolator_ (IntPtr jnienv, IntPtr native__this, IntPtr native_mInterpolator)
		{
			var __this = global::Java.Lang.Object.GetObject<global::JP.Wasabeef.Recyclerview.Animators.BaseItemAnimator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var mInterpolator = (global::Android.Views.Animations.IInterpolator)global::Java.Lang.Object.GetObject<global::Android.Views.Animations.IInterpolator> (native_mInterpolator, JniHandleOwnership.DoNotTransfer);
			__this.SetInterpolator (mInterpolator);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='jp.wasabeef.recyclerview.animators']/class[@name='BaseItemAnimator']/method[@name='setInterpolator' and count(parameter)=1 and parameter[1][@type='android.view.animation.Interpolator']]"
		[Register ("setInterpolator", "(Landroid/view/animation/Interpolator;)V", "GetSetInterpolator_Landroid_view_animation_Interpolator_Handler")]
		public virtual unsafe void SetInterpolator (global::Android.Views.Animations.IInterpolator mInterpolator)
		{
			const string __id = "setInterpolator.(Landroid/view/animation/Interpolator;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((mInterpolator == null) ? IntPtr.Zero : ((global::Java.Lang.Object) mInterpolator).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (mInterpolator);
			}
		}

	}

	[global::Android.Runtime.Register ("jp/wasabeef/recyclerview/animators/BaseItemAnimator", DoNotGenerateAcw=true)]
	internal partial class BaseItemAnimatorInvoker : BaseItemAnimator {
		public BaseItemAnimatorInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer)
		{
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("jp/wasabeef/recyclerview/animators/BaseItemAnimator", typeof (BaseItemAnimatorInvoker));

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='jp.wasabeef.recyclerview.animators']/class[@name='BaseItemAnimator']/method[@name='animateAddImpl' and count(parameter)=1 and parameter[1][@type='android.support.v7.widget.RecyclerView.ViewHolder']]"
		[Register ("animateAddImpl", "(Landroid/support/v7/widget/RecyclerView$ViewHolder;)V", "GetAnimateAddImpl_Landroid_support_v7_widget_RecyclerView_ViewHolder_Handler")]
		protected override unsafe void AnimateAddImpl (global::Android.Support.V7.Widget.RecyclerView.ViewHolder p0)
		{
			const string __id = "animateAddImpl.(Landroid/support/v7/widget/RecyclerView$ViewHolder;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='jp.wasabeef.recyclerview.animators']/class[@name='BaseItemAnimator']/method[@name='animateRemoveImpl' and count(parameter)=1 and parameter[1][@type='android.support.v7.widget.RecyclerView.ViewHolder']]"
		[Register ("animateRemoveImpl", "(Landroid/support/v7/widget/RecyclerView$ViewHolder;)V", "GetAnimateRemoveImpl_Landroid_support_v7_widget_RecyclerView_ViewHolder_Handler")]
		protected override unsafe void AnimateRemoveImpl (global::Android.Support.V7.Widget.RecyclerView.ViewHolder p0)
		{
			const string __id = "animateRemoveImpl.(Landroid/support/v7/widget/RecyclerView$ViewHolder;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

	}
}
