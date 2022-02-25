using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery.Models;

namespace Pierres.TestTools
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void BreadConstructor_CreatesInstanceOfBread_Bread()
    {
      Bread fiveLoaves = new Bread(5);
      Assert.AreEqual(typeof(Bread), fiveLoaves.GetType());
    }
  }
}