﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.42000
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SwissAcademic.Addons.ImportSequenceNumber.Properties {
    using System;
    
    
    /// <summary>
    ///   Eine stark typisierte Ressourcenklasse zum Suchen von lokalisierten Zeichenfolgen usw.
    /// </summary>
    // Diese Klasse wurde von der StronglyTypedResourceBuilder automatisch generiert
    // -Klasse über ein Tool wie ResGen oder Visual Studio automatisch generiert.
    // Um einen Member hinzuzufügen oder zu entfernen, bearbeiten Sie die .ResX-Datei und führen dann ResGen
    // mit der /str-Option erneut aus, oder Sie erstellen Ihr VS-Projekt neu.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class ImportSequenceNumberResources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal ImportSequenceNumberResources() {
        }
        
        /// <summary>
        ///   Gibt die zwischengespeicherte ResourceManager-Instanz zurück, die von dieser Klasse verwendet wird.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("SwissAcademic.Addons.ImportSequenceNumber.Properties.ImportSequenceNumberResource" +
                            "s", typeof(ImportSequenceNumberResources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Überschreibt die CurrentUICulture-Eigenschaft des aktuellen Threads für alle
        ///   Ressourcenzuordnungen, die diese stark typisierte Ressourcenklasse verwenden.
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
        ///   Sucht eine lokalisierte Ressource vom Typ System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap addon {
            get {
                object obj = ResourceManager.GetObject("addon", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Sucht eine lokalisierte Zeichenfolge, die Which field do you want to import the sequence numbers into? ähnelt.
        /// </summary>
        internal static string ChooseFieldMessage {
            get {
                return ResourceManager.GetString("ChooseFieldMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Sucht eine lokalisierte Zeichenfolge, die {0} sequence numbers were imported successfully. ähnelt.
        /// </summary>
        internal static string CompleteMultipleResultsMessage {
            get {
                return ResourceManager.GetString("CompleteMultipleResultsMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Sucht eine lokalisierte Zeichenfolge, die One sequence number was imported successfully. ähnelt.
        /// </summary>
        internal static string CompleteSingleResultMessage {
            get {
                return ResourceManager.GetString("CompleteSingleResultMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Sucht eine lokalisierte Zeichenfolge, die No sequence numbers were imported. ähnelt.
        /// </summary>
        internal static string CompleteZeroResultMessage {
            get {
                return ResourceManager.GetString("CompleteZeroResultMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Sucht eine lokalisierte Zeichenfolge, die The selected project is not compatible with this project. Select the Citavi project that was converted to this Citavi 6 project. ähnelt.
        /// </summary>
        internal static string FoundReferenceCountNull {
            get {
                return ResourceManager.GetString("FoundReferenceCountNull", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Sucht eine lokalisierte Zeichenfolge, die Information ähnelt.
        /// </summary>
        internal static string Information {
            get {
                return ResourceManager.GetString("Information", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Sucht eine lokalisierte Zeichenfolge, die Import sequence numbers… ähnelt.
        /// </summary>
        internal static string MenuCaption {
            get {
                return ResourceManager.GetString("MenuCaption", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Sucht eine lokalisierte Zeichenfolge, die It&apos;s only possible to import sequence numbers from local projects. ähnelt.
        /// </summary>
        internal static string OnlyDesktopProjectsSupport {
            get {
                return ResourceManager.GetString("OnlyDesktopProjectsSupport", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Sucht eine lokalisierte Zeichenfolge, die Citavi projects|*.ctv5;*.ctv4;*.ctt4;*.ctv3;*.ctt3 ähnelt.
        /// </summary>
        internal static string OpenFileDialogFilters {
            get {
                return ResourceManager.GetString("OpenFileDialogFilters", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Sucht eine lokalisierte Zeichenfolge, die Select Citavi Project ähnelt.
        /// </summary>
        internal static string OpenFileDialogTitle {
            get {
                return ResourceManager.GetString("OpenFileDialogTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Sucht eine lokalisierte Zeichenfolge, die This is not a valid Citavi project. ähnelt.
        /// </summary>
        internal static string OpenProjectConfigurationException {
            get {
                return ResourceManager.GetString("OpenProjectConfigurationException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Sucht eine lokalisierte Zeichenfolge, die Password-protected Citavi projects are not supported. ähnelt.
        /// </summary>
        internal static string OpenProtectedProjectMessage {
            get {
                return ResourceManager.GetString("OpenProtectedProjectMessage", resourceCulture);
            }
        }
    }
}