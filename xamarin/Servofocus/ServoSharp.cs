// ----------------------------------------------------------------------------
// <auto-generated>
// This is autogenerated code by CppSharp.
// Do not edit this file or all your changes will be lost after re-generation.
// </auto-generated>
// ----------------------------------------------------------------------------
using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Security;

namespace Servofocus
{
    /// <summary>Generic result errors</summary>
    public enum ServoResult
    {
        Ok = 0,
        UnexpectedError = 1,
        WrongThread = 2,
        CantReadStr = 3,
        CantParseUrl = 4,
        NotImplemented = 5
    }

    /// <summary>Scroll state</summary>
    public enum ScrollState
    {
        Start = 0,
        Move = 1,
        End = 2,
        Canceled = 3
    }

    /// <summary>Touch state</summary>
    public enum TouchState
    {
        TouchStateDown = 0,
        TouchStateUp = 1
    }

    /// <summary>Callback used by Servo internals</summary>
    public unsafe partial struct HostCallbacks
    {
        [StructLayout(LayoutKind.Explicit, Size = 64)]
        public partial struct __Internal
        {
            [FieldOffset(0)]
            internal global::System.IntPtr wakeup;

            [FieldOffset(8)]
            internal global::System.IntPtr flush;

            [FieldOffset(16)]
            internal global::System.IntPtr log;

            [FieldOffset(24)]
            internal global::System.IntPtr on_load_started;

            [FieldOffset(32)]
            internal global::System.IntPtr on_load_ended;

            [FieldOffset(40)]
            internal global::System.IntPtr on_title_changed;

            [FieldOffset(48)]
            internal global::System.IntPtr on_url_changed;

            [FieldOffset(56)]
            internal global::System.IntPtr on_history_changed;

            [SuppressUnmanagedCodeSecurity]
            [DllImport("libservobridge", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="??0HostCallbacks@@QEAA@AEBU0@@Z")]
            internal static extern global::System.IntPtr cctor(global::System.IntPtr _0);
        }

        private HostCallbacks.__Internal __instance;
        internal HostCallbacks.__Internal __Instance { get { return __instance; } }

        internal static global::Servofocus.HostCallbacks __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new global::Servofocus.HostCallbacks(native.ToPointer(), skipVTables);
        }

        internal static global::Servofocus.HostCallbacks __CreateInstance(global::Servofocus.HostCallbacks.__Internal native, bool skipVTables = false)
        {
            return new global::Servofocus.HostCallbacks(native, skipVTables);
        }

        private HostCallbacks(global::Servofocus.HostCallbacks.__Internal native, bool skipVTables = false)
            : this()
        {
            __instance = native;
        }

        private HostCallbacks(void* native, bool skipVTables = false) : this()
        {
            __instance = *(global::Servofocus.HostCallbacks.__Internal*) native;
        }

