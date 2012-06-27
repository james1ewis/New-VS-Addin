// Guids.cs
// MUST match guids.h
using System;

namespace Company.VSPackage2
{
    static class GuidList
    {
        public const string guidVSPackage2PkgString = "1ac5fe9e-adac-4c82-835b-5ec674c25540";
        public const string guidVSPackage2CmdSetString = "baa0aa46-1f91-41ba-b0be-830a0670027c";

        public static readonly Guid guidVSPackage2CmdSet = new Guid(guidVSPackage2CmdSetString);
    };
}