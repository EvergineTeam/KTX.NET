using CppAst;
using System.Diagnostics;
using System.IO;
using System;

namespace KTXGen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var headerFile = Path.Combine(AppContext.BaseDirectory, "Headers", "ktx.h");
            var options = new CppParserOptions
            {
                ParseMacros = true,
                IncludeFolders = { Path.Combine(AppContext.BaseDirectory, "Headers")},
                SystemIncludeFolders =
                {
                    "C:\\Program Files (x86)\\Windows Kits\\10\\Include\\10.0.26100.0\\ucrt",
                    "C:\\Program Files\\Microsoft Visual Studio\\2022\\Professional\\VC\\Tools\\MSVC\\14.44.35207\\include"
                }
            };

            var compilation = CppParser.ParseFile(headerFile, options);

            // Print diagnostic messages
            if (compilation.HasErrors)
            {
                foreach (var message in compilation.Diagnostics.Messages)
                {
                    Debug.WriteLine(message);
                }
            }
            else
            {
                string outputPath = "..\\..\\..\\..\\..\\Evergine.Bindings.KTX\\Generated";
                CsCodeGenerator.Instance.Generate(compilation, outputPath);
            }
        }
    }
}
