// This file was generated by a tool; you should avoid making direct changes.
// Consider using 'partial classes' to extend these types
// Input: pb0x01.proto

#pragma warning disable CS1591, CS0612, CS3021

namespace Onlineproto
{

    [global::ProtoBuf.ProtoContract(Name = @"cs_0x0100_game_login")]
    public partial class Cs0x0100GameLogin
    {
        [global::ProtoBuf.ProtoMember(1, Name = @"token")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Token { get; set; } = "";

        [global::ProtoBuf.ProtoMember(2, Name = @"open_id")]
        [global::System.ComponentModel.DefaultValue("")]
        public string OpenId { get; set; } = "";

    }

    [global::ProtoBuf.ProtoContract(Name = @"sc_0x0100_game_login")]
    public partial class Sc0x0100GameLogin
    {
        [global::ProtoBuf.ProtoMember(1, Name = @"player")]
        public GPlayer Player { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"gold")]
        public int Gold { get; set; }

        [global::ProtoBuf.ProtoMember(3, Name = @"volume")]
        public int Volume { get; set; }

        [global::ProtoBuf.ProtoMember(4, Name = @"diamonds")]
        public int Diamonds { get; set; }

        [global::ProtoBuf.ProtoMember(5, Name = @"time")]
        public long Time { get; set; }

        [global::ProtoBuf.ProtoMember(6, Name = @"check_code")]
        public int CheckCode { get; set; }

    }

}

#pragma warning restore CS1591, CS0612, CS3021
