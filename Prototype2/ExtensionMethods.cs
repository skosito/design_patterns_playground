using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Prototype2
{
    public static class ExtensionMethods
    {
        // to avoid putting Serializable attribute everywhere use other serializer,
        // like xml serializer, instead of binary like here
        public static T DeepCopy<T>(this T self)
        {
            var stream = new MemoryStream();
            var formatter = new BinaryFormatter();
            formatter.Serialize(stream, self);
            stream.Seek(0, SeekOrigin.Begin);

            var copy = formatter.Deserialize(stream);
            stream.Close();
            return (T) copy;
        }
    }
}