using ActionMenu;
using MelonLoader;
using System.Collections.Generic;

[assembly:MelonGame("Alpha Blend Interactive", "ChilloutVR")]
[assembly:MelonInfo(typeof(ActionMenuExample.ActionMenuExampleMod), "ActionMenuExample", "1.0.0", "daky", "https://github.com/dakyneko/DakyModsCVR")]

namespace ActionMenuExample
{
    public class ActionMenuExampleMod : MelonMod
    {

        private Menu lib;
        public override void OnApplicationStart()
        {
            lib = new Menu();
        }

        // Public library for all mods to use, you can extend this
        public class Menu : ActionMenu.ActionMenuMod.Lib
        {
            // optionnal
            protected override string modName => "DakyMenu";
            // optionnal
            protected override string? modIcon => "data:image/png;base64,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";

            // recommended way to make a mod menu
            protected override List<MenuItem> modMenuItems()
            {
                return new List<MenuItem>()
                {
                    new MenuItem("Super button",
                        BuildButtonItem("rawr", () => MelonLogger.Msg($"Big rawr"))),

                    new MenuItem("Toggle the rawr",
                        BuildToggleItem("rawr", (v) => MelonLogger.Msg($"toggle RAWR: {v}"))),

                    new MenuItem("Radial rawr",
                        BuildRadialItem("rawr", (v) => MelonLogger.Msg($"Radial RAWR: {v}"), minValue: -1, maxValue: 1)),
                };
            }
        }
    }
}