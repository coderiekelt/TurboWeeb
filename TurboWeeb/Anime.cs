using ProtoBuf;

namespace TurboWeeb
{
    [ProtoContract]
    public class Anime
    {
        [ProtoMember(1)]
        public string Name { get; set; }

        [ProtoMember(2)]
        public string Uri { get; set; }

        public override string ToString()
        {
            return this.Name;
        }
    }
}
