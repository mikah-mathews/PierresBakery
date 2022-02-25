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

    [TestMethod]
    public void GetLoafPrice_Returns5for1_Int()
    {
      int expectedNumber = 5;
      int loafPrice = Bread.GetLoafPrice(1);
      Assert.AreEqual(loafPrice, expectedNumber); 
    }
  }
}