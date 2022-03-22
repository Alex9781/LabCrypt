using GOST.Types;

namespace GOST.Interfaces
{
    internal interface IManaged
    {     
        byte[] XOREncode(byte[] key, byte[] iv, byte[] message, SBlockTypes sBlockType = SBlockTypes.GOST);
      
        byte[] XORDecode(byte[] key, byte[] iv, byte[] message, SBlockTypes sBlockType = SBlockTypes.GOST);     
    }
}
