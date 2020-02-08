using System.IO;

namespace Nova3diLab
{
    public interface IModelSerializable
    {
        void Serialize(BinaryWriter writer);
        void Deserialize(BinaryReader reader);
    }
}
