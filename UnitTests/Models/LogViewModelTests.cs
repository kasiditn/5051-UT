﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HW1c.Models;

namespace UnitTests.Models
{
    [TestClass]
    public class LogViewModelTests
    {
        [TestMethod]
        public void LogViewModel_instantiate_Default_Should_Pass()
        {
            //Arrange


            //Act
            var resilt = new LogViewModel();

            //Assert
            Assert.IsNotNull(result);
        }
    }
}
