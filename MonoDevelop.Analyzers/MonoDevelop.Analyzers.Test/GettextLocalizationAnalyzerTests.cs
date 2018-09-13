using Microsoft.CodeAnalysis.Diagnostics;

namespace MonoDevelop.Analyzers.Test
{
    public class GettextLocalizationAnalyzerTests : BaseLocalizationAnalyzerTests
    {
        protected override (int, int)[] GetLocations()
        {
            return new[] { (42, 29), (43, 29), (44, 29), (46, 29), };
        }

        protected override DiagnosticAnalyzer GetCSharpDiagnosticAnalyzer()
        {
            return new GettextConcatenationDiagnosticAnalyzer();
        }

        //protected override CodeFixProvider GetCSharpCodeFixProvider()
        //{
        //    return new MonoDevelopAnalyzersCodeFixProvider();
        //}
    }
}