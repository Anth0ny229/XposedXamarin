using System.Threading.Tasks;
using Android.Runtime;
using DE.Robv.Android.Xposed;
using DE.Robv.Android.Xposed.Callbacks;

namespace DE.Robv.Android.Xposed.Callbacks
{
    // Metadata.xml XPath interface reference: path="/api/package[@name='de.robv.android.xposed.callbacks']/interface[@name='IXUnhook']"
    [Register("de/robv/android/xposed/callbacks/IXUnhook", "", "DE.Robv.Android.Xposed.Callbacks.IXUnhookInvoker")]
    [global::Java.Interop.JavaTypeParameters(new string[] { "T" })]
    public partial interface IXUnhook<out T>
    {
        // Metadata.xml XPath method reference: path="/api/package[@name='de.robv.android.xposed.callbacks']/interface[@name='IXUnhook']/method[@name='getCallback' and count(parameter)=0]"
        [Register("getCallback", "()Ljava/lang/Object;", "GetGetCallbackHandler:DE.Robv.Android.Xposed.Callbacks.IXUnhookInvoker, XposedBridge")]
        T Callback { get; }

        // Metadata.xml XPath method reference: path="/api/package[@name='de.robv.android.xposed.callbacks']/interface[@name='IXUnhook']/method[@name='unhook' and count(parameter)=0]"
        [Register("unhook", "()V", "GetUnhookHandler:DE.Robv.Android.Xposed.Callbacks.IXUnhookInvoker, XposedBridge")]
        void InvokeUnhook();
    }
}
/*
namespace DE.Robv.Android.Xposed
{
    public partial class XC_MethodHook
    {
        public partial class Unhook : global::Java.Lang.Object, IXUnhook<XC_MethodHook>
        {

        }
    }
}*/
