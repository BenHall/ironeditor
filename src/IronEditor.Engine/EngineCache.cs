using System.Collections.Generic;
using System.IO;

namespace IronEditor.Engine
{
    public class EngineCache
    {
        private Dictionary<LanguageSettings, IEngine> Engines;
        public int CachedEngines
        {
            get
            {
                return Engines.Count;
            }
        }

        public EngineCache()
        {
            Engines = new Dictionary<LanguageSettings, IEngine>();
        }

        public IEngine GetEngine(LanguageSettings language, TextWriter outputStream)
        {
            if (Engines.ContainsKey(language))
                return Engines[language];

            IEngine engine = CreateEngine(language, outputStream);

            Engines.Add(language, engine);
            return engine;
        }

        private IEngine CreateEngine(LanguageSettings language, TextWriter outputStream)
        {
            IEngine engine;
            if (language.Language == "C#")
                engine = new CodeDomEngine(language, outputStream);
            else
                engine = new DLREngine(language, outputStream);
            return engine;
        }

        public void AppendPathToEngines(string path)
        {
            foreach (KeyValuePair<LanguageSettings, IEngine> pair in Engines)
                pair.Value.AddPath(path);
        }
    }
}
