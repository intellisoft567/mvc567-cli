﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 15.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace Mvc567.Cli.Templates.ProjectInit
{
    using System;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "D:\GitHubWorkspace\mvc567-cli\Templates\ProjectInit\ProjectInitScheme.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "15.0.0.0")]
    public partial class ProjectInitScheme : ProjectInitSchemeBase
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public virtual string TransformText()
        {
            this.Write("{\r\n  \"sheme\": [\r\n    {\r\n      \"type\": \"folder\",\r\n      \"name\": \"{{ProjectName}}\"," +
                    "\r\n      \"content\": [\r\n        {\r\n          \"type\": \"file\",\r\n          \"name\": \"{" +
                    "{ProjectName}}.sln\",\r\n          \"templateName\": \"ProjectSolutionTemplate\"\r\n     " +
                    "   },\r\n        {\r\n          \"type\": \"folder\",\r\n          \"name\": \"src\",\r\n       " +
                    "   \"content\": [\r\n            {\r\n              \"type\": \"folder\",\r\n              \"" +
                    "name\": \"{{ProjectName}}\",\r\n              \"content\": [\r\n                {\r\n      " +
                    "            \"type\": \"folder\",\r\n                  \"name\": \"Controllers\",\r\n       " +
                    "           \"content\": [\r\n                    {\r\n                      \"type\": \"f" +
                    "older\",\r\n                      \"name\": \"API\"\r\n                    },\r\n          " +
                    "          {\r\n                      \"type\": \"folder\",\r\n                      \"nam" +
                    "e\": \"MVC\",\r\n                      \"content\": [\r\n                        {\r\n     " +
                    "                     \"type\": \"folder\",\r\n                          \"name\": \"Admin" +
                    "\",\r\n                          \"content\": [\r\n                            {\r\n     " +
                    "                         \"type\": \"file\",\r\n                              \"name\": " +
                    "\"AdminDashboardController.cs\",\r\n                              \"templateName\": \"A" +
                    "dminDashboardControllerTemplate\"\r\n                            }\r\n               " +
                    "           ]\r\n                        },\r\n                        {\r\n           " +
                    "               \"type\": \"file\",\r\n                          \"name\": \"HomeControlle" +
                    "r.cs\",\r\n                          \"templateName\": \"HomeControllerTemplate\"\r\n    " +
                    "                    }\r\n                      ]\r\n                    }\r\n         " +
                    "         ]\r\n                },\r\n                {\r\n                  \"type\": \"fo" +
                    "lder\",\r\n                  \"name\": \"DataAccess\",\r\n                  \"content\": [\r" +
                    "\n                    {\r\n                      \"type\": \"file\",\r\n                 " +
                    "     \"name\": \"EntityContext.cs\",\r\n                      \"templateName\": \"EntityC" +
                    "ontextTemplate\"\r\n                    },\r\n                    {\r\n                " +
                    "      \"type\": \"file\",\r\n                      \"name\": \"StandardRepository.cs\",\r\n " +
                    "                     \"templateName\": \"StandardRepositoryTemplate\"\r\n             " +
                    "       }\r\n                  ]\r\n                },\r\n                {\r\n          " +
                    "        \"type\": \"folder\",\r\n                  \"name\": \"Migrations\",\r\n            " +
                    "      \"content\": [\r\n\r\n                  ]\r\n                },\r\n                {" +
                    "\r\n                  \"type\": \"folder\",\r\n                  \"name\": \"privateroot\",\r" +
                    "\n                  \"content\": [\r\n                    {\r\n                      \"t" +
                    "ype\": \"folder\",\r\n                      \"name\": \"uploads\",\r\n                     " +
                    " \"content\": [\r\n                        {\r\n                          \"type\": \"fol" +
                    "der\",\r\n                          \"name\": \"global\"\r\n                        },\r\n " +
                    "                       {\r\n                          \"type\": \"folder\",\r\n         " +
                    "                 \"name\": \"temp\"\r\n                        },\r\n                   " +
                    "     {\r\n                          \"type\": \"folder\",\r\n                          \"" +
                    "name\": \"users\"\r\n                        }\r\n                      ]\r\n            " +
                    "        },\r\n                    {\r\n                      \"type\": \"file\",\r\n      " +
                    "                \"name\": \"config.json\",\r\n                      \"templateName\": \"P" +
                    "rivateConfigTemplate\"\r\n                    }\r\n                  ]\r\n             " +
                    "   },\r\n                {\r\n                  \"type\": \"folder\",\r\n                 " +
                    " \"name\": \"Properties\",\r\n                  \"content\": [\r\n                    {\r\n " +
                    "                     \"type\": \"file\",\r\n                      \"name\": \"launchSetti" +
                    "ngs.json\",\r\n                      \"templateName\": \"LaunchSettingsTemplate\"\r\n    " +
                    "                }\r\n                  ]\r\n                },\r\n                {\r\n " +
                    "                 \"type\": \"folder\",\r\n                  \"name\": \"Scripts\",\r\n      " +
                    "            \"content\": [\r\n                    {\r\n                      \"type\": \"" +
                    "folder\",\r\n                      \"name\": \"VueComponents\",\r\n                      " +
                    "\"content\": [\r\n                        {\r\n                          \"type\": \"file" +
                    "\",\r\n                          \"name\": \"App.js\",\r\n                          \"temp" +
                    "lateName\": \"VueComponentAppTemplate\"\r\n                        },\r\n              " +
                    "          {\r\n                          \"type\": \"file\",\r\n                        " +
                    "  \"name\": \"Home.js\",\r\n                          \"templateName\": \"VueComponentHom" +
                    "eTemplate\"\r\n                        }\r\n                      ]\r\n                " +
                    "    }\r\n                  ]\r\n                },\r\n                {\r\n             " +
                    "     \"type\": \"folder\",\r\n                  \"name\": \"Styles\",\r\n                  \"" +
                    "content\": [\r\n                    {\r\n                      \"type\": \"folder\",\r\n   " +
                    "                   \"name\": \"css\",\r\n                      \"content\": [\r\n\r\n       " +
                    "               ]\r\n                    },\r\n                    {\r\n               " +
                    "       \"type\": \"folder\",\r\n                      \"name\": \"scss\",\r\n               " +
                    "       \"content\": [\r\n                        {\r\n                          \"type\"" +
                    ": \"file\",\r\n                          \"name\": \"_misc.scss\",\r\n                    " +
                    "      \"templateName\": \"ScssMiscTemplate\"\r\n                        },\r\n          " +
                    "              {\r\n                          \"type\": \"file\",\r\n                    " +
                    "      \"name\": \"_variables.scss\",\r\n                          \"templateName\": \"Scs" +
                    "sVariablesTemplate\"\r\n                        },\r\n                        {\r\n    " +
                    "                      \"type\": \"file\",\r\n                          \"name\": \"style." +
                    "scss\",\r\n                          \"templateName\": \"ScssStyleTemplate\"\r\n         " +
                    "               }\r\n                      ]\r\n                    }\r\n              " +
                    "    ]\r\n                },\r\n                {\r\n                  \"type\": \"folder\"" +
                    ",\r\n                  \"name\": \"Views\",\r\n                  \"content\": [\r\n         " +
                    "           {\r\n                      \"type\": \"folder\",\r\n                      \"na" +
                    "me\": \"AreasViews\",\r\n                      \"content\": [\r\n                        " +
                    "{\r\n                          \"type\": \"folder\",\r\n                          \"name\"" +
                    ": \"Admin\",\r\n                          \"content\": [\r\n                            " +
                    "{\r\n                              \"type\": \"folder\",\r\n                            " +
                    "  \"name\": \"AdminDashboard\",\r\n                              \"content\": [\r\n       " +
                    "                         {\r\n                                  \"type\": \"file\",\r\n " +
                    "                                 \"name\": \"Index.cshtml\",\r\n                      " +
                    "            \"templateName\": \"AdminDashboardIndexViewTemplate\"\r\n                 " +
                    "               }\r\n                              ]\r\n                            }" +
                    ",\r\n                            {\r\n                              \"type\": \"file\",\r" +
                    "\n                              \"name\": \"_ViewImports.cshtml\",\r\n                 " +
                    "             \"templateName\": \"AdminAreaViewImportsTemplate\"\r\n                   " +
                    "         },\r\n                            {\r\n                              \"type\"" +
                    ": \"file\",\r\n                              \"name\": \"_ViewStart.cshtml\",\r\n         " +
                    "                     \"templateName\": \"AdminAreaViewStartTemplate\"\r\n             " +
                    "               }\r\n                          ]\r\n                        }\r\n      " +
                    "                ]\r\n                    },\r\n                    {\r\n              " +
                    "        \"type\": \"folder\",\r\n                      \"name\": \"Components\",\r\n        " +
                    "              \"content\": [\r\n                        {\r\n                         " +
                    " \"type\": \"folder\",\r\n                          \"name\": \"Vue\"\r\n                   " +
                    "     }\r\n                      ]\r\n                    },\r\n                    {\r\n" +
                    "                      \"type\": \"folder\",\r\n                      \"name\": \"Controll" +
                    "ersViews\",\r\n                      \"content\": [\r\n                        {\r\n     " +
                    "                     \"type\": \"folder\",\r\n                          \"name\": \"Home\"" +
                    ",\r\n                          \"content\": [\r\n                            {\r\n      " +
                    "                        \"type\": \"file\",\r\n                              \"name\": \"" +
                    "Index.cshtml\",\r\n                              \"templateName\": \"HomeIndexViewTemp" +
                    "late\"\r\n                            }\r\n                          ]\r\n             " +
                    "           },\r\n                        {\r\n                          \"type\": \"fol" +
                    "der\",\r\n                          \"name\": \"Shared\",\r\n                          \"c" +
                    "ontent\": [\r\n                            {\r\n                              \"type\":" +
                    " \"file\",\r\n                              \"name\": \"_Layout.cshtml\",\r\n             " +
                    "                 \"templateName\": \"ViewLayoutTemplate\"\r\n                         " +
                    "   }\r\n                          ]\r\n                        },\r\n                 " +
                    "       {\r\n                          \"type\": \"file\",\r\n                          \"" +
                    "name\": \"_ViewImports.cshtml\",\r\n                          \"templateName\": \"ViewIm" +
                    "portsTemplate\"\r\n                        },\r\n                        {\r\n         " +
                    "                 \"type\": \"file\",\r\n                          \"name\": \"_ViewStart." +
                    "cshtml\",\r\n                          \"templateName\": \"ViewStartTemplate\"\r\n       " +
                    "                 }\r\n                      ]\r\n                    },\r\n           " +
                    "         {\r\n                      \"type\": \"folder\",\r\n                      \"name" +
                    "\": \"EmailViews\"\r\n                    }\r\n                  ]\r\n                },\r" +
                    "\n                {\r\n                  \"type\": \"folder\",\r\n                  \"name" +
                    "\": \"wwwroot\",\r\n                  \"content\": [\r\n                    {\r\n          " +
                    "            \"type\": \"folder\",\r\n                      \"name\": \"assets\",\r\n        " +
                    "              \"content\": [\r\n                        {\r\n                         " +
                    " \"type\": \"folder\",\r\n                          \"name\": \"css\"\r\n                   " +
                    "     },\r\n                        {\r\n                          \"type\": \"folder\",\r" +
                    "\n                          \"name\": \"images\",\r\n                          \"content" +
                    "\": [\r\n\r\n                          ]\r\n                        }\r\n                " +
                    "      ]\r\n                    },\r\n                    {\r\n                      \"t" +
                    "ype\": \"folder\",\r\n                      \"name\": \"content\",\r\n                     " +
                    " \"content\": [\r\n                        {\r\n                          \"type\": \"fol" +
                    "der\",\r\n                          \"name\": \"global\"\r\n                        },\r\n " +
                    "                       {\r\n                          \"type\": \"folder\",\r\n         " +
                    "                 \"name\": \"users\"\r\n                        }\r\n                   " +
                    "   ]\r\n                    },\r\n                    {\r\n                      \"type" +
                    "\": \"folder\",\r\n                      \"name\": \"locales\",\r\n                      \"c" +
                    "ontent\": [\r\n                        {\r\n                          \"type\": \"file\"," +
                    "\r\n                          \"name\": \"en.json\",\r\n                          \"templ" +
                    "ateName\": \"EmptyJsonTemplate\"\r\n                        }\r\n                      " +
                    "]\r\n                    }\r\n                  ]\r\n                },\r\n             " +
                    "   {\r\n                  \"type\": \"file\",\r\n                  \"name\": \"{{ProjectNam" +
                    "e}}.csproj\",\r\n                  \"templateName\": \"ProjectFileTemplate\"\r\n         " +
                    "       },\r\n                {\r\n                  \"type\": \"file\",\r\n               " +
                    "   \"name\": \"appsettings.json\",\r\n                  \"templateName\": \"AppSettingsTe" +
                    "mplate\"\r\n                },\r\n                {\r\n                  \"type\": \"file\"" +
                    ",\r\n                  \"name\": \"appsettings.Development.json\",\r\n                  " +
                    "\"templateName\": \"AppSettingsTemplate\"\r\n                },\r\n                {\r\n  " +
                    "                \"type\": \"file\",\r\n                  \"name\": \"adminmenus.json\",\r\n " +
                    "                 \"templateName\": \"AdminMenusTemplate\"\r\n                },\r\n     " +
                    "           {\r\n                  \"type\": \"file\",\r\n                  \"name\": \"pack" +
                    "age.json\",\r\n                  \"templateName\": \"PackageJsonTemplate\"\r\n           " +
                    "     },\r\n                {\r\n                  \"type\": \"file\",\r\n                 " +
                    " \"name\": \"gulpfile.js\",\r\n                  \"templateName\": \"GulpFileTemplate\"\r\n " +
                    "               },\r\n                {\r\n                  \"type\": \"file\",\r\n       " +
                    "           \"name\": \"Program.cs\",\r\n                  \"templateName\": \"ProgramTemp" +
                    "late\"\r\n                },\r\n                {\r\n                  \"type\": \"file\",\r" +
                    "\n                  \"name\": \"Startup.cs\",\r\n                  \"templateName\": \"Sta" +
                    "rtupTemplate\"\r\n                }\r\n              ]\r\n            }\r\n          ]\r\n " +
                    "       }\r\n      ]\r\n    }\r\n  ]\r\n}\r\n");
            return this.GenerationEnvironment.ToString();
        }
    }
    
    #line default
    #line hidden
    #region Base class
    /// <summary>
    /// Base class for this transformation
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "15.0.0.0")]
    public class ProjectInitSchemeBase
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
