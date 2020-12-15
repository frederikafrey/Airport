using System;
using Airport.Aids;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Airport.Tests.Aids
{

    [TestClass]
    public class SafeTests : BaseTests
    {
        private LogTests.TestLogBook logBook;

        [TestInitialize]
        public void TestInitialize()
        {
            type = typeof(Safe);
            logBook = new LogTests.TestLogBook();
            Log.logBook = logBook;
        }

        [TestCleanup]
        public void TestCleanup()
        {
            Log.logBook = null;
        }

        [TestMethod] public void RunTest() { }

        [TestMethod]
        public void RunFunctionTest()
        {
            var actual = Safe.Run(() => "Result", "Error");
            Assert.AreEqual("Result", actual);
            Assert.IsNull(logBook.LoggedException);
        }

        [TestMethod]
        public void RunFailingFunctionTest()
        {
            var actual = Safe.Run(() => throw new NotImplementedException(), "Error");
            Assert.AreEqual("Error", actual);
            var exception = logBook.LoggedException;
            Assert.IsNotNull(exception);
            Assert.IsInstanceOfType(exception, typeof(NotImplementedException));
        }

        [TestMethod]
        public void RunMethodTest()
        {
            var newLogBook = new LogTests.TestLogBook();
            Safe.Run(() => Log.logBook = newLogBook);
            Assert.IsNull(newLogBook.LoggedException);
        }

        [TestMethod]
        public void RunFailingMethodTest()
        {
            Safe.Run(() => throw new ArgumentOutOfRangeException());
            var exception = logBook.LoggedException;
            Assert.IsNotNull(exception);
            Assert.IsInstanceOfType(exception, typeof(ArgumentOutOfRangeException));
        }

        [TestMethod]
        public void RunInsideRunTest()
        {
            Safe.Run(() =>
            {
                Safe.Run(() => throw new ArgumentException());

                throw new AggregateException();
            });
            Assert.AreEqual(2, logBook.LoggedExceptions.Count);
            Assert.IsInstanceOfType(logBook.LoggedExceptions[0], typeof(ArgumentException));
            Assert.IsInstanceOfType(logBook.LoggedExceptions[1], typeof(AggregateException));
        }

        [TestMethod]
        public void RunInsideRunLockedTest()
        {
            Safe.Run(() =>
            {
                Safe.Run(() => throw new ArgumentException(), true);

                throw new AggregateException();
            }, true);
            Assert.AreEqual(2, logBook.LoggedExceptions.Count);
            Assert.IsInstanceOfType(logBook.LoggedExceptions[0], typeof(ArgumentException));
            Assert.IsInstanceOfType(logBook.LoggedExceptions[1], typeof(AggregateException));
        }
    }
}
