using System.Diagnostics;
using System.IO;
using Microsoft.Scripting.Hosting;

namespace IronEditor.Engine
{
    public class DLREngine : IEngine
    {
        private ScriptEngine Engine;
        internal TextWriter Output;
        private LanguageSettings Language;
        public DLREngine(LanguageSettings language, TextWriter output)
        {
            Language = language;
            Output = output;
            DLREngineFactory factory = new DLREngineFactory();
            Engine = factory.CreateEngine(language);
        }

        public void ExecuteStatement(string code)
        {
            ScriptExecutor executor = new ScriptExecutor(Engine, Output);
            executor.ExecuteStatement(code);
        }

        public string GetSaveFilter()
        {
            EngineInformation info = new EngineInformation(Engine);
            return info.GetSaveFilter();
        }

        public string LanguageName
        {
            get { return Engine.LanguageDisplayName; }
        }

        public bool CanExecuteConsole
        {
            get
            {
                return !string.IsNullOrEmpty(Language.CommandLineApplication) && File.Exists(PathToConsoleApplication);
            }
        }

        private string PathToConsoleApplication
        {
            get
            {
                return Path.Combine(Language.BinDirectory, Language.CommandLineApplication);
            }
        }

        public void LaunchConsole()
        {
            if(CanExecuteConsole)
                Process.Start(PathToConsoleApplication);
        }
    }
}