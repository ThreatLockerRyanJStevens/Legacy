using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoFixture;
using ThreatLocker.Framework;
using ThreatLocker.Framework.Extensions;

namespace ThreatLocker.Framework_UnitTests.Extensions
{
    public class ConcurrentBagExtensionTests : BaseTest
    {

        #region AddRange<T>

        [Fact(DisplayName ="AddRange<T>: Successfully adds items.")]
        public void AddRange_T_AddsItems()
        {
            var subject = new ConcurrentBag<string>();
            var items = fixture.Create<string[]>();

            subject.AddRange(items);

            Assert.Equal(items.Count(), subject.Count());
        }

        [Fact(DisplayName = "AddRange<T>: Handles null target.")]
        public void AddRange_T_HandleNullTarget()
        {
            ConcurrentBag<string> subject = null;
            var items = fixture.Create<string[]>();
                        
            subject.AddRange(items);
            
        }

        [Fact(DisplayName = "AddRange<T>: Handles null items.")]
        public void AddRange_T_HandleNullItems()
        {
            var subject = new ConcurrentBag<string>();
            string[] items = null;

            subject.AddRange(items);
        }
        #endregion
    }
}
