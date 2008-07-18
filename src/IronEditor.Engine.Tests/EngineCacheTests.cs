using System;
using NUnit.Framework;
using System.Reflection;

namespace IronEditor.Engine.Tests
{
    [TestFixture]
    public class EngineCacheTests
    {
        [Test]
        public void GetEngine_PYEngine_ByLanguageSettingsObject_ReturnsDLREngine()
        {
            LanguageSettings python = Helper.CreateIronPythonSettings();
            EngineCache cache = new EngineCache();
            IEngine engine = cache.GetEngine(python, null);
            Assert.AreEqual("IronPython 2.0 Beta", engine.LanguageName);
        }

        [Test]
        public void GetEngine_PYEngine_CachedEnginesCountEquals1()
        {
            LanguageSettings python = Helper.CreateIronPythonSettings();
            EngineCache cache = new EngineCache();
            cache.GetEngine(python, null);
            Assert.AreEqual(1, cache.CachedEngines);
        }

        [Test]
        public void GetEngine_PYEngine_TwoCalls_SameObjectReturned()
        {
            LanguageSettings python = Helper.CreateIronPythonSettings();
            EngineCache cache = new EngineCache();

            IEngine engine1 = cache.GetEngine(python, null);
            IEngine engine2 = cache.GetEngine(python, null);
            Assert.AreEqual(engine1, engine2);
            Assert.AreEqual(1, cache.CachedEngines);
        }

        [Test]
        public void GetEngine_RBEngine_CreatesEngine_ReturnsObject()
        {
            LanguageSettings ruby = Helper.CreateIronRubySettings();
            EngineCache cache = new EngineCache();
            IEngine engine = cache.GetEngine(ruby, null);
            Assert.AreEqual("IronRuby", engine.LanguageName);
        }

        [Test]
        public void GetEngine_PYandRBEngine_TwoDifferentObjectsReturned()
        {
            LanguageSettings ruby = Helper.CreateIronRubySettings();
            LanguageSettings python = Helper.CreateIronPythonSettings();

            EngineCache cache = new EngineCache();
            IEngine rubyEngine = cache.GetEngine(ruby, null);
            IEngine pythonEngine = cache.GetEngine(python, null);
            Assert.AreNotEqual(rubyEngine, pythonEngine);
        }

        [Test]
        public void GetEngine_PYandRBEngine_CachedEnginesCountEquals2()
        {
            LanguageSettings ruby = Helper.CreateIronRubySettings();
            LanguageSettings python = Helper.CreateIronPythonSettings();

            EngineCache cache = new EngineCache();
            cache.GetEngine(ruby, null);
            cache.GetEngine(python, null);
            Assert.AreEqual(2, cache.CachedEngines);
        }

        [Test]
        public void AppendPathToEngines_ValidPath_EngineHavePathAdded()
        {
            string path = Environment.CurrentDirectory;
            LanguageSettings ruby = Helper.CreateIronRubySettings();
            EngineCache cache = new EngineCache();
            cache.AppendPathToEngines(path);
            IEngine engine = cache.GetEngine(ruby, null);

            bool found = false;
            foreach (string s in engine.ScriptSourceSearch())
            {
                if (s == path)
                {
                    found = true;
                    break;
                }
            }

            Assert.IsTrue(found);
        }


        [Test]
        public void AppendPathToEngines_ValidPath_2EnginesHavePathAdded()
        {
            string path = Environment.CurrentDirectory;
            LanguageSettings ruby = Helper.CreateIronRubySettings();
            LanguageSettings python = Helper.CreateIronPythonSettings();
            EngineCache cache = new EngineCache();
            cache.AppendPathToEngines(path);
            IEngine rubyEngine = cache.GetEngine(ruby, null);
            IEngine pythonEngine = cache.GetEngine(python, null);

            bool rubyFound = false;
            foreach (string s in rubyEngine.ScriptSourceSearch())
            {
                if (s == path)
                {
                    rubyFound = true;
                    break;
                }
            }
            bool pythonFound = false;
            foreach (string s in pythonEngine.ScriptSourceSearch())
            {
                if (s == path)
                {
                    pythonFound = true;
                    break;
                }
            }

            Assert.IsTrue(rubyFound);
            Assert.IsTrue(pythonFound);
        }
    }
}
