using System.Collections.Generic;
using Xunit;

namespace GildedRoseKata.Original.Tests
{
    public class GildedRoseTests
    {
        [Fact]
        public void GivenNormalItemBeforeSellByDate_WhenQualityIsUpdated_ThenSellInAndQualityDecreaseByOne()
        {
            var items = new List<Item> { new Item { Name = "foo", SellIn = 10, Quality = 20 } };
            var app = new GildedRose(items);

            app.UpdateQuality();

            Assert.Equal(9, items[0].SellIn);
            Assert.Equal(19, items[0].Quality);
        }

        [Fact]
        public void GivenNormalItemOnSellByDate_WhenQualityIsUpdated_ThenSellInDecreasesByOneAndQualityByTwo()
        {
            var items = new List<Item> { new Item { Name = "foo", SellIn = 0, Quality = 10 } };
            var app = new GildedRose(items);

            app.UpdateQuality();

            Assert.Equal(-1, items[0].SellIn);
            Assert.Equal(8, items[0].Quality);
        }

        [Fact]
        public void GivenNormalItemWithZeroQuality_WhenQualityIsUpdated_ThenQualityRemainsZero()
        {
            var items = new List<Item> { new Item { Name = "foo", SellIn = 5, Quality = 0 } };
            var app = new GildedRose(items);

            app.UpdateQuality();

            Assert.Equal(0, items[0].Quality);
        }

        [Fact]
        public void GivenAgedBrieBeforeSellByDate_WhenQualityIsUpdated_ThenQualityIncreasesByOne()
        {
            var items = new List<Item> { new Item { Name = "Aged Brie", SellIn = 2, Quality = 0 } };
            var app = new GildedRose(items);

            app.UpdateQuality();

            Assert.Equal(1, items[0].Quality);
        }

        [Fact]
        public void GivenAgedBrieAtMaximumQuality_WhenQualityIsUpdated_ThenQualityRemainsFifty()
        {
            var items = new List<Item> { new Item { Name = "Aged Brie", SellIn = 2, Quality = 50 } };
            var app = new GildedRose(items);

            app.UpdateQuality();

            Assert.Equal(50, items[0].Quality);
        }

        [Fact]
        public void GivenSulfuras_WhenQualityIsUpdated_ThenSellInAndQualityRemainUnchanged()
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
        public void GivenBackstagePassBeforeConcert_WhenQualityIsUpdated_ThenQualityIncreasesAccordingToSellIn(int sellIn, int quality, int expectedQuality)
        {
            var items = new List<Item> { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = sellIn, Quality = quality } };
            var app = new GildedRose(items);

            app.UpdateQuality();

            Assert.Equal(expectedQuality, items[0].Quality);
        }

        [Fact]
        public void GivenBackstagePassOnConcertDate_WhenQualityIsUpdated_ThenQualityDropsToZero()
        {
            var items = new List<Item> { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 0, Quality = 20 } };
            var app = new GildedRose(items);

            app.UpdateQuality();

            Assert.Equal(0, items[0].Quality);
        }

        
    }
}