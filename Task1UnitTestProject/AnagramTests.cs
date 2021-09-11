using Xunit;
using AnagramProject;

namespace Task1UnitTestProject
{
    public class AnagramTests
    {
        private readonly Anagram _sut;

        public AnagramTests()
        {
            _sut = new Anagram();
        }

        [Theory]
        [InlineData("  d1cba    hgf!e", "  a1bcd    efg!h")]
        [InlineData("", null)]
        [InlineData("        ", "        ")]
        [InlineData("","")]
        [InlineData("Hello World!", "olleH dlroW!")]
        [InlineData("你好，世界!", "界世，好你!")]
        [InlineData("¡Hola Mundo!", "¡aloH odnuM!")]
        [InlineData("こんにちは世界!", "界世はちにんこ!")]
        [InlineData("0,1,2,3,4,5,6,7,8,9,10", "0,1,2,3,4,5,6,7,8,9,10")]
        [InlineData("Hello 你好 ¡Hola こんにち", "olleH 好你 ¡aloH ちにんこ")]
        public void Reverse_ModifiesTestString(string expected, string sourse)
        {
            Assert.Equal(expected, _sut.Reverse(sourse));
        }
    }
}
