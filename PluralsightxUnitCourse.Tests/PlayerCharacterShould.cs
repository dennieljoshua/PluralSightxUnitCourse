using System;
using Xunit;

namespace PluralsightxUnitCourse.Tests
{
    public class PlayerCharacterShould
    {
        [Fact]
        public void BeInexperiencedWhenNew()
        {
            PlayerCharacter sut = new PlayerCharacter();
        }
    }
}
