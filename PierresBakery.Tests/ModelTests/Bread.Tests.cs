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

    [TestMethod]
    public void GetLoafPrice_Returns10for3_Int()
    {
      int expectedNumber = 10;
      int loafPrice = Bread.GetLoafPrice(3);
      Assert.AreEqual(loafPrice, expectedNumber); 
    }

    [TestMethod]
    public void GetLoafPrice_Returns20for6_Int()
    {
      int expectedNumber = 20;
      int loafPrice = Bread.GetLoafPrice(6);
      Assert.AreEqual(loafPrice, expectedNumber); 
    }

    [TestMethod]
    public void GetLoafPrice_Returns25for7_Int()
    {
      int expectedNumber = 25;
      int loafPrice = Bread.GetLoafPrice(7);
      Assert.AreEqual(loafPrice, expectedNumber); 
    }

  }
}