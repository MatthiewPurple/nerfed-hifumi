using MelonLoader;
using Il2Cpp;
using nerfed_hifumi;

[assembly: MelonInfo(typeof(NerfedHifumi), "Nerfed Hifumi", "1.0.0", "Matthiew Purple")]
[assembly: MelonGame("アトラス", "smt3hd")]

namespace nerfed_hifumi;
public class NerfedHifumi : MelonMod
{
    public override void OnInitializeMelon()
    {
        tblHearts.fclHeartsTbl[6].Skill[0].ID = 22;
    }
}
