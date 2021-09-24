﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 16.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace Codegen
{
    using System.Linq;
    using System.Text;
    using System.Collections.Generic;
    using System;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "F:\react-native-xaml\package\Codegen\TSProps.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
    public partial class TSProps : TSPropsBase
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public virtual string TransformText()
        {
            this.Write(@"import type { ViewProps, NativeSyntheticEvent, ColorValue } from 'react-native';
import type * as Enums from './Enums';

export type Thickness = number | { left?: number, top?: number, right?: number, bottom?: number };

export type GridLength = number | '*' | 'auto' | `${number}*`;

export type CornerRadius = number | { topLeft?: number, topRight?: number, bottomLeft?: number, bottomRight?: number};

");
            
            #line 15 "F:\react-native-xaml\package\Codegen\TSProps.tt"
 var derived = Util.GetDerivedTypes(Types);
foreach (var type in Types) { 
            
            #line default
            #line hidden
            
            #line 17 "F:\react-native-xaml\package\Codegen\TSProps.tt"
 var ns = Util.GetTSNamespace(type);
if (ns != "") { 
            
            #line default
            #line hidden
            this.Write("export namespace Native");
            
            #line 19 "F:\react-native-xaml\package\Codegen\TSProps.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ns));
            
            #line default
            #line hidden
            this.Write(" {\r\n");
            
            #line 20 "F:\react-native-xaml\package\Codegen\TSProps.tt"
 } 
            
            #line default
            #line hidden
            this.Write("export interface Native");
            
            #line 21 "F:\react-native-xaml\package\Codegen\TSProps.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Util.ToJsName(type)));
            
            #line default
            #line hidden
            this.Write("Props extends ");
            
            #line 21 "F:\react-native-xaml\package\Codegen\TSProps.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Util.GetBaseClassProps(type)));
            
            #line default
            #line hidden
            this.Write(" {\r\n");
            
            #line 22 "F:\react-native-xaml\package\Codegen\TSProps.tt"
 var typeProp = Util.GetJsTypeProperty(type, derived);
if (typeProp != "") { 
            
            #line default
            #line hidden
            this.Write("  type: ");
            
            #line 24 "F:\react-native-xaml\package\Codegen\TSProps.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(typeProp));
            
            #line default
            #line hidden
            this.Write(";\r\n");
            
            #line 25 "F:\react-native-xaml\package\Codegen\TSProps.tt"
 }
foreach (var prop in type.GetProperties().Where(p => Util.ShouldEmitPropertyMetadata(p))) { 
            
            #line default
            #line hidden
            this.Write("  ");
            
            #line 27 "F:\react-native-xaml\package\Codegen\TSProps.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Util.ToJsName(prop)));
            
            #line default
            #line hidden
            this.Write("?: ");
            
            #line 27 "F:\react-native-xaml\package\Codegen\TSProps.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Util.GetTypeScriptType(prop)));
            
            #line default
            #line hidden
            this.Write(";\r\n");
            
            #line 28 "F:\react-native-xaml\package\Codegen\TSProps.tt"
 } 
foreach (var prop in FakeProps.Where(p => type == p.DeclaringType)) { 
            
            #line default
            #line hidden
            this.Write("  ");
            
            #line 30 "F:\react-native-xaml\package\Codegen\TSProps.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Util.ToJsName(prop)));
            
            #line default
            #line hidden
            this.Write("?: ");
            
            #line 30 "F:\react-native-xaml\package\Codegen\TSProps.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Util.GetTypeScriptType(prop)));
            
            #line default
            #line hidden
            this.Write("; // synthetic property\r\n");
            
            #line 31 "F:\react-native-xaml\package\Codegen\TSProps.tt"
 } 
foreach (var prop in SyntheticProps.Where(p => type == p.DeclaringType)) { 
            
            #line default
            #line hidden
            this.Write("  /**\r\n  * ");
            
            #line 34 "F:\react-native-xaml\package\Codegen\TSProps.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(prop.Comment));
            
            #line default
            #line hidden
            this.Write("\r\n  */\r\n  ");
            
            #line 36 "F:\react-native-xaml\package\Codegen\TSProps.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Util.ToJsName(prop.Name)));
            
            #line default
            #line hidden
            this.Write("?: ");
            
            #line 36 "F:\react-native-xaml\package\Codegen\TSProps.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Util.GetTypeScriptType(prop)));
            
            #line default
            #line hidden
            this.Write("; // synthetic property\r\n");
            
            #line 37 "F:\react-native-xaml\package\Codegen\TSProps.tt"
 } 
  foreach (var attachedDP in Util.AttachedProperties.Where(p => Properties.Any(sp => sp.Property == p && sp.DeclaringType == type))) {
            
            #line default
            #line hidden
            this.Write("  ");
            
            #line 39 "F:\react-native-xaml\package\Codegen\TSProps.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Util.ToJsName(attachedDP)));
            
            #line default
            #line hidden
            this.Write("?: ");
            
            #line 39 "F:\react-native-xaml\package\Codegen\TSProps.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Util.GetTypeScriptType(attachedDP)));
            
            #line default
            #line hidden
            this.Write("; // attached property\r\n");
            
            #line 40 "F:\react-native-xaml\package\Codegen\TSProps.tt"
 }
  foreach (var evt in type.GetEvents()) { 
            
            #line default
            #line hidden
            this.Write("  on");
            
            #line 42 "F:\react-native-xaml\package\Codegen\TSProps.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(evt.GetName()));
            
            #line default
            #line hidden
            this.Write("?: (event: NativeSyntheticEvent<undefined>) => void;\r\n");
            
            #line 43 "F:\react-native-xaml\package\Codegen\TSProps.tt"
 } 
  foreach (var evt in SyntheticEvents.Where(e => type == e.DeclaringType)) { 
            
            #line default
            #line hidden
            this.Write("  on");
            
            #line 45 "F:\react-native-xaml\package\Codegen\TSProps.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(evt.Name));
            
            #line default
            #line hidden
            this.Write("?: (event: NativeSyntheticEvent<");
            
            #line 45 "F:\react-native-xaml\package\Codegen\TSProps.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Util.GetTypeScriptType(evt)));
            
            #line default
            #line hidden
            this.Write(">) => void;\r\n");
            
            #line 46 "F:\react-native-xaml\package\Codegen\TSProps.tt"
 } 
            
            #line default
            #line hidden
            this.Write("}\r\n");
            
            #line 48 "F:\react-native-xaml\package\Codegen\TSProps.tt"
 if (ns != "") { 
            
            #line default
            #line hidden
            this.Write("}\r\n");
            
            #line 50 "F:\react-native-xaml\package\Codegen\TSProps.tt"
 } 
            
            #line default
            #line hidden
            
            #line 51 "F:\react-native-xaml\package\Codegen\TSProps.tt"
 } 
            
            #line default
            #line hidden
            this.Write("\r\nexport type XamlControlProps =");
            
            #line 53 "F:\react-native-xaml\package\Codegen\TSProps.tt"
 var first = true; foreach (var type in Types) {
	if (Util.HasCtor(type) || !type.IsSealed) {
		if (!first) 
            
            #line default
            #line hidden
            this.Write(" | ");
            
            #line 55 "F:\react-native-xaml\package\Codegen\TSProps.tt"
 ;
		
		first = false;
		
            
            #line default
            #line hidden
            this.Write(" ");
            
            #line 58 "F:\react-native-xaml\package\Codegen\TSProps.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Util.GetNativePropsName(type)));
            
            #line default
            #line hidden
            this.Write("\r\n\t");
            
            #line 59 "F:\react-native-xaml\package\Codegen\TSProps.tt"
 }
	} 
            
            #line default
            #line hidden
            this.Write(";\r\n\r\n\r\n");
            return this.GenerationEnvironment.ToString();
        }
    }
    
    #line default
    #line hidden
    #region Base class
    /// <summary>
    /// Base class for this transformation
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
    public class TSPropsBase
    {
        #region Fields
        private global::System.Text.StringBuilder generationEnvironmentField;
        private global::System.CodeDom.Compiler.CompilerErrorCollection errorsField;
        private global::System.Collections.Generic.List<int> indentLengthsField;
        private string currentIndentField = "";
        private bool endsWithNewline;
        private global::System.Collections.Generic.IDictionary<string, object> sessionField;
        #endregion
        #region Properties
        /// <summary>
        /// The string builder that generation-time code is using to assemble generated output
        /// </summary>
        protected System.Text.StringBuilder GenerationEnvironment
        {
            get
            {
                if ((this.generationEnvironmentField == null))
                {
                    this.generationEnvironmentField = new global::System.Text.StringBuilder();
                }
                return this.generationEnvironmentField;
            }
            set
            {
                this.generationEnvironmentField = value;
            }
        }
        /// <summary>
        /// The error collection for the generation process
        /// </summary>
        public System.CodeDom.Compiler.CompilerErrorCollection Errors
        {
            get
            {
                if ((this.errorsField == null))
                {
                    this.errorsField = new global::System.CodeDom.Compiler.CompilerErrorCollection();
                }
                return this.errorsField;
            }
        }
        /// <summary>
        /// A list of the lengths of each indent that was added with PushIndent
        /// </summary>
        private System.Collections.Generic.List<int> indentLengths
        {
            get
            {
                if ((this.indentLengthsField == null))
                {
                    this.indentLengthsField = new global::System.Collections.Generic.List<int>();
                }
                return this.indentLengthsField;
            }
        }
        /// <summary>
        /// Gets the current indent we use when adding lines to the output
        /// </summary>
        public string CurrentIndent
        {
            get
            {
                return this.currentIndentField;
            }
        }
        /// <summary>
        /// Current transformation session
        /// </summary>
        public virtual global::System.Collections.Generic.IDictionary<string, object> Session
        {
            get
            {
                return this.sessionField;
            }
            set
            {
                this.sessionField = value;
            }
        }
        #endregion
        #region Transform-time helpers
        /// <summary>
        /// Write text directly into the generated output
        /// </summary>
        public void Write(string textToAppend)
        {
            if (string.IsNullOrEmpty(textToAppend))
            {
                return;
            }
            // If we're starting off, or if the previous text ended with a newline,
            // we have to append the current indent first.
            if (((this.GenerationEnvironment.Length == 0) 
                        || this.endsWithNewline))
            {
                this.GenerationEnvironment.Append(this.currentIndentField);
                this.endsWithNewline = false;
            }
            // Check if the current text ends with a newline
            if (textToAppend.EndsWith(global::System.Environment.NewLine, global::System.StringComparison.CurrentCulture))
            {
                this.endsWithNewline = true;
            }
            // This is an optimization. If the current indent is "", then we don't have to do any
            // of the more complex stuff further down.
            if ((this.currentIndentField.Length == 0))
            {
                this.GenerationEnvironment.Append(textToAppend);
                return;
            }
            // Everywhere there is a newline in the text, add an indent after it
            textToAppend = textToAppend.Replace(global::System.Environment.NewLine, (global::System.Environment.NewLine + this.currentIndentField));
            // If the text ends with a newline, then we should strip off the indent added at the very end
            // because the appropriate indent will be added when the next time Write() is called
            if (this.endsWithNewline)
            {
                this.GenerationEnvironment.Append(textToAppend, 0, (textToAppend.Length - this.currentIndentField.Length));
            }
            else
            {
                this.GenerationEnvironment.Append(textToAppend);
            }
        }
        /// <summary>
        /// Write text directly into the generated output
        /// </summary>
        public void WriteLine(string textToAppend)
        {
            this.Write(textToAppend);
            this.GenerationEnvironment.AppendLine();
            this.endsWithNewline = true;
        }
        /// <summary>
        /// Write formatted text directly into the generated output
        /// </summary>
        public void Write(string format, params object[] args)
        {
            this.Write(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, format, args));
        }
        /// <summary>
        /// Write formatted text directly into the generated output
        /// </summary>
        public void WriteLine(string format, params object[] args)
        {
            this.WriteLine(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, format, args));
        }
        /// <summary>
        /// Raise an error
        /// </summary>
        public void Error(string message)
        {
            System.CodeDom.Compiler.CompilerError error = new global::System.CodeDom.Compiler.CompilerError();
            error.ErrorText = message;
            this.Errors.Add(error);
        }
        /// <summary>
        /// Raise a warning
        /// </summary>
        public void Warning(string message)
        {
            System.CodeDom.Compiler.CompilerError error = new global::System.CodeDom.Compiler.CompilerError();
            error.ErrorText = message;
            error.IsWarning = true;
            this.Errors.Add(error);
        }
        /// <summary>
        /// Increase the indent
        /// </summary>
        public void PushIndent(string indent)
        {
            if ((indent == null))
            {
                throw new global::System.ArgumentNullException("indent");
            }
            this.currentIndentField = (this.currentIndentField + indent);
            this.indentLengths.Add(indent.Length);
        }
        /// <summary>
        /// Remove the last indent that was added with PushIndent
        /// </summary>
        public string PopIndent()
        {
            string returnValue = "";
            if ((this.indentLengths.Count > 0))
            {
                int indentLength = this.indentLengths[(this.indentLengths.Count - 1)];
                this.indentLengths.RemoveAt((this.indentLengths.Count - 1));
                if ((indentLength > 0))
                {
                    returnValue = this.currentIndentField.Substring((this.currentIndentField.Length - indentLength));
                    this.currentIndentField = this.currentIndentField.Remove((this.currentIndentField.Length - indentLength));
                }
            }
            return returnValue;
        }
        /// <summary>
        /// Remove any indentation
        /// </summary>
        public void ClearIndent()
        {
            this.indentLengths.Clear();
            this.currentIndentField = "";
        }
        #endregion
        #region ToString Helpers
        /// <summary>
        /// Utility class to produce culture-oriented representation of an object as a string.
        /// </summary>
        public class ToStringInstanceHelper
        {
            private System.IFormatProvider formatProviderField  = global::System.Globalization.CultureInfo.InvariantCulture;
            /// <summary>
            /// Gets or sets format provider to be used by ToStringWithCulture method.
            /// </summary>
            public System.IFormatProvider FormatProvider
            {
                get
                {
                    return this.formatProviderField ;
                }
                set
                {
                    if ((value != null))
                    {
                        this.formatProviderField  = value;
                    }
                }
            }
            /// <summary>
            /// This is called from the compile/run appdomain to convert objects within an expression block to a string
            /// </summary>
            public string ToStringWithCulture(object objectToConvert)
            {
                if ((objectToConvert == null))
                {
                    throw new global::System.ArgumentNullException("objectToConvert");
                }
                System.Type t = objectToConvert.GetType();
                System.Reflection.MethodInfo method = t.GetMethod("ToString", new System.Type[] {
                            typeof(System.IFormatProvider)});
                if ((method == null))
                {
                    return objectToConvert.ToString();
                }
                else
                {
                    return ((string)(method.Invoke(objectToConvert, new object[] {
                                this.formatProviderField })));
                }
            }
        }
        private ToStringInstanceHelper toStringHelperField = new ToStringInstanceHelper();
        /// <summary>
        /// Helper to produce culture-oriented representation of an object as a string
        /// </summary>
        public ToStringInstanceHelper ToStringHelper
        {
            get
            {
                return this.toStringHelperField;
            }
        }
        #endregion
    }
    #endregion
}
