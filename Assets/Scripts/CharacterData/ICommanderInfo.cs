using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//An interface meant to be used by fleet controllers(player and AI) to eliminate the need for specific code for either.
public interface ICommanderInfo
{
    public ref List<ICombatObject> SubmitFleet();
    public EncounterAIState PlayerRelationship { get; set; }

}
