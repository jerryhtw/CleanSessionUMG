using UnrealBuildTool;
using System.Collections.Generic;

public class AdvancedTest0201Target : TargetRules
{
    public AdvancedTest0201Target(TargetInfo Target) : base(Target)
    {
        Type = TargetType.Game;
        DefaultBuildSettings = BuildSettingsVersion.Latest;
        ExtraModuleNames.AddRange(new string[] { "AdvancedTest0201" });
    }
}
