using Microsoft.VisualStudio.TestTools.UnitTesting;
using Palindromes;

namespace Palindromes.Tests
{
  [TestClass]
  public class FlipItAndReverseIt
  {
    [TestMethod]
    public void ReverseString_UserInputReversed_True()
    {
      // FlipItAndReverseIt testLeapYear = new LeapYear();
      Assert.AreEqual(true, testLeapYear.IsLeapYear("water"));
    }