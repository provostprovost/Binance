﻿using System;
using Binance.Account;
using Xunit;

namespace Binance.Tests.Account
{
    public class AccountCommissionsTest
    {
        [Fact]
        public void Throws()
        {
            Assert.Throws<ArgumentException>("maker", () => new AccountCommissions(-10, 10, 10, 10));
            Assert.Throws<ArgumentException>("maker", () => new AccountCommissions(110, 10, 10, 10));

            Assert.Throws<ArgumentException>("taker", () => new AccountCommissions(10, -10, 10, 10));
            Assert.Throws<ArgumentException>("taker", () => new AccountCommissions(10, 110, 10, 10));

            Assert.Throws<ArgumentException>("buyer", () => new AccountCommissions(10, 10, -10, 10));
            Assert.Throws<ArgumentException>("buyer", () => new AccountCommissions(10, 10, 110, 10));

            Assert.Throws<ArgumentException>("seller", () => new AccountCommissions(10, 10, 10, -10));
            Assert.Throws<ArgumentException>("seller", () => new AccountCommissions(10, 10, 10, 110));
        }

        [Fact]
        public void Properties()
        {
            var maker = 10;
            var taker = 20;
            var buyer = 30;
            var seller = 40;

            var commissions = new AccountCommissions(maker, taker, buyer, seller);

            Assert.Equal(maker, commissions.Maker);
            Assert.Equal(taker, commissions.Taker);
            Assert.Equal(buyer, commissions.Buyer);
            Assert.Equal(seller, commissions.Seller);
        }
    }
}
