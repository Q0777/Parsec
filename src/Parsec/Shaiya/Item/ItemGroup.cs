using Parsec.Serialization;
using Parsec.Shaiya.Core;

namespace Parsec.Shaiya.Item;

public sealed class ItemGroup : ISerializable
{
    public List<ItemDefinition> ItemDefinitions { get; set; } = new();

    public void Read(SBinaryReader binaryReader)
    {
        ItemDefinitions = binaryReader.ReadList<ItemDefinition>();
    }

    public void Write(SBinaryWriter binaryWriter)
    {
        binaryWriter.Write(ItemDefinitions);
    }
}
