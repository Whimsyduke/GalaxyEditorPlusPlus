using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Galaxy_Editor_2.Compiler.Generated.analysis;
using Galaxy_Editor_2.Compiler.Generated.node;
using System.Globalization;
using System.Threading;
using System.Resources;


namespace Galaxy_Editor_2.Compiler.Phases.Transformations
{
    class MainEntryFinder : DepthFirstAdapter
    {
        private FinalTransformations finalTrans;
        private ResourceManager LocRM = new ResourceManager("Galaxy_Editor_2.Language", typeof(Language).Assembly);

        public MainEntryFinder(FinalTransformations finalTrans)
        {
            this.finalTrans = finalTrans;
        }
        private List<ErrorCollection.Error> multipleEntryCandidates = new List<ErrorCollection.Error>();

        public override void CaseAMethodDecl(AMethodDecl node)
        {
            if (node.GetName().Text == "InitMap" && node.GetFormals().Count == 0)
            {
                if (finalTrans.multipleMainEntries)
                {
                    multipleEntryCandidates.Add(new ErrorCollection.Error(node.GetName(), Util.GetAncestor<AASourceFile>(node.GetName()), LocRM.GetString("ErrorText63")));
                }
                else if (finalTrans.mainEntry != null)
                {
                    multipleEntryCandidates.Add(new ErrorCollection.Error(finalTrans.mainEntry.GetName(), Util.GetAncestor<AASourceFile>(finalTrans.mainEntry.GetName()), LocRM.GetString("ErrorText63")));
                    multipleEntryCandidates.Add(new ErrorCollection.Error(node.GetName(), Util.GetAncestor<AASourceFile>(node.GetName()), LocRM.GetString("ErrorText63")));
                    //finalTrans.errors.Add(new ErrorCollection.Error(node.GetName(), Util.GetAncestor<AASourceFile>(node), "Found multiple candidates for a main entry", true));
                    finalTrans.multipleMainEntries = true;
                    finalTrans.mainEntry = null;
                }
                else
                    finalTrans.mainEntry = node;
            }
            base.CaseAMethodDecl(node);
        }

        public override void OutAAProgram(AAProgram node)
        {
            if (multipleEntryCandidates.Count > 0)
            {
                finalTrans.errors.Add(new ErrorCollection.Error(multipleEntryCandidates[0], LocRM.GetString("ErrorText1"), multipleEntryCandidates.ToArray()));
            }
        }
    }
}
