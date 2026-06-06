using p3rpc.femc.Configuration;

namespace p3rpc.femc.HexEditing
{
    public static class Allout
    {
        private static void ApplyAlloutBGColor(Config config, string modDirectory)
        {
            string filePath = Path.Combine(modDirectory,
                "UnrealEssentials", "P3R", "Content", "Xrd777",
                "Effects", "Niagara", "Battle", "NS_FX_Btl_AlloutBG.ucas");

            // NS_FX_Btl_AlloutBG_00
            HexColorEditor.WriteFloat(filePath, 0x5A435, (float)config.AlloutBG1.R / 255.0f); // Original color #000008
            HexColorEditor.WriteFloat(filePath, 0x5A43D, (float)config.AlloutBG1.G / 255.0f);
            HexColorEditor.WriteFloat(filePath, 0x5A441, (float)config.AlloutBG1.B / 255.0f);

            HexColorEditor.WriteFloat(filePath, 0x5DD6F, (float)config.AlloutBG2.R / 255.0f); // Original color #0080CC
            HexColorEditor.WriteFloat(filePath, 0x5DD73, (float)config.AlloutBG2.G / 255.0f);
            HexColorEditor.WriteFloat(filePath, 0x5DD77, (float)config.AlloutBG2.B / 255.0f);

            // NS_FX_Btl_AlloutBG_01
            HexColorEditor.WriteFloat(filePath, 0xACC1, (float)config.AlloutBG3.R / 255.0f); // Original color #000066
            HexColorEditor.WriteFloat(filePath, 0xACC5, (float)config.AlloutBG3.G / 255.0f);
            HexColorEditor.WriteFloat(filePath, 0xACC9, (float)config.AlloutBG3.B / 255.0f);

            HexColorEditor.WriteFloat(filePath, 0xEA54, (float)config.AlloutBG3.R / 255.0f); // Original color #000066
            HexColorEditor.WriteFloat(filePath, 0xEA58, (float)config.AlloutBG3.G / 255.0f);
            HexColorEditor.WriteFloat(filePath, 0xEA5C, (float)config.AlloutBG3.B / 255.0f);

            HexColorEditor.WriteFloat(filePath, 0x12887, (float)config.AlloutBG1.R / 255.0f); // Original color #000008
            HexColorEditor.WriteFloat(filePath, 0x1288F, (float)config.AlloutBG1.G / 255.0f);
            HexColorEditor.WriteFloat(filePath, 0x12893, (float)config.AlloutBG1.B / 255.0f);

            HexColorEditor.WriteFloat(filePath, 0x168B7, (float)config.AlloutBG1.R / 255.0f); // Original color #000008
            HexColorEditor.WriteFloat(filePath, 0x168BF, (float)config.AlloutBG1.G / 255.0f);
            HexColorEditor.WriteFloat(filePath, 0x168C3, (float)config.AlloutBG1.B / 255.0f);

            HexColorEditor.WriteFloat(filePath, 0x1A8EB, (float)config.AlloutBG2.R / 255.0f); // Original color #0080CC
            HexColorEditor.WriteFloat(filePath, 0x1A8EF, (float)config.AlloutBG2.G / 255.0f);
            HexColorEditor.WriteFloat(filePath, 0x1A8F3, (float)config.AlloutBG2.B / 255.0f);

            HexColorEditor.WriteFloat(filePath, 0x1E8AB, (float)config.AlloutBG2.R / 255.0f); // Original color #0080CC
            HexColorEditor.WriteFloat(filePath, 0x1E8AF, (float)config.AlloutBG2.G / 255.0f);
            HexColorEditor.WriteFloat(filePath, 0x1E8B7, (float)config.AlloutBG2.B / 255.0f);

            HexColorEditor.WriteFloat(filePath, 0x2284E, (float)config.AlloutBG2.R / 255.0f); // Original color #0080CC
            HexColorEditor.WriteFloat(filePath, 0x22852, (float)config.AlloutBG2.G / 255.0f);
            HexColorEditor.WriteFloat(filePath, 0x2285A, (float)config.AlloutBG2.B / 255.0f);

            HexColorEditor.WriteFloat(filePath, 0x2680F, (float)config.AlloutBG2.R / 255.0f); // Original color #0080CC
            HexColorEditor.WriteFloat(filePath, 0x26813, (float)config.AlloutBG2.G / 255.0f);
            HexColorEditor.WriteFloat(filePath, 0x2681B, (float)config.AlloutBG2.B / 255.0f);
        }

        public static void Apply(Config config, string modDirectory)
        {
            ApplyAlloutBGColor(config, modDirectory);
        }
    }
}
