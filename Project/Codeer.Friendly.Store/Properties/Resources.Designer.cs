﻿//------------------------------------------------------------------------------
// <auto-generated>
//     このコードはツールによって生成されました。
//     ランタイム バージョン:4.0.30319.34014
//
//     このファイルへの変更は、以下の状況下で不正な動作の原因になったり、
//     コードが再生成されるときに損失したりします。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Codeer.Friendly.Store.Properties {
    using System;
    
    
    /// <summary>
    ///   ローカライズされた文字列などを検索するための、厳密に型指定されたリソース クラスです。
    /// </summary>
    // このクラスは StronglyTypedResourceBuilder クラスが ResGen
    // または Visual Studio のようなツールを使用して自動生成されました。
    // メンバーを追加または削除するには、.ResX ファイルを編集して、/str オプションと共に
    // ResGen を実行し直すか、または VS プロジェクトをビルドし直します。
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   このクラスで使用されているキャッシュされた ResourceManager インスタンスを返します。
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Codeer.Friendly.Store.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   厳密に型指定されたこのリソース クラスを使用して、すべての検索リソースに対し、
        ///   現在のスレッドの CurrentUICulture プロパティをオーバーライドします。
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Communication with the application failed.
        ///The target applcation may be unreachable or you may be trying to send
        ///data that cannot be serialized. に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string ErrorAppCommunication {
            get {
                return ResourceManager.GetString("ErrorAppCommunication", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Failed to connect to application. に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string ErrorAppConnection {
            get {
                return ResourceManager.GetString("ErrorAppConnection", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Failed to connect to the specified process.
        ///The specified CLR version number may be incorrect.
        ///Please bear in mind that the CLR version may be different from the .NET framework version.
        ///Please see the Codeer website to check supported version numbers. に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string ErrorCLR {
            get {
                return ResourceManager.GetString("ErrorCLR", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Failed to connect to the specified process.
        ///Installation may have failed. に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string ErrorDllLoad {
            get {
                return ResourceManager.GetString("ErrorDllLoad", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Communication with the application failed.
        ///The indicated window in the target thread does not exist or has already been disposed.
        ///In applications that display a splash window, the main window may have become a splash window immediately after starting.
        ///Please specify the handle of the expected window of explicitly. に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string ErrorExecuteThreadWindowHandle {
            get {
                return ResourceManager.GetString("ErrorExecuteThreadWindowHandle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Attempt to manipulate the specified process failed. One of the following could be the cause: (1) The specified CLR version is incorrect. (2) Permissions to manipulate the target process are insufficient. (3) The target process terminated during connection. (4) The window for the specified window handle was disposed. 
        ///In applications that display a splash window, the main window may have become a splash window immediately after starting.
        ///Please specify the handle of the expected window of explicitly. に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string ErrorProcessAcess {
            get {
                return ResourceManager.GetString("ErrorProcessAcess", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Platform targets differ between the test target and test process. Please ensure they are the same. に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string ErrorTargetCpuDifference {
            get {
                return ResourceManager.GetString("ErrorTargetCpuDifference", resourceCulture);
            }
        }
    }
}
