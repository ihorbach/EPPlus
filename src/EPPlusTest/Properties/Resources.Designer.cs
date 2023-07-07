/*******************************************************************************
 * You may amend and distribute as you like, but don't remove this header!
 *
 * Required Notice: Copyright (C) EPPlus Software AB. 
 * https://epplussoftware.com
 *
 * This library is free software; you can redistribute it and/or
 * modify it under the terms of the GNU Lesser General Public
 * License as published by the Free Software Foundation; either
 * version 2.1 of the License, or (at your option) any later version.

 * This library is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  
 * See the GNU Lesser General Public License for more details.
 *
 * The GNU Lesser General Public License can be viewed at http://www.opensource.org/licenses/lgpl-license.php
 * If you unfamiliar with this license or have questions about it, here is an http://www.gnu.org/licenses/gpl-faq.html
 *
 * All code and executables are provided "" as is "" with no warranty either express or implied. 
 * The author accepts no liability for any damage or loss of business that this product may cause.
 *
 * Code change notes:
 * 
  Date               Author                       Change
 *******************************************************************************
  01/27/2020         EPPlus Software AB       Initial release EPPlus 5
 *******************************************************************************/
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EPPlusTest.Properties {
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System;
    using System.Drawing;
    using System.IO;
    using System.Reflection;


    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
 //   [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("EPPlusTest.Properties.Resources", 
#if Core 
                        typeof(Resources).GetTypeInfo().Assembly);
#else
                        typeof(Resources).Assembly);
