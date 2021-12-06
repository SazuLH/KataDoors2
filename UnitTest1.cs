using Microsoft.VisualStudio.TestTools.UnitTesting;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;
using DoorProgram;
using System;
using Xunit;

namespace DoorTest
{
    [TestClass]
    public class UnitTestDoor
    {
        
        [Fact]
        public void OpenDoor()
        {
            Door obj = new Door(true, true);
            bool result = Door.Open();
            Assert.IsTrue(result);
        }
        [Fact]
        public void ClosedDoor()
        {
            Door obj = new Door(true, true);
            bool result = Door.Close();
            Assert.IsTrue(result);
        }
        [Fact]
        public void OpenAndLockedDoor()
        {
            Exception exception = new Exception();
            bool result = Door.Open(true);
            Assert.AreEqual(exception, result);
        }
        [Fact]
        public void OpenAndUnlockedDoor()
        {
            Guid key = new Guid();
            object door = Door.Open(true);
            object result = Door.OpenAndUnlocked(key);
            Assert.AreEqual(door, result);
        }
        [Fact]
        public void ClosedAndLockedDoor()
        {
            Guid key = new Guid();
            object expected = Door.Closed();
            object result = Door.ClosedAndUnlocked(key);
            Assert.AreEqual(expected, result);
        }
        [Fact]
        public void ClosedAndUnlockedDoor()
        {
            Guid key = new Guid();
            object expected = true;
            object result = Door.ClosedAndLocked(key);
            Assert.AreEqual(expected, result);
        }

    }
}
