using System;
using Xunit;

namespace MatchingBrackets
{
    public class BracketMatcherTests
    {
        [Fact]
        public void HasMatch()
        {
            Assert.True(BracketMatcher.HasMatches("{}"));
        }

        [Fact]
        public void OutOfOrder()
        {
            Assert.False(BracketMatcher.HasMatches("}{"));
        }

        [Fact]
        public void MissingClosing()
        {
            Assert.False(BracketMatcher.HasMatches("{{}"));
        }

        [Fact]
        public void EmptyIsValid()
        {
            Assert.True(BracketMatcher.HasMatches(""));
        }

        [Fact]
        public void NoClosing()
        {
            Assert.False(BracketMatcher.HasMatches("{{{{{{{{{{{{"));
        }

        [Fact]
        public void LotsOfMatches()
        {
            Assert.True(BracketMatcher.HasMatches("{{}{}{}{}{}{}{}{}{{}{}{}{}{{}{}{}{}{}}}}"));
        }

        [Fact]
        public void IgnoresOtherCharacters()
        {
            Assert.True(BracketMatcher.HasMatches("{dkflksdfkjdf} kjdkjfksdf {lkjslkjsdf}"));
        }

        [Fact]
        public void NullIsInvalid()
        {
            Assert.Throws<ArgumentNullException>(() => BracketMatcher.HasMatches(null));
        }
    }
}