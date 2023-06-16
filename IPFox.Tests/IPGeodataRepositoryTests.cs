namespace IPFox.Tests
{
    public class IPGeodataRepositoryTests
    {
        [Test]
        public async Task TestGetIPLocation_USAddr()
        {
            var segment = await IPGeodataRepository.GetIPLocationAsync("8.8.8.8");
            Assert.IsNotNull(segment);
            Assert.That(segment.Detail.Country, Is.EqualTo("����"));
            Assert.That(segment.Detail.DataProvider, Is.EqualTo("Level3"));
        }
        [Test]
        public async Task TestGetIPLocation_DEAddr()
        {
            var segment = await IPGeodataRepository.GetIPLocationAsync("104.76.204.20");
            Assert.IsNotNull(segment);
            Assert.That(segment.Detail.Country, Is.EqualTo("�¹�"));
            Assert.That(segment.Detail.State, Is.EqualTo("�����˸�"));
            Assert.That(segment.Detail.City, Is.EqualTo("�����˸�"));
            Assert.That(segment.Detail.DataProvider, Is.EqualTo("������"));
        }
    }
}