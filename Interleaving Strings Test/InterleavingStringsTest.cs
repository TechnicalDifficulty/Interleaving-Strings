using Interleaving_Strings;
using System;

using Xunit;

namespace Interleaving_Strings_Test
{
    public class InterleavingStringsTest
    {
        [Fact]

        public void IsPossibleInterleave_Test()
        {
            //Arrange
            String A = "xxy", B = "xxz", C = "xxxxzy";
            var interleaveObj = new InterleavingStrings();
            //Act
            var result = interleaveObj.IsPossibleInterleave(A, B, C);
            //Assert
            Assert.True(result);
        }

        [Fact]
        public void IsLowerCase_Test()
        {
            //Arrange
            String A = "xxy", B = "xxz", C = "xxxxzy";
            var interleaveObj = new InterleavingStrings();
            //Act
            var result = interleaveObj.IsLowerCaseStrings(A, B, C);
            //Assert
            Assert.True(result);
        }

        [Fact]
        public void IsIsLengthConstraingsMatch_Test()
        {
            //Arrange
            String A = "xxy", B = "xxz", C = "xxxxzy";
            var interleaveObj = new InterleavingStrings();
            //Act
            var result = interleaveObj.IsLengthConstraingsMatch(A, B, C);
            //Assert
            Assert.True(result);
        }
    }
}
