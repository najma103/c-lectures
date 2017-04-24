using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDDLecture;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDLecture.Tests
{
    [TestClass()]
    public class KataPrimeFactorsTests
    {
        [TestMethod]
        public void FactorsTest()
        {
            KataPrimeFactors testObject01 = new KataPrimeFactors();
            CollectionAssert.AreEquivalent(new int[] { 2 }, testObject01.Factorize(2));
            CollectionAssert.AreEquivalent(new int[] { 7 }, testObject01.Factorize(7));
            CollectionAssert.AreEquivalent(new int[] { 2, 3 }, testObject01.Factorize(6));
            CollectionAssert.AreEquivalent(new int[] { 3, 13, 3 }, testObject01.Factorize(117));
            CollectionAssert.AreEquivalent(new int[] { }, testObject01.Factorize(1));
        }

    }
}