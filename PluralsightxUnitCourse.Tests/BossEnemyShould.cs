﻿using Xunit;

namespace PluralsightxUnitCourse.Tests
{
    [Trait("Category", "Enemy")]
    public class BossEnemyShould
    {
        [Fact]
        public void HaveCorrectPower()
        {
            BossEnemy sut = new BossEnemy();

            Assert.Equal(166.667, sut.TotalSpecialAttackPower, 3);
        }
    }
}
