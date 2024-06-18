using MelonLoader;
using Il2Cpp;
using nerfed_magatamas;

[assembly: MelonInfo(typeof(NerfedHifumi), "Nerfed Magatamas", "1.0.0", "Matthiew Purple")]
[assembly: MelonGame("アトラス", "smt3hd")]

namespace nerfed_magatamas;
public class NerfedHifumi : MelonMod
{
    public override void OnInitializeMelon()
    {
        tblHearts.fclHeartsTbl[2].Skill[0].ID = 10;
        tblHearts.fclHeartsTbl[5].Skill[0].ID = 4;
        tblHearts.fclHeartsTbl[6].Skill[0].ID = 22;
        tblHearts.fclHeartsTbl[8].Skill[0].ID = 16;
        tblHearts.fclHeartsTbl[11].Skill[2].ID = 194;
    }
}
