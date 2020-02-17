using System.IO;
using Nova3diLab.DF2.LOD;
using Xunit;

namespace Nova3diLab.Tests.DF2.LOD
{
    public class CollisionVolumeTests
    {
        public static CollisionVolume CollisionVolume => new CollisionVolume
        {
            VolumeType = CollisionVolumeType.Normal,
            BoundingSphereRadius = .866025403784439,
            BoundingCircleRadius = .707106781186548,
            XMin = 0,
            XMax = 1,
            YMin = 0,
            YMax = 1,
            ZMin = 0,
            ZMax = 1,
            CollisionPlaneCount = 6,
        };
        
        [Fact]
        public void SerializeTest()
        {
            var expected = File.ReadAllBytes("Resources/collision-volume.3di");
            Assert.Equal(expected, TestUtils.SerializeToBytes(CollisionVolume));
        }
    }
}