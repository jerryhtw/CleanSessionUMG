using UnrealBuildTool;
using System.Collections.Generic;

public class AdvancedTest0201EditorTarget : TargetRules
{
    public AdvancedTest0201EditorTarget(TargetInfo Target) : base(Target)
    {
        Type = TargetType.Editor;
        DefaultBuildSettings = BuildSettingsVersion.Latest;
        ExtraModuleNames.AddRange(new string[] { "AdvancedTest0201" });
    }
}
