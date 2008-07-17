using NUnit.Framework;

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
    }
}
