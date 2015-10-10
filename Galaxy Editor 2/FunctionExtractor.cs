using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Text.RegularExpressions;
using Galaxy_Editor_2.Compiler.Phases;
using Galaxy_Editor_2.Compiler.Generated.node;

namespace Galaxy_Editor_2
{
    /// <summary>
    /// Class for crawling the StarCraft 2 MPQs to grab the *.galaxy files inside. These files are parsed for (native) functions and constants.
    /// </summary>
    class FunctionExtractor
    {
        /// <summary>
        /// <para>Search for (native) functions of the kind:</para>
	    /// <c>(native) 'type' 'functionName' ('functionParameter');</c>
        /// </summary>
        private const string FUNCTION_PATTERN = "(native\\s+)?([a-zA-Z]+)\\s+([_a-zA-Z0-9]+)\\s*\\(((\\s*[_a-zA-Z0-9]+\\s+[_a-zA-Z0-9]+\\s*[,]*)*)\\)";

		/// <summary>
		/// <para>Search for constants of the kind:</para>
		/// <c>const 'type' 'name' = 'value';</c>
		/// </summary>
		private const String CONSTANT_PATTERN = "const\\s+([a-zA-Z]*)\\s+(c_[a-zA-Z0-9]*)\\s*=(.*);";

		private readonly Regex FUNCTION_REGEX = new Regex(FUNCTION_PATTERN, RegexOptions.Compiled);
		private readonly Regex CONSTANT_REGEX = new Regex(CONSTANT_PATTERN, RegexOptions.Compiled);

		private HashSet<ParsedFunction> functions = new HashSet<ParsedFunction>();
		private HashSet<ParsedConstant> constants = new HashSet<ParsedConstant>();

        /// <summary>
        /// Crawls the StarCraft 2 MPQs to grab the *.galaxy files inside. These files are parsed for (native) functions and constants.
        /// </summary>
        /// <returns>The functions and constants of StarCraft 2 in form of a LibraryData</returns>
        internal static LibraryData LoadFunctions()
        {
            FunctionExtractor extrator = new FunctionExtractor();
            return extrator.loadLibraries();
        }

		FunctionExtractor()
		{
		}

        /// <summary>
        /// Crawls the StarCraft 2 MPQs to grab the *.galaxy files inside. These files are parsed for (native) functions and constants.
        /// </summary>
        /// <returns>The functions and constants of StarCraft 2 in form of a LibraryData</returns>
        LibraryData loadLibraries() 
        {
            // parse the files for functions and constants
            CrawlAndParseMpqs();

            // convert the functions and constants to a LibraryData format
            LibraryData lib = new LibraryData();

            // create the methods with from crawled info
            foreach (ParsedFunction function in functions)
            {
                AMethodDecl method = new AMethodDecl();
                if (function.IsNative)
                    method.SetNative(new TNative("native"));
                method.SetName(new TIdentifier(function.Name));
                method.SetReturnType(new ANamedType(new TIdentifier(function.ReturnType), null));

                // add function parameter
                foreach (var parameter in function.Parameters)
                {
                    method.GetFormals().Add(new AALocalDecl(new APublicVisibilityModifier(), null, null, null, null,
                                                                new ANamedType(new TIdentifier(parameter.Item1), null),
                                                                new TIdentifier(parameter.Item2), null));
                }

                lib.Methods.Add(method);
            }

            // create the constants from the crawled info
            foreach (ParsedConstant constant in constants)
            {
                AFieldDecl field = new AFieldDecl(new APublicVisibilityModifier(), null, new TConst("const"),
                    new ANamedType(new TIdentifier(constant.Type), null),
                    new TIdentifier(constant.Name), new AStringConstExp(new TStringLiteral(constant.Value)));
                lib.Fields.Add(field);
            }

            functions.Clear();
            constants.Clear();

            return lib;
        }

        private void CrawlAndParseMpqs()
        {
            //Get Libs from TriggerLibs Directory
            DirectoryInfo versionDir = new DirectoryInfo("TriggerLibs");
            if (!versionDir.Exists) return;
            System.Text.ASCIIEncoding enc = new System.Text.ASCIIEncoding();
            List<FileInfo> galaxyFiles = new List<FileInfo>();
            galaxyFiles.AddRange(versionDir.GetFiles("*.galaxy"));
            foreach (var subDir in versionDir.GetDirectories())
            {
                galaxyFiles.AddRange(subDir.GetFiles("*.galaxy"));
            }
            foreach (FileInfo file in galaxyFiles)
            {
                string fileContent = File.ReadAllText(file.FullName, Encoding.ASCII);
                ParseFile(fileContent);
            }
            ////Console.WriteLine("Sc2 Path:");
            ////Console.WriteLine(Options.General.SC2Exe.FullName);
            //if (Options.General.SC2Exe == null) return ;
            //DirectoryInfo versionDir = new DirectoryInfo(Options.General.SC2Exe.Directory + @"\Mods");
            //if (!versionDir.Exists) return;
            ////Console.WriteLine("Versions Path:");
            ////Console.WriteLine(versionDir.FullName);

            //// These are all the patch folders of starcraft
            //// Every folder may contain multiple "SC2Archive" files which may contain trigger natives
            //System.Text.ASCIIEncoding enc = new System.Text.ASCIIEncoding();
            //foreach (var subDir in versionDir.GetDirectories())
            //{
            //    List<FileInfo> filesToSearch = new List<FileInfo>();
            //    //filesToSearch.AddRange(subDir.GetFiles("*.SC2Archive"));
            //    //filesToSearch.AddRange(subDir.GetFiles("*.SC2Data"));
            //    filesToSearch.AddRange(subDir.GetFiles("*Base.SC2Data"));
            //    foreach (var archive in filesToSearch)
            //    {
            //        //Console.WriteLine("looking at: " + archive.FullName + "...");

            //        MpqEditor.MpqReader fileReader = new MpqEditor.MpqReader(archive.FullName);
            //        if (!fileReader.Valid) continue;

            //        string[] foundGalaxyFiles = fileReader.FindFiles("*.galaxy");
            //        foreach (var file in foundGalaxyFiles)
            //        {
            //            //Console.WriteLine("\tfile: " + file);
            //            string fileContent = enc.GetString(fileReader.ExtractFile(file));
            //            ParseFile(fileContent);
            //        }
            //    }
            //}
        }
        //public void AddModFunction(FileInfo mod)
        //{
        //    System.Text.ASCIIEncoding enc = new System.Text.ASCIIEncoding();
        //    MpqEditor.MpqReader fileReader = new MpqEditor.MpqReader(mod.FullName);
        //    if (!fileReader.Valid) return;

