using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HarmonyLib;
using Verse;

namespace Rimthem
{
    public static class RenderPatches
    {
        [HarmonyPatch(typeof(PawnRenderer), nameof(PawnRenderer.DrawBodyApparel))]
        public static class DrawBodyApparel_Patch
        {
            public static IEnumerable<CodeInstruction> Transpiler(IEnumerable<CodeInstruction> instructions)
            {
                var instructionList = instructions.ToList();
                for (var i = 0; i < instructionList.Count; i++)
                {
                    var code = instructionList[i];
                    yield return code;
                }
            }
        }
    }
}
