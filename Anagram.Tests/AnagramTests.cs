using System;
using Xunit;

namespace Anagram.Tests
{
    public class AnagramTests
    {
        [Fact]
        public void AnagramStrStr_CarRace_ReturnsTrue()
        {
            // Arrange
            string str1 = "car";
            string str2 = "race";
            bool isAnagram = false;

            // Act
            isAnagram = Util.Anagram.AnagramStrStr(str1, str2);

            // Assert
            Assert.True(isAnagram);
        }

        [Fact]
        public void AnagramStrStr_NodDone_ReturnsTrue()
        {
            // Arrange
            string str1 = "nod";
            string str2 = "done";
            bool isAnagram = false;

            // Act
            isAnagram = Util.Anagram.AnagramStrStr(str1, str2);

            // Assert
            Assert.True(isAnagram);
        }

        [Fact]
        public void AnagramStrStr_BagGrab_ReturnsFalse()
        {
            // Arrange
            string str1 = "bag";
            string str2 = "grab";
            bool isAnagram = false;

            // Act
            isAnagram = Util.Anagram.AnagramStrStr(str1, str2);

            // Assert
            Assert.False(isAnagram);
        }

        [Fact]
        public void AnagramStrStr_SaltierResidential_ReturnsFalse()
        {
            // Arrange
            string str1 = "saltier";
            string str2 = "residential";
            bool isAnagram = false;

            // Act
            isAnagram = Util.Anagram.AnagramStrStr(str1, str2);

            // Assert
            Assert.False(isAnagram);
        }

        [Fact]
        public void AnagramStrStr_SilentListener_ReturnsTrue()
        {
            // Arrange
            string str1 = "silent";
            string str2 = "listener";
            bool isAnagram = false;

            // Act
            isAnagram = Util.Anagram.AnagramStrStr(str1, str2);

            // Assert
            Assert.True(isAnagram);
        }

        [Fact]
        public void AnagramStrStr_NewYorkTimesMonkeysWrite_ReturnsTrue()
        {
            // Arrange
            string str1 = "New York Times";
            string str2 = "monkeys write";
            bool isAnagram = false;

            // Act
            isAnagram = Util.Anagram.AnagramStrStr(str1, str2);

            // Assert
            Assert.True(isAnagram);
        }

        [Fact]
        public void AnagramStrStr_FortyFiveOverFifty_ReturnsTrue()
        {
            // Arrange
            string str1 = "forty five";
            string str2 = "over fifty";
            bool isAnagram = false;

            // Act
            isAnagram = Util.Anagram.AnagramStrStr(str1, str2);

            // Assert
            Assert.True(isAnagram);
        }

        [Fact]
        public void AnagramStrStr_AGentlemanElegantMan_ReturnsTrue()
        {
            // Arrange
            string str1 = "a gentleman";
            string str2 = "elegant man";
            bool isAnagram = false;

            // Act
            isAnagram = Util.Anagram.AnagramStrStr(str1, str2);

            // Assert
            Assert.True(isAnagram);
        }

    }
}