        //    string[] foundGalaxyFiles = fileReader.FindFiles("*.galaxy");
        //    foreach (var file in foundGalaxyFiles)
        //    {
        //        //Console.WriteLine("\tfile: " + file);
        //        string fileContent = enc.GetString(fileReader.ExtractFile(file));
        //        ParseFile(fileContent);
        //    }
        //}
        private void ParseFile(string fileContents)
        {
            ParseFunctions(fileContents);
			ParseConstants(fileContents);
        }

        private void ParseFunctions(string fileContents)
        {
			MatchCollection matches = FUNCTION_REGEX.Matches(fileContents);

            // Report on each match.
            foreach (Match match in matches)
            {
                // group[0] is the whole mathed string

                // group[1] is filled with "native  " (yes with spaces) if the function is a native function
                bool isNative = match.Groups[1].Length != 0;

                // group[2] is the return type
				// there are cases where a return statement function call with 0 parameters is parsed as a function
				// skip these false positives
                string returnType = match.Groups[2].Value;
				if (returnType == "return")
				{
					continue;
				}

                // group[3] is the function name
                string name =  match.Groups[3].Value;

                // group[4] contains all the parameters in the form
                // (type name, type name, type name, ...)
                string allParameters = match.Groups[4].Value.Trim();

                ParsedFunction function = new ParsedFunction(isNative, returnType, name, allParameters);
                functions.Add(function);
            }
        }

        private void ParseConstants(string fileContents)
        {
			MatchCollection matches = CONSTANT_REGEX.Matches(fileContents);

            // Report on each match.
            foreach (Match match in matches)
            {
				// group[0] is the complete match

				// group[1] is the type
				string type = match.Groups[1].Value;

				// group[2] is the name
				string name = match.Groups[2].Value;

				// group[3] is the value
				string value = match.Groups[3].Value;

				constants.Add(new ParsedConstant(type, name, value));
            }
        }

        /// <summary>
        /// Wrapper class for a parsed function with native flag, returntype, name and parameters
        /// </summary>
        private class ParsedFunction 
        {
            public bool IsNative { get; private set; }
            public string ReturnType { get; private set; }
            public string Name { get; private set; }
            public List<Tuple<string, string>> Parameters { get; private set; }

            public ParsedFunction(bool isNative, string returnType, string name, string rawParameters)
            {
                this.IsNative = isNative;
                this.ReturnType = returnType;
                this.Name = name;
                this.Parameters = new List<Tuple<string, string>>();

                // parse the parameters of the function
                // parameters come in the form of "int a, int b, int c"
                if (rawParameters.Length > 0)
                {
                    string[] parameterPairs = rawParameters.Split(',');
                    foreach (string parameterPair in parameterPairs)
                    {
                        string[] parmeterInfo = Regex.Replace(parameterPair.Trim(), @"\s", "|").Split('|');
                        string paramType = parmeterInfo[0];
                        string paramName = parmeterInfo[1];

                        this.Parameters.Add(new Tuple<string, string>(paramType, paramName));
                    }
                }
            }

            // override object.Equals
            public override bool Equals(object obj)
            {
                if (obj == null || GetType() != obj.GetType())
                {
                    return false;
                }

                ParsedFunction other = (ParsedFunction)obj;
                return this.Name == other.Name;
            }

            // override object.GetHashCode
            public override int GetHashCode()
            {
                return Name.GetHashCode();
            }
        }

        /// <summary>
        /// Wrapper class for parsed constants with a type, name and value
        /// </summary>
        private class ParsedConstant
        {
            public string Type { get; private set; }
			public string Name { get; private set; }
			public string Value { get; private set; }

			public ParsedConstant(string type, string name, string value)
			{
				Type = type;
				Name = name;
				Value = value.Trim();
			}

			public override bool Equals(object obj)
			{
				if (obj == null || GetType() != obj.GetType())
				{
					return false;
				}

				ParsedConstant other = (ParsedConstant)obj;
				return this.Type == other.Type && this.Name == other.Name;
			}

			// override object.GetHashCode
			public override int GetHashCode()
			{
				return Type.GetHashCode() + Name.GetHashCode();
			}
        }
    }
}
