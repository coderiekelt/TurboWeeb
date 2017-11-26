using System.Collections.Generic;
using ProtoBuf;

namespace TurboWeeb
{
    [ProtoContract]
    public class Library
    {
        [ProtoMember(1)]
        public List<Anime> Anime;

        public Library()
        {
            this.Anime = new List<Anime>();
        }
    }
}
