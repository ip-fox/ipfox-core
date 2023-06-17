namespace IPFox.Tests
{
    public class IPGeodataRepositoryTests
    {
        [Test]
        public async Task TestGetIPLocation_USAddr()
        {
            var detail = await IPGeodataRepository.GetIPLocationAsync("8.8.8.8");
            Assert.IsNotNull(detail);
            Assert.That(detail.Country, Is.EqualTo("����"));
            Assert.That(detail.DataProvider, Is.EqualTo("Level3"));
        }
        [Test]
        public async Task TestGetIPLocation_DEAddr()
        {
            var detail = await IPGeodataRepository.GetIPLocationAsync("104.76.204.20");
            Assert.IsNotNull(detail);
            Assert.That(detail.Country, Is.EqualTo("�¹�"));
            Assert.That(detail.State, Is.EqualTo("�����˸�"));
            Assert.That(detail.City, Is.EqualTo("�����˸�"));
            Assert.That(detail.DataProvider, Is.EqualTo("������"));
        }
    }
}