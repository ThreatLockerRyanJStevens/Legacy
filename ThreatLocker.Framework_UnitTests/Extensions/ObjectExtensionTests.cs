using ThreatLocker.Framework;
using ThreatLockerCommon;

namespace ThreatLocker.Framework_UnitTests.Extensions
{
    public class ObjectExtensionTests : BaseTest
    {

        #region IsGenericList

        [Fact(DisplayName = "IsGenericList: Returns true")]
        public void IsGenericList_ReturnTrue() => Assert.True(new List<string>() { "sdf" }.IsGenericList());

        [Fact(DisplayName = "IsGenericList: Returns false (array)")]
        public void IsGenericList_ReturnFalseArray() => Assert.False(new string[] { "sdf" }.IsGenericList());

        [Fact(DisplayName = "IsGenericList: Returns false (boolean)")]
        public void IsGenericList_ReturnFalseBool() => Assert.False(true.IsGenericList());

        [Fact(DisplayName = "IsGenericList: Returns false (int)")]
        public void IsGenericList_ReturnFalseInt() => Assert.False(333.IsGenericList());

        [Fact(DisplayName = "IsGenericList: Returns false (object)")]
        public void IsGenericList_ReturnFalseObject() => Assert.False(new { Id = 323 }.IsGenericList());

        [Fact(DisplayName = "IsGenericList: Returns false (null)")]
        public void IsGenericList_ReturnFalseNull() => Assert.False(((object)null).IsGenericList());

        #endregion
    }
}
