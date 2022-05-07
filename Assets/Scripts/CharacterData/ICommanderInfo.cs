using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ICommanderInfo
{
    public ref List<ICombatObject> SubmitFleet();
    public EncounterAIState PlayerRelationship { get; set; }

}
