﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HW1c.Models;
using System.Collections.Generic;

namespace UnitTests.Models
{
    [TestClass]
    public class ReportViewModelTests
    {
        [TestMethod]
        public void ReportViewModel_Instantiate_Default_Should_Pass()
        {
            //Arrange

            //Action
            var result = new ReportViewModel();

            //Assert
            Assert.IsNotNull(result);
        }
        [TestMethod]
        public void ReportViewModel_NumberOfUsers_Get_Default_Should_Pass()
        {
            // Arrange
            var myTest = new ReportViewModel();

            // Act
            var result = myTest.NumberOfUsers;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void ReportViewModel_NumberOfUsers_Set_Default_Should_Pass()
        {
            // Arrange
            var myTest = new ReportViewModel();
            var numUsers = 20;

            // Act
            myTest.NumberOfUsers = numUsers;
            var result = myTest.NumberOfUsers;

            // Assert
            Assert.AreEqual(numUsers, result);
        }

        [TestMethod]
        public void ReportViewModel_LogViewModel_Get_Default_Should_Pass()
        {
            // Arrange
            var myTest = new ReportViewModel();

            // Act
            var result = myTest.LogViewModel;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void ReportViewModel_LogViewModel_Set_Default_Should_Pass()
        {
            // Arrange
            var myTest = new ReportViewModel();
            var myLogView = new LogViewModel();
            myLogView.LogList.Add(new LogModel { PhoneID = "Phone" });

            // Act
            myTest.LogViewModel = myLogView;
            var result = myTest.LogViewModel.LogList;

            // Assert
            Assert.AreEqual("Phone", result[0].PhoneID);
        }

    }
}
