﻿using System.Collections;
using System.Collections.Generic;
using InteractableScripts.Behavior;
using UnityEngine;


using UnitsScripts.Behaviour;
using InteractableScripts.Behavior;
namespace WorldObjectScripts.Behavior
{
    public class Tree : WorldObjectBaseBehaviour
    {


        
        public override void StartInteraction(InteractingComponent unit, ActionType actionIndex)
        {
            base.StartInteraction(unit, actionIndex);
            // Obtain Interacting Unit
            if (unit.objectType == ObjectType.PlayerControlled || unit.objectType == ObjectType.Unit)
            {
                interactingUnit = unit.GetComponent<UnitBaseBehaviourComponent>();
            }

            ReceiveDamage();
        }

        public override void ReceiveDamage()
        {
            base.ReceiveDamage();
            mAnimation.Play();
        }
    }
}
