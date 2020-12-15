using System;
using System.Diagnostics;
using System.Reflection;
using Airport.Aids;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Airport.Tests
{
    public abstract class BaseClassTests<TClass, TBaseClass> : BaseTests
    {
        protected TClass obj;

        [TestInitialize]
        public virtual void TestInitialize() => type = typeof(TClass);

        [TestMethod]
        public void IsInheritedTest() => Assert.AreEqual(typeof(TBaseClass), type.BaseType);

        protected static void IsNullableProperty(object o, string name, Type type)
        {
            var property = o.GetType().GetProperty(name);
            Assert.IsNotNull(property);
            Assert.AreEqual(type, property.PropertyType);
            Assert.IsTrue(property.CanWrite);
            Assert.IsTrue(property.CanRead);
            property.SetValue(o, null);
            var actual = property.GetValue(o);
            Assert.AreEqual(null, actual);
        }

        protected static void IsNullableProperty<T>(Func<T> get, Action<T> set)
        {
            IsProperty(get, set);
            set(default);
            Assert.IsNull(get());
        }

        protected static void IsProperty<T>(Func<T> get, Action<T> set)
        {
            var d = (T)GetRandom.Value(typeof(T));

            while (true)
            {
                if (!d.Equals(get())) break;
                d = (T)GetRandom.Value(typeof(T));
            }

            Assert.AreNotEqual(d, get());
            set(d);
            Assert.AreEqual(d, get());
        }

        protected static void IsProperty(Func<bool> get, Action<bool> set)
        {
            var d = !get();
            Assert.AreNotEqual(d, get());
            set(d);
            Assert.AreEqual(d, get());
        }

        protected static void IsProperty(object o, string name, Type t)
        {
            var p = IsReadWriteProperty(o, name, t);
            CanSetValue(o, p, GetRandom.Value(t));
        }
        protected static PropertyInfo IsReadWriteProperty(object o, string name, Type t)
        {
            var p = o.GetType().GetProperty(name);
            Assert.IsNotNull(p);
            Assert.AreEqual(t, p.PropertyType);
            Assert.IsTrue(p.CanWrite);
            Assert.IsTrue(p.CanRead);

            return p;
        }
        protected void IsProperty<TType>()
        {
            var n = GetPropertyName();
            IsProperty(obj, n, typeof(TType));
        }
        protected string GetPropertyName(int stackFrameIdx = 2)
        {
            var stack = new StackTrace();
            var n = stack.GetFrame(stackFrameIdx)?.GetMethod()?.Name;

            return n?.Replace("Test", string.Empty);
        }
        private static void CanSetValue(object o, PropertyInfo p, object v)
        {
            p.SetValue(o, v);
            Assert.AreEqual(v, p.GetValue(o));
        }
        protected static void IsReadOnlyProperty(object o, string name, object expected)
        {
            var property = o.GetType().GetProperty(name);
            Assert.IsNotNull(property);
            Assert.IsFalse(property.CanWrite);
            Assert.IsTrue(property.CanRead);
            var actual = property.GetValue(o);
            Assert.AreEqual(expected, actual);
        }
    }
}