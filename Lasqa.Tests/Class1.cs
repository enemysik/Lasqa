using Lasqa.Logic;
using NUnit.Framework;

namespace Lasqa.Tests
{
    public class PathCreatorTests
    {
        private PathCreator _pathCreator;

        [SetUp]
        public void SetUp()
        {
            _pathCreator = new PathCreator();
        }

        [Test]
        public void ShouldCreatePath()
        {
            var path = _pathCreator.Create();

            Assert.NotNull(path);
        }

        [Test]
        public void ShouldCreateValidPath()
        {
            var path = _pathCreator.Create();

            Assert.IsTrue(path.Valid);
        }
    }

    public class PathCreatorTests2
    {
        private PathCreator _pathCreator;

        [SetUp]
        public void SetUp()
        {
            _pathCreator = new PathCreator();
        }

        [Test]
        public void ShouldCreatePath()
        {
            var path = _pathCreator.Create();

            Assert.NotNull(path);
        }

        [Test]
        public void ShouldCreateValidPath()
        {
            var path = _pathCreator.Create();

            Assert.IsTrue(path.Valid);
        }

        [Test]
        public void AlwaysFails()
        {
            Assert.Fail();
        }
    }
}
