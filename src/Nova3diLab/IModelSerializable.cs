namespace Nova3diLab
{
    interface IModelSerializable
    {
        byte[] Serialize();
        void Deserialize();
    }
}
