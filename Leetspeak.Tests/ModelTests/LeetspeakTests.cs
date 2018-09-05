using Microsoft.VisualStudio.TestTools.UnitTesting;
using Leetspeak;

namespace Leetspeak.Tests
{
  [TestClass]
  public class LeetspeakTranslatorTest
  {
    [TestMethod]
    public void Translate_ReturnUserInput_True()
    {
      LeetspeakTranslator test = new LeetspeakTranslator();
      Assert.AreEqual("dig", test.Translate("dig"));
    }
    [TestMethod]
    public void Translate_ChangeEto3_True()
    {
      LeetspeakTranslator test = new LeetspeakTranslator();
      Assert.AreEqual("b3d", test.Translate("bed"));
    }
    [TestMethod]
    public void Translate_ChangeOto0_True()
    {
      LeetspeakTranslator test = new LeetspeakTranslator();
      Assert.AreEqual("d0g", test.Translate("dog"));
    }
    [TestMethod]
    public void Translate_ChangeCapitalIto1_True()
    {
      LeetspeakTranslator test = new LeetspeakTranslator();
      Assert.AreEqual("1cky", test.Translate("Icky"));
    }
    [TestMethod]
    public void Translate_ChangeTto7_True()
    {
      LeetspeakTranslator test = new LeetspeakTranslator();
      Assert.AreEqual("7a7", test.Translate("tat"));
    }
    [TestMethod]
    public void Translate_ChangeNonInitialStoZ_True()
    {
      LeetspeakTranslator test = new LeetspeakTranslator();
      Assert.AreEqual("sazz sazz", test.Translate("sass sass"));
    }
    [TestMethod]
    public void Translate_AllPreviousSpecs_True()
    {
      LeetspeakTranslator test = new LeetspeakTranslator();
      Assert.AreEqual("D0n'7 y0u l0v3 7h3z3 'S7ring' 3x3rciz3z? 1 d0!", test.Translate("Don't you love these 'String' exercises? I do!"));
    }

  }
}
