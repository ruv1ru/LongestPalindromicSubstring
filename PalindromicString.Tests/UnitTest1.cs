using NUnit.Framework;
using palindromicstring.functions;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void InputStingWithSingleChar_ShouldReturnSameInputString()
        {
            string input = "A";

            string output = Program.GetLongestPalindromicSubstring(input);

            Assert.AreEqual(output, input);
        }

        [Test]
        public void InputStingWithOnlyPalindrom_ShouldReturnSameInputString()
        {
            string input = "DAD";

            string output = Program.GetLongestPalindromicSubstring(input);

            Assert.AreEqual(output, input);
        }

        
        [Test]
        public void InputStingStatingWithPalindromPlusCharsAtTheEnd_ShouldReturnPalindromWithoutEndingChars()
        {
            string input = "DADY";

            string output = Program.GetLongestPalindromicSubstring(input);

            Assert.AreEqual("DAD", output);
        }

        [Test]
        public void InputStingWithPalindromPlusCharsAtTheStart_ShouldReturnPalindromWithoutStartingChars()
        {
            string input = "QDAD";

            string output = Program.GetLongestPalindromicSubstring(input);

            Assert.AreEqual("DAD", output);
        }
        
        [Test]
        public void InputStingWithTwoPalindromsWithLongestAtTheEnd_ShouldReturnLongestPalindrom()
        {
            string input = "DADHANNAH";

            string output = Program.GetLongestPalindromicSubstring(input);

            Assert.AreEqual("HANNAH", output);
        }

        
        [Test]
        public void InputStingWithTwoPalindromsWithLongestAtTheStart_ShouldReturnLongestPalindrom()
        {
            string input = "HANNAHDAD";

            string output = Program.GetLongestPalindromicSubstring(input);

            Assert.AreEqual("HANNAH", output);
        }
        
        [Test]
        public void InputStingWithMultiplePalindromsWithLongestInMiddle_ShouldReturnLongestPalindrom()
        {
            string input = "BOBHANNAHDAD";

            string output = Program.GetLongestPalindromicSubstring(input);

            Assert.AreEqual("HANNAH", output);
        }

        
        [Test]
        public void InputStingWithSinglePalindromsWithLongestInMiddle_ShouldReturnLongestPalindrom()
        {
            string input = "SFHANNAHJS";

            string output = Program.GetLongestPalindromicSubstring(input);

            Assert.AreEqual("HANNAH", output);
        }
        
        [Test]
        public void InputWithPalindromsWithLongestInLeftUnevenPosition_ShouldReturnLongestPalindrom()
        {
            string input = "SFHANNAHJSSSSS";

            string output = Program.GetLongestPalindromicSubstring(input);

            Assert.AreEqual("HANNAH", output);
        }
        
        
        [Test]
        public void InputWithPalindromsWithLongestInRightUnevenPosition_ShouldReturnLongestPalindrom()
        {
            string input = "SDDDDDFHANNAHJSS";

            string output = Program.GetLongestPalindromicSubstring(input);

            Assert.AreEqual("HANNAH", output);
        }
    }
}