using Microsoft.VisualStudio.TestTools.UnitTesting;
using UWP.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace UWP.Tests
{
    [TestClass]
    public class ObservableObjectTests
    {
        [TestMethod]
        public void OnPropertyChangedTest()
        {
            var obj = new StubObservableObject();

            bool raised = false;

            obj.PropertyChanged += (sender, args) =>
            {
                Assert.IsTrue(args.PropertyName == "ChangedProperty");
                raised = true;
            };

            obj.ChangedProperty = "Some value";

            if (!raised) Assert.Fail("PropertyChanged was never invoked");
        }
    }

    class StubObservableObject : ObservableObject
    {
        private string changedProperty;

        public string ChangedProperty
        {
            get { return changedProperty; }
            set
            {
                changedProperty = value;
                NotifyPropertyChanged();
            }
        }
    }
}
