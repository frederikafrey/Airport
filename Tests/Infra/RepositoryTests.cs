﻿using System;
using Airport.Aids;
using Airport.Data.Common;
using Airport.Domain.Common;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Airport.Tests.Infra
{
    [TestClass]
    public abstract class RepositoryTests<TRepository, TObject, TData> : BaseTests
   where TRepository : IRepository<TObject>
   where TObject : Entity<TData>
   where TData : UniqueEntityData, new()
    {
        protected TData data;
        protected TRepository obj;
        protected DbContext db;
        protected int count;
        protected DbSet<TData> DbSet;

        public virtual void TestInitialize()
        {
            type = typeof(TRepository);
            data = GetRandom.Object<TData>();
            count = GetRandom.UInt8(20, 40);
            CleanDbSet();
            AddItems();
        }
        protected void TestGetList()
        {
            obj.PageIndex = GetRandom.Int32(2, obj.TotalPages - 1);
            var l = obj.Get().GetAwaiter().GetResult();
            Assert.AreEqual(obj.PageSize, l.Count);
        }

        [TestCleanup]
        public void TestCleanup() => CleanDbSet();

        protected void CleanDbSet()
        {
            foreach (var p in DbSet)
                db.Entry(p).State = EntityState.Deleted;
            db.SaveChanges();
        }

        protected void AddItems()
        {
            for (var i = 0; i < count; i++)
                obj.Add(GetObject(GetRandom.Object<TData>())).GetAwaiter();
        }

        [TestMethod]
        public void IsSealed() => Assert.IsTrue(type.IsSealed);

        [TestMethod]
        public void IsInherited() => Assert.AreEqual(GetBaseType().Name, type?.BaseType?.Name);

        protected abstract Type GetBaseType();

        [TestMethod]
        public void GetTest() => TestGetList();

        [TestMethod]
        public void GetByIdTest() => AddTest();

        [TestMethod]
        public void DeleteTest()
        {
            AddTest();
            var id = GetId(data);
            var expected = obj.Get(id).GetAwaiter().GetResult();
            TestArePropertyValuesEqual(data, expected.Data);
            obj.Delete(id).GetAwaiter();
            expected = obj.Get(id).GetAwaiter().GetResult();
            Assert.IsNull(expected.Data);
        }

        protected abstract string GetId(TData d);

        [TestMethod]
        public void AddTest()
        {
            var id = GetId(data);
            var expected = obj.Get(id).GetAwaiter().GetResult();
            Assert.IsNull(expected.Data);
            obj.Add(GetObject(data)).GetAwaiter();
            expected = obj.Get(id).GetAwaiter().GetResult();
            TestArePropertyValuesEqual(data, expected.Data);
        }

        protected abstract TObject GetObject(TData d);

        protected abstract void SetId(TData d, string id);
    }
}
