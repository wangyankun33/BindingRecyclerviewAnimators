using System;

[assembly:global::Android.Runtime.NamespaceMapping (Java = "jp.wasabeef.recyclerview", Managed="JP.Wasabeef.Recyclerview")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "jp.wasabeef.recyclerview.adapters", Managed="JP.Wasabeef.Recyclerview.Adapters")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "jp.wasabeef.recyclerview.animators", Managed="JP.Wasabeef.Recyclerview.Animators")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "jp.wasabeef.recyclerview.animators.holder", Managed="JP.Wasabeef.Recyclerview.Animators.Holder")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "jp.wasabeef.recyclerview.internal", Managed="JP.Wasabeef.Recyclerview.Internal")]

delegate int _JniMarshal_PP_I (IntPtr jnienv, IntPtr klass);
delegate IntPtr _JniMarshal_PP_L (IntPtr jnienv, IntPtr klass);
delegate void _JniMarshal_PP_V (IntPtr jnienv, IntPtr klass);
delegate bool _JniMarshal_PP_Z (IntPtr jnienv, IntPtr klass);
delegate void _JniMarshal_PPI_V (IntPtr jnienv, IntPtr klass, int p0);
delegate long _JniMarshal_PPL_J (IntPtr jnienv, IntPtr klass, IntPtr p0);
delegate IntPtr _JniMarshal_PPL_L (IntPtr jnienv, IntPtr klass, IntPtr p0);
delegate void _JniMarshal_PPL_V (IntPtr jnienv, IntPtr klass, IntPtr p0);
delegate bool _JniMarshal_PPL_Z (IntPtr jnienv, IntPtr klass, IntPtr p0);
delegate IntPtr _JniMarshal_PPLI_L (IntPtr jnienv, IntPtr klass, IntPtr p0, int p1);
delegate void _JniMarshal_PPLI_V (IntPtr jnienv, IntPtr klass, IntPtr p0, int p1);
delegate bool _JniMarshal_PPLIIII_Z (IntPtr jnienv, IntPtr klass, IntPtr p0, int p1, int p2, int p3, int p4);
delegate void _JniMarshal_PPLL_V (IntPtr jnienv, IntPtr klass, IntPtr p0, IntPtr p1);
delegate bool _JniMarshal_PPLLIIII_Z (IntPtr jnienv, IntPtr klass, IntPtr p0, IntPtr p1, int p2, int p3, int p4, int p5);
delegate void _JniMarshal_PPZ_V (IntPtr jnienv, IntPtr klass, bool p0);
#if !NET
namespace System.Runtime.Versioning {
    [System.Diagnostics.Conditional("NEVER")]
    [AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Class | AttributeTargets.Constructor | AttributeTargets.Enum | AttributeTargets.Event | AttributeTargets.Field | AttributeTargets.Interface | AttributeTargets.Method | AttributeTargets.Module | AttributeTargets.Property | AttributeTargets.Struct, AllowMultiple = true, Inherited = false)]
    internal sealed class SupportedOSPlatformAttribute : Attribute {
        public SupportedOSPlatformAttribute (string platformName) { }
    }
}
#endif

