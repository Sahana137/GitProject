using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.Design.Serialization;
using System.Text.Json.Serialization;


namespace Batch_7
{
    [Serializable]
    class Serialization_1
    { 
            public int ID;
            public string Name;
            static void Main(string[] args)
            {
            Serialization_1 obj = new Serialization_1();
                obj.ID = 1;
                obj.Name = ".Net";

                using (MemoryStream stream = new MemoryStream())
                {
                    BinaryWriter writer = new BinaryWriter(stream)
    ;
                    writer.Write(obj.ID);
                    writer.Write(obj.Name);

                    // Get the binary data
                    byte[] binaryData = stream.ToArray();

                    // To deserialize:
                    using (MemoryStream readStream = new MemoryStream(binaryData))
                    {
                        BinaryReader reader = new BinaryReader(readStream);
                    Serialization_1 deserializedObj = new Serialization_1();
                        deserializedObj.ID = reader.ReadInt32();
                        deserializedObj.Name = reader.ReadString();
                    }
                }
            }
        
    }
}
