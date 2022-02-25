using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery.Models;

namespace Pierres.TestTools
{
  [TestClass]
  public class PastryTests
  {
    public void PastryConstructor_CreatesInstanceOfPastry_Pastry()
    {
      Pastry fivePastries = new Pastry(5);
      Assert.AreEqual(typeof(Pastry), fivePastries.GetType());
    }
  }
}