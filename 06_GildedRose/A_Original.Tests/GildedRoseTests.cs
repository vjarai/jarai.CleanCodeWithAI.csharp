using System.Collections.Generic;
using Xunit;

namespace GildedRoseKata.Original.Tests
{
    public class GildedRoseTests
    {
        [Fact]
        public void AllItems_HaveSellInAndQuality_AreLoweredEachDay()
        {
            var items = new List<Item> { new Item { Name = "foo", SellIn = 10, Quality = 20 } };
            var app = new GildedRose(items);

            app.UpdateQuality();

            Assert.Equal(9, items[0].SellIn);
            Assert.Equal(19, items[0].Quality);
        }

        [Fact]
        public void QualityDegradesTwiceAsFast_AfterSellByDate()
        {
            var items = new List<Item> { new Item { Name = "foo", SellIn = 0, Quality = 10 } };
            var app = new GildedRose(items);

            app.UpdateQuality();

            Assert.Equal(-1, items[0].SellIn);
            Assert.Equal(8, items[0].Quality);
        }

        [Fact]
        public void QualityIsNeverNegative()
        {
            var items = new List<Item> { new Item { Name = "foo", SellIn = 5, Quality = 0 } };
            var app = new GildedRose(items);

            app.UpdateQuality();

            Assert.Equal(0, items[0].Quality);
        }

        [Fact]
        public void AgedBrie_IncreasesInQuality()
        {
            var items = new List<Item> { new Item { Name = "Aged Brie", SellIn = 2, Quality = 0 } };
            var app = new GildedRose(items);

            app.UpdateQuality();

            Assert.Equal(1, items[0].Quality);
        }

        [Fact]
        public void QualityIsNeverMoreThan50()
        {
            var items = new List<Item> { new Item { Name = "Aged Brie", SellIn = 2, Quality = 50 } };
            var app = new GildedRose(items);

            app.UpdateQuality();

            Assert.Equal(50, items[0].Quality);
        }

        [Fact]
        public void Sulfuras_NeverSoldOrDecreasesInQuality()
        {
            var items = new List<Item> { new Item { Name = "Sulfuras, Hand of Ragnaros", SellIn = 0, Quality = 80 } };
            var app = new GildedRose(items);

            app.UpdateQuality();

            Assert.Equal(0, items[0].SellIn);
            Assert.Equal(80, items[0].Quality);
        }

        [Theory]
        [InlineData(15, 20, 21)]
        [InlineData(10, 20, 22)]
        [InlineData(5, 20, 23)]
        public void BackstagePasses_IncreaseQualityAndDropToZeroAfterConcert(int sellIn, int quality, int expectedQuality)
        {
            var items = new List<Item> { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = sellIn, Quality = quality } };
            var app = new GildedRose(items);

            app.UpdateQuality();

            Assert.Equal(expectedQuality, items[0].Quality);
        }

        [Fact]
        public void BackstagePasses_QualityDropsToZeroAfterConcert()
        {
            var items = new List<Item> { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 0, Quality = 20 } };
            var app = new GildedRose(items);

            app.UpdateQuality();

            Assert.Equal(0, items[0].Quality);
        }

        [Fact]
        public void ConjuredItems_DegradeTwiceAsFast()
        {
            var items = new List<Item> { new Item { Name = "Conjured Mana Cake", SellIn = 3, Quality = 6 } };
            var app = new GildedRose(items);

            app.UpdateQuality();

            Assert.Equal(2, items[0].Quality);
        }
    }
}