using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using Ims.Core;
using Ims.DataAccess;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Ims.Tests.Core.Extensions
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ConfirmSingleInt16sCanBeSubmittedAndReturnedAsExpected()
        {
            RunTest(new[] { (short)1 });
            RunTest(new[] { (short)0 });
            RunTest(new[] { (short)-1 });
            RunTest(new[] { short.MaxValue });
            RunTest(new[] { short.MinValue });
        }

        [TestMethod]
        public void ConfirmEmptyInt16sCanBeSubmittedAndReturnedAsExpected()
        {
            RunTest(new short[] { });
        }

        [TestMethod]
        public void ConfirmNullInt16sCanBeSubmittedAndReturnedAsExpected()
        {
            RunTest((short[])null);
        }

        [TestMethod]
        public void ConfirmRangeOfInt16sCanBeSubmittedAndReturnedAsExpected()
        {
            RunTest(new[] { (short)301, (short)501, (short)999, short.MaxValue, short.MinValue, (short)0, (short)-2, (short)20000, (short)20001, (short)20002 });
        }

        private void RunTest(short[] input)
        {
            using (TransactionScope transactionScope = new TransactionScope())
            {
                List<short> output = transactionScope.ExecuteEnumerable<short>("SELECT * FROM dbo.ConvertBinaryToSmallInt(@IntValues)", CommandType.Text, new Parameter("IntValues", SqlDbType.VarBinary, input == null ? DBNull.Value : input.ToByteArray() as object)).ToList();

                if (input == null) input = new Int16[] { };

                Assert.AreEqual(input.Length, output.Count, "Check row counts match");

                for (short index = 0; index < input.Length; index++)
                    Assert.AreEqual(input[index], output[index], "Check values (index={0})", index);
            }

        }

        [TestMethod]
        public void ConfirmSingleInt32sCanBeSubmittedAndReturnedAsExpected()
        {
            RunTest(new[] { 1 });
            RunTest(new[] { 0 });
            RunTest(new[] { -1 });
            RunTest(new[] { int.MaxValue });
            RunTest(new[] { int.MinValue });
        }

        [TestMethod]
        public void ConfirmEmptyInt32sCanBeSubmittedAndReturnedAsExpected()
        {
            RunTest(new int[] { });
        }

        [TestMethod]
        public void ConfirmNullInt32sCanBeSubmittedAndReturnedAsExpected()
        {
            RunTest((int[])null);
        }

        [TestMethod]
        public void ConfirmRangeOfInt32sCanBeSubmittedAndReturnedAsExpected()
        {
            RunTest(new[] { 301, 501, 999, int.MaxValue, int.MinValue, 0, -2, 2000000, 2000001, 2000002 });
        }

        private void RunTest(int[] input)
        {
            using (TransactionScope transactionScope = new TransactionScope())
            {
                List<int> output = transactionScope.ExecuteEnumerable<int>("SELECT * FROM dbo.ConvertBinaryToInt(@IntValues)", CommandType.Text, new Parameter("IntValues", SqlDbType.VarBinary, input == null ? DBNull.Value : input.ToByteArray() as object)).ToList();

                if (input == null) input = new Int32[] { };

                Assert.AreEqual(input.Length, output.Count, "Check row counts match");

                for (int index = 0; index < input.Length; index++)
                    Assert.AreEqual(input[index], output[index], "Check values (index={0})", index);
            }

        }
    }
}
