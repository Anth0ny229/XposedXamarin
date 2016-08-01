"# XposedXamarin" 

Click build solution and it will throw 2 errors about generated classes
DE.Robv.Android.Xposed.Callbacks.XC_LayoutInflated.cs
about
public partial class Unhook : global::Java.Lang.Object, global::DE.Robv.Android.Xposed.Callbacks.IXUnhook
Just change that to
public partial class Unhook : global::Java.Lang.Object, global::DE.Robv.Android.Xposed.Callbacks.IXUnhook<XC_LayoutInflated>

And class
DE.Robv.Android.Xposed.XC_MethodHook.cs
Change
public partial class Unhook : global::Java.Lang.Object, global::DE.Robv.Android.Xposed.Callbacks.IXUnhook
to
public partial class Unhook : global::Java.Lang.Object, global::DE.Robv.Android.Xposed.Callbacks.IXUnhook<XC_MethodHook>

And then click build again and it will build and should error about generated Tutorial Callable Wrapper

2>C:\Users\anth0\Documents\Visual Studio 2015\Projects\XposedTest\XposedTest\obj\Debug\android\src\xposedTest\XposedTest\Tutorial.java(8,25): javac.exe error :  error: package de.robv.android.xposed does not exist
2>C:\Users\anth0\Documents\Visual Studio 2015\Projects\XposedTest\XposedTest\obj\Debug\android\src\xposedTest\XposedTest\Tutorial.java(8,25): javac.exe error : 		de.robv.android.xposed.IXposedHookLoadPackage
2>C:\Users\anth0\Documents\Visual Studio 2015\Projects\XposedTest\XposedTest\obj\Debug\android\src\xposedTest\XposedTest\Tutorial.java(8,25): javac.exe error : 
2>C:\Users\anth0\Documents\Visual Studio 2015\Projects\XposedTest\XposedTest\obj\Debug\android\src\xposedTest\XposedTest\Tutorial.java(28,80): javac.exe error :  error: package de.robv.android.xposed.callbacks.XC_LoadPackage does not exist
2>C:\Users\anth0\Documents\Visual Studio 2015\Projects\XposedTest\XposedTest\obj\Debug\android\src\xposedTest\XposedTest\Tutorial.java(28,80): javac.exe error : 	public void handleLoadPackage (de.robv.android.xposed.callbacks.XC_LoadPackage.LoadPackageParam p0)
2>C:\Users\anth0\Documents\Visual Studio 2015\Projects\XposedTest\XposedTest\obj\Debug\android\src\xposedTest\XposedTest\Tutorial.java(28,80): javac.exe error : 
2>C:\Users\anth0\Documents\Visual Studio 2015\Projects\XposedTest\XposedTest\obj\Debug\android\src\xposedTest\XposedTest\Tutorial.java(33,90): error :  error: package de.robv.android.xposed.callbacks.XC_LoadPackage does not exist
2>C:\Users\anth0\Documents\Visual Studio 2015\Projects\XposedTest\XposedTest\obj\Debug\android\src\xposedTest\XposedTest\Tutorial.java(33,90): error : 	private native void n_handleLoadPackage (de.robv.android.xposed.callbacks.XC_LoadPackage.LoadPackageParam p0);
2>C:\Users\anth0\Documents\Visual Studio 2015\Projects\XposedTest\XposedTest\obj\Debug\android\src\xposedTest\XposedTest\Tutorial.java(33,90): error : 

The binding seems to partially work as
XposedBridge.Log("OnCreate");
works fine

XposedBridge.jar shouldn't really be included, it should be in path system\framework\XposedBridge.jar but if it takes being included to work then that's okay for now
api-82.jar is just stubs and api-82-sources.jar is the actually source classes but they should be just to generate the bindings.