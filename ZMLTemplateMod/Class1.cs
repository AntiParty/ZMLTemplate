//Before getting started make sure you have added References
// Here are the References you will need
// From the Drift Racing Online_Data/Managed folder
//Assembly - CSharp.dll
//UnityEngine.dll
//UnityEngine.CoreModule.dll

//From the ZML/core folder
//ZML.API.dll

// ZML Doc Links - https://zi9.github.io/zml/docs/mod-dev-quick-start/
// https://zi9.github.io/zml/docs/api-docs/


using ZML.API;

namespace MyCoolMod
{
    [ZMLMod("zml.zi9.testmod", "Zi9's Cool Mod for Testing", "1.0.0", "Zi9")]
    public class MyCoolMod : BaseMod, IToolboxUI
    {
        public void OnToolboxGUI()
        {
            GUILayout.Button("Hello world!");
            // You can use any GUILayout calls here
        }
        public void OnToolboxOpen()
        {
            // Leave this function empty if you don't need it or initialize some stuff here if you want
            // You must however declare it because it is an interface
        }
    }
}