#endif

                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
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
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static FileInfo Test1
        {
            get
            {
                string path = AppContext.BaseDirectory;
                while (!Directory.Exists(path + "\\Resources") && path.Length>4)
                {
                    path = new DirectoryInfo(path + "\\..").FullName;
                }
                return new FileInfo(path + "\\Resources\\Test1.jpg");
            }
        }
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static byte[] BitmapImageGif
        {
            get
            {
                string path = AppContext.BaseDirectory;
                while (!Directory.Exists(path + "\\Resources") && path.Length > 4)
                {
                    path = new DirectoryInfo(path + "\\..").FullName;
                }
                return File.ReadAllBytes(path + "\\Resources\\BitmapImage.gif");
            }
        }

        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static byte[] CodeBmp
        {
            get
            {
                string path = AppContext.BaseDirectory;
                while (!Directory.Exists(path + "\\Resources") && path.Length > 4)
                {
                    path = new DirectoryInfo(path + "\\..").FullName;
                }
                return File.ReadAllBytes(path + "\\Resources\\code.bmp");
            }
        }
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static byte[] Test1JpgByteArray
        {
            get
            {
                string path = AppContext.BaseDirectory;
                while (!Directory.Exists(path + "\\Resources") && path.Length > 4)
                {
                    path = new DirectoryInfo(path + "\\..").FullName;
                }
                return File.ReadAllBytes(path + "\\Resources\\Test1.jpg");
            }
        }

        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static byte[] VmlPatternImage
        {
            get
            {
                string path = AppContext.BaseDirectory;
                while (!Directory.Exists(path + "\\Resources") && path.Length > 4)
                {
                    path = new DirectoryInfo(path + "\\..").FullName;
                }
                return File.ReadAllBytes(path + "\\Resources\\VmlPatternImage.png");
            }
        }
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static byte[] VmlPatternImagePngByteArray
        {
            get
            {
                string path = AppContext.BaseDirectory;
                while (!Directory.Exists(path + "\\Resources") && path.Length > 4)
                {
                    path = new DirectoryInfo(path + "\\..").FullName;
                }
                return File.ReadAllBytes(path + "\\Resources\\VmlPatternImage.png");
            }
        }
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static byte[] Png2ByteArray
        {
            get
            {
                string path = AppContext.BaseDirectory;
                while (!Directory.Exists(path + "\\Resources") && path.Length > 4)
                {
                    path = new DirectoryInfo(path + "\\..").FullName;
                }
                return File.ReadAllBytes(path + "\\Resources\\EPPlus.png");
            }
        }
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static byte[] Png3ByteArray
        {
            get
            {
                string path = AppContext.BaseDirectory;
                while (!Directory.Exists(path + "\\Resources") && path.Length > 4)
                {
                    path = new DirectoryInfo(path + "\\..").FullName;
                }
                return File.ReadAllBytes(path + "\\Resources\\screenshot.PNG");
            }
        }
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static byte[] CodeEmfByteArray
        {
            get
            {
                string path = AppContext.BaseDirectory;
                while (!Directory.Exists(path + "\\Resources") && path.Length > 4)
                {
                    path = new DirectoryInfo(path + "\\..").FullName;
                }
                return File.ReadAllBytes(path + "\\Resources\\Code.emf");
            }
        }
        internal static byte[] Svg1ByteArray
        {
            get
            {
                string path = AppContext.BaseDirectory;
                while (!Directory.Exists(path + "\\Resources") && path.Length > 4)
                {
                    path = new DirectoryInfo(path + "\\..").FullName;
                }
                return File.ReadAllBytes(path + "\\Resources\\car-silhouette-color-low-poly.svg");
            }
        }
        internal static byte[] TestDoc_SharedFormula_xlsx
        {
            get
            {
                string path = AppContext.BaseDirectory;
                while (!Directory.Exists(path + "\\Resources") && path.Length > 4)
                {
                    path = new DirectoryInfo(path + "\\..").FullName;
                }
                return File.ReadAllBytes(path + "\\Resources\\TestDoc_SharedFormula.xlsx");
            }
        }
        internal static byte[] Svg2ByteArray
        {
            get
            {
                string path = AppContext.BaseDirectory;
                while (!Directory.Exists(path + "\\Resources") && path.Length > 4)
                {
                    path = new DirectoryInfo(path + "\\..").FullName;
                }
                return File.ReadAllBytes(path + "\\Resources\\tree-solid.svg");
            }
        }



        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static MemoryStream VectorDrawing
        {
            get
            {
                string path = AppContext.BaseDirectory;
                while (!Directory.Exists(path + "\\Resources") && path.Length > 4)
                {
                    path = new DirectoryInfo(path + "\\..").FullName;
                }
                return new MemoryStream(File.ReadAllBytes(path + "\\Resources\\Vector Drawing.wmf"));
            }
        }

        internal static System.Drawing.Bitmap Pattern1Jpeg
        {
            get
            {
                string path = AppContext.BaseDirectory;
                while (!Directory.Exists(path + "\\Resources"))
                {
                    path = new DirectoryInfo(path + "\\..").FullName;
                }
                return (Bitmap)Image.FromFile(path + "\\Resources\\Pattern1.jpeg");
            }
        }
        internal static MemoryStream CodeTif
        {
            get
            {
                string path = AppContext.BaseDirectory;
                while (!Directory.Exists(path + "\\Resources"))
                {
                    path = new DirectoryInfo(path + "\\..").FullName;
                }
                return new MemoryStream(File.ReadAllBytes(path + "\\Resources\\code2.tif"));
            }
        }
        internal static MemoryStream CodeWebP
        {
            get
            {
                string path = AppContext.BaseDirectory;
                while (!Directory.Exists(path + "\\Resources"))
                {
                    path = new DirectoryInfo(path + "\\..").FullName;
                }
                return new MemoryStream(File.ReadAllBytes(path + "\\Resources\\code.webp"));
            }
        }
        internal static MemoryStream TestThemeThmx
        {
            get
            {
                string path = AppContext.BaseDirectory;
                while (!Directory.Exists(path + "\\Resources"))
                {
                    path = new DirectoryInfo(path + "\\..").FullName;
                }
                return new MemoryStream(File.ReadAllBytes(path + "\\Resources\\TestTheme.thmx"));
            }
        }
        internal static MemoryStream SavonThmx
        {
            get
            {
                string path = AppContext.BaseDirectory;
                while (!Directory.Exists(path + "\\Resources"))
                {
                    path = new DirectoryInfo(path + "\\..").FullName;
                }
                return new MemoryStream(File.ReadAllBytes(path + "\\Resources\\Savon.thmx"));
            }
        }
        internal static MemoryStream WoodTypeThmx
        {
            get
            {
                string path = AppContext.BaseDirectory;
                while (!Directory.Exists(path + "\\Resources"))
                {
                    path = new DirectoryInfo(path + "\\..").FullName;
                }
                return new MemoryStream(File.ReadAllBytes(path + "\\Resources\\WoodType.thmx"));
            }
        }
        internal static MemoryStream TestLine3Crtx
        {
            get
            {
                string path = AppContext.BaseDirectory;
                while (!Directory.Exists(path + "\\Resources"))
                {
                    path = new DirectoryInfo(path + "\\..").FullName;
                }
                return new MemoryStream(File.ReadAllBytes(path + "\\Resources\\LineChart3.crtx"));
            }
        }
    }
}
