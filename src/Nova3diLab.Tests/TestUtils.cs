using System.IO;

namespace Nova3diLab.Tests
{
    public static class TestUtils
    {
        public static byte[] SerializeToBytes(IModelSerializable entity)
        {
            using (MemoryStream buffer = new MemoryStream())
            using (BinaryWriter writer = new BinaryWriter(buffer))
            {
                entity.Serialize(writer);
                return buffer.ToArray();
            }
        }
    }
}