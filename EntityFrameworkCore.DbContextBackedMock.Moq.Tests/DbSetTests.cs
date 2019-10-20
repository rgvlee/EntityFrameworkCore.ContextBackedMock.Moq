﻿using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NUnit.Framework;

namespace EntityFrameworkCore.DbContextBackedMock.Moq.Tests
{
    [TestFixture]
    public class DbSetTests
    {
        [Test]
        public void AddAndPersist_Entity_Persists()
        {
            var testEntity1 = new TestEntity1();

            var options = new DbContextOptionsBuilder<TestContext>().UseInMemoryDatabase(Guid.NewGuid().ToString()).Options;
            var dbContext = new TestContext(options);
            var dbSet = dbContext.Set<TestEntity1>();

            dbSet.Add(testEntity1);
            dbContext.SaveChanges();

            Assert.Multiple(() =>
            {
                Assert.IsTrue(dbContext.Set<TestEntity1>().Any());
                Assert.IsTrue(dbContext.TestEntities.Any());
            });
        }

        [Test]
        public async Task AddAndPersistAsync_Entity_Persists()
        {
            var testEntity1 = new TestEntity1();

            var options = new DbContextOptionsBuilder<TestContext>().UseInMemoryDatabase(Guid.NewGuid().ToString()).Options;
            var dbContext = new TestContext(options);
            var dbSet = dbContext.Set<TestEntity1>();

            await dbSet.AddAsync(testEntity1);
            await dbContext.SaveChangesAsync();

            Assert.Multiple(() =>
            {
                Assert.IsTrue(dbContext.Set<TestEntity1>().Any());
                Assert.IsTrue(dbContext.TestEntities.Any());
            });
        }
    }
}