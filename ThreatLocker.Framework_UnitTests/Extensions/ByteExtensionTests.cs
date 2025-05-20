using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoFixture;
using ThreatLocker.Framework;
using ThreatLocker.Framework.Extensions;
namespace ThreatLocker.Framework_UnitTests.Extensions
{
    public  class ByteExtensionTests : BaseTest
    {

        private byte[] data = Encoding.UTF8.GetBytes("Sample test");

        #region ToSafeByteArray
        [Fact(DisplayName = "ToSafeByteArray: From Same")]
        public void ToSafeByteArray_FromSame()
        {
            var expected = fixture.Create<byte[]>();
            Assert.Equal(expected, expected.ToSafeByteArray());
        }

        [Fact(DisplayName = "ToSafeByteArray: Returns Not Null.")]
        public void ToSafeByteArray_ReturnsNotNull()
        {
            var subject = data;
            Assert.NotNull(subject.ToSafeByteArray());
        }

        [Fact(DisplayName = "ToSafeByteArray: Returns Null.")]
        public void ToSafeByteArray_ReturnsNull()
        {
            var subject = string.Empty;
            Assert.Null(subject.ToSafeByteArray());
        }



        [Fact(DisplayName = "ToSafeByteArray: Returns valid array.")]
        public void ToSafeByteArray_ReturnsFalse()
        {
            var subject = data;
            var expected = data;
            var result = subject.ToSafeByteArray();
            Assert.Equal(expected, result);
        }

        #endregion

        #region ByteToBase64String

        [Fact(DisplayName = "ByteToBase64String: Returns valid string.")]
        public void ByteToBase64String_ReturnsValidString()
        {
            var source = "Tesing byte to base 64 string";
            var subject = Encoding.UTF8.GetBytes(source);
            Assert.Equal("VGVzaW5nIGJ5dGUgdG8gYmFzZSA2NCBzdHJpbmc=", subject.ByteToBase64String());
        }

        [Fact(DisplayName = "ByteToBase64String: Returns empty string.")]
        public void ByteToBase64String_ReturnsEmptyString()
        {
            var subject = new byte [0];
            Assert.Equal(string.Empty, subject.ByteToBase64String());
        }

        [Fact(DisplayName = "ByteToBase64String: Returns null.")]
        public void ByteToBase64String_ReturnsFalse()
        {
            var subject = (byte[])null;
            Assert.Null(subject.ByteToBase64String());
        }
        #endregion
    }
}
