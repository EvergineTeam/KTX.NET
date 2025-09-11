using CppAst;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KTXGen
{
    public class CsCodeGenerator
    {
        private CsCodeGenerator()
        {
        }

        public static CsCodeGenerator Instance { get; } = new CsCodeGenerator();

        public void Generate(CppCompilation compilation, string outputPath)
        {
            Helpers.DelegatesList = new List<string>();
            foreach(var typedef in compilation.Typedefs)
            {
                if(typedef.ElementType is CppPointerType pointerType)
                {
                    if (pointerType.ElementType is CppFunctionType functionType)
                    {
                        Helpers.DelegatesList.Add(typedef.Name);
                    }
                }
            }

            // GenerateConstants(compilation, outputPath);
            GenerateEnums(compilation, outputPath);
            GenerateStructs(compilation, outputPath);
            GenerateDelegates(compilation, outputPath);
            GenerateFunctions(compilation, outputPath);
        }

        private void GenerateConstants(CppCompilation compilation, string outputPath)
        {
            Debug.WriteLine("Generating Constants...");

            using (StreamWriter file = File.CreateText(Path.Combine(outputPath, "Constants.cs")))
            {
                file.WriteLine("using System;");
                file.WriteLine("using System.Runtime.InteropServices;\n");
                file.WriteLine($"namespace Evergine.Bindings.KTX");
                file.WriteLine("{");
                file.WriteLine($"\tpublic static partial class KTX");
                file.WriteLine("\t{");

                foreach (var cppMacro in compilation.Macros)
                {
                    if (string.IsNullOrEmpty(cppMacro.Value))
                        continue;

                    string enumType = Helpers.ConvertEnumType(cppMacro.Value, out string csDataType);
                    file.Write($"\t\tpublic const uint {cppMacro.Name} = {cppMacro.Value};\n");
                }
                file.WriteLine("\t}\n}");
            }
        }

        private static string removeUnderscorePrefix(string name)
        {
            if (name.StartsWith("_"))
            {
                name = name.Substring(1);
            }
            return name;
        }

        public void GenerateEnums(CppCompilation compilation, string outputPath)
        {
            Debug.WriteLine("Generating Enums...");

            using (StreamWriter file = File.CreateText(Path.Combine(outputPath, "Enums.cs")))
            {
                file.WriteLine("using System;\n");
                file.WriteLine("namespace Evergine.Bindings.KTX");
                file.WriteLine("{");

                var enums = compilation.Enums.Where(e => e.Items.Count > 0 && !e.IsAnonymous).ToList();

                foreach (var cppEnum in enums)
                {
                    Helpers.PrintComments(file, cppEnum.Comment, "\t");
                    if (compilation.Typedefs.Any(t => t.Name == cppEnum.Name + "Flags"))
                    {
                        file.WriteLine("\t[Flags]");
                    }

                    file.WriteLine($"\tpublic enum {removeUnderscorePrefix(cppEnum.Name)}");
                    file.WriteLine("\t{");

                    foreach (var member in cppEnum.Items)
                    {
                        Helpers.PrintComments(file, member.Comment, "\t\t", true);
                        file.WriteLine($"\t\t{member.Name} = {member.Value},");
                    }

                    file.WriteLine("\t}\n");
                }

                file.WriteLine("}");
            }
        }

        private void GenerateDelegates(CppCompilation compilation, string outputPath)
        {
            Debug.WriteLine("Generating Delegates...");

            var delegates = compilation.Typedefs
                .Where(t => t.TypeKind == CppTypeKind.Typedef
                       && t.ElementType is CppPointerType
                       && ((CppPointerType)t.ElementType).ElementType.TypeKind == CppTypeKind.Function)
                .ToList();

            using (StreamWriter file = File.CreateText(Path.Combine(outputPath, "Delegates.cs")))
            {
                file.WriteLine("using System;");
                file.WriteLine("using System.Runtime.InteropServices;\n");
                file.WriteLine("namespace Evergine.Bindings.KTX");
                file.WriteLine("{");

                foreach (var funcPointer in delegates)
                {
                    CppFunctionType pointerType = ((CppPointerType)funcPointer.ElementType).ElementType as CppFunctionType;
                    if (Helpers.FunctionTypeUsesBlacklistedType(pointerType)) continue;
                    Helpers.PrintComments(file, funcPointer.Comment, "\t");

                    var returnType = Helpers.ConvertToCSharpType(pointerType.ReturnType);
                    returnType = Helpers.ShowAsMarshalType(returnType, Helpers.Family.ret);
                    file.Write($"\tpublic unsafe delegate {returnType} {funcPointer.Name}(");

                    if (pointerType.Parameters.Count > 0)
                    {
                        file.Write("\n");

                        for (int i = 0; i < pointerType.Parameters.Count; i++)
                        {
                            if (i > 0)
                                file.Write(",\n");

                            var parameter = pointerType.Parameters[i];
                            var convertedType = Helpers.ConvertToCSharpType(parameter.Type);
                            convertedType = Helpers.ShowAsMarshalType(convertedType, Helpers.Family.param);
                            var validName = Helpers.ValidParamName(parameter.Name, convertedType, i);
                            file.Write($"\t\t {convertedType} {validName}");
                        }
                    }

                    file.Write(");\n\n");
                }

                file.WriteLine("}");
            }
        }

        private void GenerateStructs(CppCompilation compilation, string outputPath)
        {
            Debug.WriteLine("Generating Structs...");

            using (StreamWriter file = File.CreateText(Path.Combine(outputPath, "Structs.cs")))
            {
                file.WriteLine("using System;");
                file.WriteLine("using System.Runtime.InteropServices;\n");
                file.WriteLine("namespace Evergine.Bindings.KTX");
                file.WriteLine("{");

                var structs = compilation.Classes.Where(c => c.ClassKind == CppClassKind.Struct && c.IsDefinition == true);

                foreach (var structure in structs)
                {
                    if (Helpers.typesBlacklist.Contains(structure.Name) || Helpers.privateStructs.Contains(structure.Name)) continue;

                    Helpers.PrintComments(file, structure.Comment, "\t");
                    file.WriteLine("\t[StructLayout(LayoutKind.Sequential)]");
                    file.WriteLine($"\tpublic unsafe struct {structure.Name}");
                    file.WriteLine("\t{");
                    foreach (var member in structure.Fields)
                    {
                        Helpers.PrintComments(file, member.Comment, "\t\t", true);
                        string type = Helpers.ConvertToCSharpType(member.Type);
                        type = Helpers.ShowAsMarshalType(type, Helpers.Family.field);
                        // Check if this is an array
                        if (member.Type is CppArrayType)
                        {
                            int count = (member.Type as CppAst.CppArrayType).Size;
                            file.WriteLine($"\t\tpublic fixed {type} {member.Name}[{count}];");
                        }
                        else // default case
                        {
                            file.WriteLine($"\t\tpublic {type} {member.Name};");
                        }
                    }

                    file.WriteLine("\t}\n");
                }
                file.WriteLine("}\n");
            }
        }

        private void GenerateFunctions(CppCompilation compilation, string outputPath)
        {
            Debug.WriteLine("Generating Functions...");

            using (StreamWriter file = File.CreateText(Path.Combine(outputPath, "Functions.cs")))
            {
                file.WriteLine("using System;");
                file.WriteLine("using System.Runtime.InteropServices;\n");
                file.WriteLine($"namespace Evergine.Bindings.KTX");
                file.WriteLine("{");
                file.WriteLine($"\tpublic static unsafe partial class KTX");
                file.WriteLine("\t{");

                file.WriteLine("#if __IOS__");
                file.WriteLine("\t\tprivate const string LibName = \"__Internal\";");
                file.WriteLine("#else");
                file.WriteLine("\t\tprivate const string LibName = \"ktx\";");
                file.WriteLine("#endif\n");

                foreach (var cppFunction in compilation.Functions)
                {
                    if ((cppFunction.Flags & CppFunctionFlags.FunctionTemplate) != CppFunctionFlags.None) continue;
                    if ((cppFunction.Flags & CppFunctionFlags.Inline) != CppFunctionFlags.None) continue;
                    if (Helpers.FunctionUsesBlacklistedType(cppFunction)) continue;

                    Helpers.PrintComments(file, cppFunction.Comment, "\t\t");
                    file.WriteLine($"\t\t[DllImport(LibName, CallingConvention = CallingConvention.Cdecl)]");
                    string returnType = Helpers.ConvertToCSharpType(cppFunction.ReturnType);
                    returnType = Helpers.ShowAsMarshalType(returnType, Helpers.Family.ret);
                    file.Write($"\t\tpublic static extern {returnType} {cppFunction.Name}(");
                    foreach (var parameter in cppFunction.Parameters)
                    {
                        if (parameter != cppFunction.Parameters.First())
                            file.Write(", ");

                        var convertedType = Helpers.ConvertToCSharpType(parameter.Type);
                        convertedType = Helpers.ShowAsMarshalType(convertedType, Helpers.Family.param);
                        string paramName = parameter.Name == "params" ? "@params" : parameter.Name;
                        file.Write($"{convertedType} {paramName}");
                    }
                    file.WriteLine(");\n");
                }
                file.WriteLine("\t}\n}");
            }
        }
    }
}