        public HostCallbacks(global::Servofocus.HostCallbacks _0)
            : this()
        {
            var ____arg0 = _0.__Instance;
            var __arg0 = new global::System.IntPtr(&____arg0);
            fixed (__Internal* __instancePtr = &__instance)
            {
                __Internal.cctor(__arg0);
            }
        }
    }

    public unsafe partial struct Size
    {
        [StructLayout(LayoutKind.Explicit, Size = 8)]
        public partial struct __Internal
        {
            [FieldOffset(0)]
            internal uint width;

            [FieldOffset(4)]
            internal uint height;

            [SuppressUnmanagedCodeSecurity]
            [DllImport("libservobridge", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="??0Size@@QEAA@AEBU0@@Z")]
            internal static extern global::System.IntPtr cctor(global::System.IntPtr _0);
        }

        private Size.__Internal __instance;
        internal Size.__Internal __Instance { get { return __instance; } }

        internal static global::Servofocus.Size __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new global::Servofocus.Size(native.ToPointer(), skipVTables);
        }

        internal static global::Servofocus.Size __CreateInstance(global::Servofocus.Size.__Internal native, bool skipVTables = false)
        {
            return new global::Servofocus.Size(native, skipVTables);
        }

        private Size(global::Servofocus.Size.__Internal native, bool skipVTables = false)
            : this()
        {
            __instance = native;
        }

        private Size(void* native, bool skipVTables = false) : this()
        {
            __instance = *(global::Servofocus.Size.__Internal*) native;
        }

        public Size(global::Servofocus.Size _0)
            : this()
        {
            var ____arg0 = _0.__Instance;
            var __arg0 = new global::System.IntPtr(&____arg0);
            fixed (__Internal* __instancePtr = &__instance)
            {
                __Internal.cctor( __arg0);
            }
        }

        public uint Width
        {
            get
            {
                return __instance.width;
            }

            set
            {
                __instance.width = value;
            }
        }

        public uint Height
        {
            get
            {
                return __instance.height;
            }

            set
            {
                __instance.height = value;
            }
        }
    }

    public unsafe partial struct Margins
    {
        [StructLayout(LayoutKind.Explicit, Size = 16)]
        public partial struct __Internal
        {
            [FieldOffset(0)]
            internal uint top;

            [FieldOffset(4)]
            internal uint right;

            [FieldOffset(8)]
            internal uint bottom;

            [FieldOffset(12)]
            internal uint left;

            [SuppressUnmanagedCodeSecurity]
            [DllImport("libservobridge", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="??0Margins@@QEAA@AEBU0@@Z")]
            internal static extern global::System.IntPtr cctor(global::System.IntPtr _0);
        }

        private Margins.__Internal __instance;
        internal Margins.__Internal __Instance { get { return __instance; } }

        internal static global::Servofocus.Margins __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new global::Servofocus.Margins(native.ToPointer(), skipVTables);
        }

        internal static global::Servofocus.Margins __CreateInstance(global::Servofocus.Margins.__Internal native, bool skipVTables = false)
        {
            return new global::Servofocus.Margins(native, skipVTables);
        }

        private Margins(global::Servofocus.Margins.__Internal native, bool skipVTables = false)
            : this()
        {
            __instance = native;
        }

        private Margins(void* native, bool skipVTables = false) : this()
        {
            __instance = *(global::Servofocus.Margins.__Internal*) native;
        }

        public Margins(global::Servofocus.Margins _0)
            : this()
        {
            var ____arg0 = _0.__Instance;
            var __arg0 = new global::System.IntPtr(&____arg0);
            fixed (__Internal* __instancePtr = &__instance)
            {
                __Internal.cctor( __arg0);
            }
        }

        public uint Top
        {
            get
            {
                return __instance.top;
            }

            set
            {
                __instance.top = value;
            }
        }

        public uint Right
        {
            get
            {
                return __instance.right;
            }

            set
            {
                __instance.right = value;
            }
        }

        public uint Bottom
        {
            get
            {
                return __instance.bottom;
            }

            set
            {
                __instance.bottom = value;
            }
        }

        public uint Left
        {
            get
            {
                return __instance.left;
            }

            set
            {
                __instance.left = value;
            }
        }
    }

    public unsafe partial struct Position
    {
        [StructLayout(LayoutKind.Explicit, Size = 8)]
        public partial struct __Internal
        {
            [FieldOffset(0)]
            internal int x;

            [FieldOffset(4)]
            internal int y;

            [SuppressUnmanagedCodeSecurity]
            [DllImport("libservobridge", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="??0Position@@QEAA@AEBU0@@Z")]
            internal static extern global::System.IntPtr cctor(global::System.IntPtr _0);
        }

        private Position.__Internal __instance;
        internal Position.__Internal __Instance { get { return __instance; } }

        internal static global::Servofocus.Position __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new global::Servofocus.Position(native.ToPointer(), skipVTables);
        }

        internal static global::Servofocus.Position __CreateInstance(global::Servofocus.Position.__Internal native, bool skipVTables = false)
        {
            return new global::Servofocus.Position(native, skipVTables);
        }

        private Position(global::Servofocus.Position.__Internal native, bool skipVTables = false)
            : this()
        {
            __instance = native;
        }

        private Position(void* native, bool skipVTables = false) : this()
        {
            __instance = *(global::Servofocus.Position.__Internal*) native;
        }

        public Position(global::Servofocus.Position _0)
            : this()
        {
            var ____arg0 = _0.__Instance;
            var __arg0 = new global::System.IntPtr(&____arg0);
            fixed (__Internal* __instancePtr = &__instance)
            {
                __Internal.cctor( __arg0);
            }
        }

        public int X
        {
            get
            {
                return __instance.x;
            }

            set
            {
                __instance.x = value;
            }
        }

        public int Y
        {
            get
            {
                return __instance.y;
            }

            set
            {
                __instance.y = value;
            }
        }
    }

    public unsafe partial struct ViewLayout
    {
        [StructLayout(LayoutKind.Explicit, Size = 36)]
        public partial struct __Internal
        {
            [FieldOffset(0)]
            internal global::Servofocus.Size view_size;

            [FieldOffset(8)]
            internal global::Servofocus.Margins margins;

            [FieldOffset(24)]
            internal global::Servofocus.Position.__Internal position;

            [FieldOffset(32)]
            internal float hidpi_factor;

            [SuppressUnmanagedCodeSecurity]
            [DllImport("libservobridge", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="??0ViewLayout@@QEAA@AEBU0@@Z")]
            internal static extern global::System.IntPtr cctor(global::System.IntPtr _0);
        }

        private ViewLayout.__Internal __instance;
        internal ViewLayout.__Internal __Instance { get { return __instance; } }

        internal static global::Servofocus.ViewLayout __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new global::Servofocus.ViewLayout(native.ToPointer(), skipVTables);
        }

        internal static global::Servofocus.ViewLayout __CreateInstance(global::Servofocus.ViewLayout.__Internal native, bool skipVTables = false)
        {
            return new global::Servofocus.ViewLayout(native, skipVTables);
        }

        private ViewLayout(global::Servofocus.ViewLayout.__Internal native, bool skipVTables = false)
            : this()
        {
            __instance = native;
        }

        private ViewLayout(void* native, bool skipVTables = false) : this()
        {
            __instance = *(global::Servofocus.ViewLayout.__Internal*) native;
        }

        public ViewLayout(global::Servofocus.ViewLayout _0)
            : this()
        {
            var ____arg0 = _0.__Instance;
            var __arg0 = new global::System.IntPtr(&____arg0);
            fixed (__Internal* __instancePtr = &__instance)
            {
                __Internal.cctor( __arg0);
            }
        }

        /// <summary>Size of the view. Hardware pixels.</summary>
        public global::Servofocus.Size ViewSize
        {
            get { return __instance.view_size; }
            set { __instance.view_size = value; }
        }

        /// <summary>
        /// <para>Margins of the view. Hardware pixels.</para>
        /// <para>Pages are painted all over the surface,</para>
        /// <para>but if margins are not zero, the layout</para>
        /// <para>coordinates are bounds by these margins.</para>
        /// </summary>
        public global::Servofocus.Margins __margins;

        /// <summary>Position of the window.</summary>
        public global::Servofocus.Position __position;

        public float HidpiFactor
        {
            get
            {
                return __instance.hidpi_factor;
            }

            set
            {
                __instance.hidpi_factor = value;
            }
        }
    }

    public unsafe partial class ServoSharp : IDisposable
    {
        [StructLayout(LayoutKind.Explicit, Size = 0)]
        public partial struct __Internal
        {
            [SuppressUnmanagedCodeSecurity]
            [DllImport("libservobridge", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="init_with_egl")]
            internal static extern global::Servofocus.ServoResult InitWithEgl(byte* url, byte* resources_path, global::Servofocus.HostCallbacks.__Internal callbacks, global::Servofocus.ViewLayout.__Internal layout);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("libservobridge", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="perform_updates")]
            internal static extern global::Servofocus.ServoResult PerformUpdates();

            [SuppressUnmanagedCodeSecurity]
            [DllImport("libservobridge", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="load_url")]
            internal static extern global::Servofocus.ServoResult LoadUrl(byte* url);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("libservobridge", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="scroll")]
            internal static extern global::Servofocus.ServoResult Scroll(int dx, int dy, uint x, uint y, global::Servofocus.ScrollState state);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("libservobridge", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="servo_version")]
            internal static extern byte* ServoVersion();

            [SuppressUnmanagedCodeSecurity]
            [DllImport("libservobridge", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                       EntryPoint="resize")]
            internal static extern global::Servofocus.ServoResult Resize(global::Servofocus.ViewLayout.__Internal layout);

        }

        public global::System.IntPtr __Instance { get; protected set; }

        protected int __PointerAdjustment;
        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::Servofocus.ServoSharp> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::Servofocus.ServoSharp>();
        protected void*[] __OriginalVTables;

        protected bool __ownsNativeInstance;

        internal static global::Servofocus.ServoSharp __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new global::Servofocus.ServoSharp(native.ToPointer(), skipVTables);
        }

        internal static global::Servofocus.ServoSharp __CreateInstance(global::Servofocus.ServoSharp.__Internal native, bool skipVTables = false)
        {
            return new global::Servofocus.ServoSharp(native, skipVTables);
        }

        private static void* __CopyValue(global::Servofocus.ServoSharp.__Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(global::Servofocus.ServoSharp.__Internal));
            *(global::Servofocus.ServoSharp.__Internal*) ret = native;
            return ret.ToPointer();
        }

        private ServoSharp(global::Servofocus.ServoSharp.__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected ServoSharp(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new global::System.IntPtr(native);
        }

        public ServoSharp()
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::Servofocus.ServoSharp.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        public void Dispose()
        {
            Dispose(disposing: true);
        }

        public virtual void Dispose(bool disposing)
        {
            if (__Instance == IntPtr.Zero)
                return;
            global::Servofocus.ServoSharp __dummy;
            NativeToManagedMap.TryRemove(__Instance, out __dummy);
            if (__ownsNativeInstance)
                Marshal.FreeHGlobal(__Instance);
            __Instance = IntPtr.Zero;
        }

        /// <summary>Needs to be called from the EGL thread</summary>
        public global::Servofocus.ServoResult InitWithEgl(byte* url, byte* resources_path, global::Servofocus.HostCallbacks callbacks, global::Servofocus.ViewLayout layout)
        {
            var __arg2 = callbacks.__Instance;
            var __arg3 = layout.__Instance;
            var __ret = __Internal.InitWithEgl(url, resources_path, __arg2, __arg3);
            return __ret;
        }

        /// <summary>
        /// <para>This is the Servo heartbeat. This needs to be called</para>
        /// <para>everytime wakeup is called.</para>
        /// </summary>
        public global::Servofocus.ServoResult PerformUpdates()
        {
            var __ret = __Internal.PerformUpdates();
            return __ret;
        }

        /// <summary>Load an URL. This needs to be a valid url.</summary>
        public global::Servofocus.ServoResult LoadUrl(byte* url)
        {
            var __ret = __Internal.LoadUrl(url);
            return __ret;
        }

        public global::Servofocus.ServoResult Scroll(int dx, int dy, uint x, uint y, global::Servofocus.ScrollState state)
        {
            var __ret = __Internal.Scroll(dx, dy, x, y, state);
            return __ret;
        }

        public byte* ServoVersion()
        {
            var __ret = __Internal.ServoVersion();
            return __ret;
        }

        public global::Servofocus.ServoResult Resize(global::Servofocus.ViewLayout layout)
        {
            var __arg = layout.__Instance;
            var __ret = __Internal.Resize(__arg);
            return __ret;
        }
    }

    public unsafe partial class libservobridge
    {
        public partial struct __Internal
        {
            [SuppressUnmanagedCodeSecurity]
            [DllImport("libservobridge", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="touch")]
            internal static extern global::Servofocus.ServoResult Touch(uint _x, uint _y, global::Servofocus.TouchState _state);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("libservobridge", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="reload")]
            internal static extern global::Servofocus.ServoResult Reload();

            [SuppressUnmanagedCodeSecurity]
            [DllImport("libservobridge", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="stop")]
            internal static extern global::Servofocus.ServoResult Stop();

            [SuppressUnmanagedCodeSecurity]
            [DllImport("libservobridge", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="go_back")]
            internal static extern global::Servofocus.ServoResult GoBack();

            [SuppressUnmanagedCodeSecurity]
            [DllImport("libservobridge", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="go_forward")]
            internal static extern global::Servofocus.ServoResult GoForward();
        }

        public static global::Servofocus.ServoResult Touch(uint _x, uint _y, global::Servofocus.TouchState _state)
        {
            var __ret = __Internal.Touch(_x, _y, _state);
            return __ret;
        }

        /// <summary>Reload page.</summary>
        public static global::Servofocus.ServoResult Reload()
        {
            var __ret = __Internal.Reload();
            return __ret;
        }

        /// <summary>Stop page loading.</summary>
        public static global::Servofocus.ServoResult Stop()
        {
            var __ret = __Internal.Stop();
            return __ret;
        }

        public static global::Servofocus.ServoResult GoBack()
        {
            var __ret = __Internal.GoBack();
            return __ret;
        }

        public static global::Servofocus.ServoResult GoForward()
        {
            var __ret = __Internal.GoForward();
            return __ret;
        }
    }
}
