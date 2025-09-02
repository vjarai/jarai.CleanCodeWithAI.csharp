using Xunit;

/*
 
namespace GildedRoseKata.TestDriven.Tests
{
    public class GildedRoseTests2
    {
        [Fact]
        public void NormalItem_QualityAndSellIn_DecreaseByOne()
        {
            var items = new List<Item> { new Item { Name = "Normal Item", SellIn = 10, Quality = 20 } };
            var app = new GildedRose(items);

            app.UpdateQuality();

            Assert.Equal(9, items[0].SellIn);
            Assert.Equal(19, items[0].Quality);
        }

        [Fact]
        public void NormalItem_QualityDegradesTwiceAsFast_AfterSellByDate()
        {
            var items = new List<Item> { new Item { Name = "Normal Item", SellIn = 0, Quality = 20 } };
            var app = new GildedRose(items);

            app.UpdateQuality();

            Assert.Equal(-1, items[0].SellIn);
            Assert.Equal(18, items[0].Quality);
        }

        [Fact]
        public void Quality_NeverNegative()
        {
            var items = new List<Item> { new Item { Name = "Normal Item", SellIn = 5, Quality = 0 } };
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
            Assert.Equal(1, items[0].SellIn);
        }

        [Fact]
        public void AgedBrie_QualityNeverExceeds50()
        {
            var items = new List<Item> { new Item { Name = "Aged Brie", SellIn = 2, Quality = 50 } };
            var app = new GildedRose(items);

            app.UpdateQuality();

            Assert.Equal(50, items[0].Quality);
        }

        [Fact]
        public void Sulfuras_NeverDecreasesInQualityOrSellIn()
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
        public void BackstagePasses_IncreaseInQuality(int sellIn, int quality, int expectedQuality)
        {
            var items = new List<Item> { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = sellIn, Quality = quality } };
            var app = new GildedRose(items);

            app.UpdateQuality();

            Assert.Equal(expectedQuality, items[0].Quality);
        }

        [Fact]
        public void BackstagePasses_QualityDropsToZero_AfterConcert()
        {
            var items = new List<Item> { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 0, Quality = 20 } };
            var app = new GildedRose(items);

            app.UpdateQuality();

            Assert.Equal(-1, items[0].SellIn);
            Assert.Equal(0, items[0].Quality);
        }

        [Fact]
        public void BackstagePasses_QualityNeverExceeds50()
        {
            var items = new List<Item> { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 5, Quality = 49 } };
            var app = new GildedRose(items);

            app.UpdateQuality();

            Assert.Equal(50, items[0].Quality);
        }

        [Fact]
        public void ConjuredItems_DegradeTwiceAsFast_BeforeSellByDate()
        {
            var items = new List<Item> { new Item { Name = "Conjured Mana Cake", SellIn = 3, Quality = 6 } };
            var app = new GildedRose(items);

            app.UpdateQuality();

            // Should degrade by 2
            Assert.Equal(4, items[0].Quality);
            Assert.Equal(2, items[0].SellIn);
        }

        [Fact]
        public void ConjuredItems_DegradeTwiceAsFast_AfterSellByDate()
        {
            var items = new List<Item> { new Item { Name = "Conjured Mana Cake", SellIn = 0, Quality = 6 } };
            var app = new GildedRose(items);

            app.UpdateQuality();

            // Should degrade by 4
            Assert.Equal(2, items[0].Quality);
            Assert.Equal(-1, items[0].SellIn);
        }

        [Fact]
        public void ConjuredItems_QualityNeverNegative()
        {
            var items = new List<Item> { new Item { Name = "Conjured Mana Cake", SellIn = 0, Quality = 3 } };
            var app = new GildedRose(items);

            app.UpdateQuality();

            Assert.Equal(0, items[0].Quality);
        }
    }
}

*/