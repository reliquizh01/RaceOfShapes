﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

using TMPro;
using UnitsScripts.Behaviour;
using InteractableScripts.Behavior;
using WorldObjectScripts.Behavior;
using PlayerScripts.UnitCommands;

namespace UserInterface
{

    public class BasePopup : MonoBehaviour
    {
        public TextMeshProUGUI header;
        public List<BasePopupOptions> potentialOptions;
        
        public void SetPotentialOptions(List<ActionType> actions)
        {
            int actionCount = actions.Count;
            // Activate Potential Option depending on amount of actions
            for (int i = 0; i < potentialOptions.Count; i++)
            {

                if(i < actionCount)
                {
                    potentialOptions[i].gameObject.SetActive(true);
                    potentialOptions[i].SetTextHolder(actions[i]);
                }
                else
                {
                    potentialOptions[i].gameObject.SetActive(false);
                }
            }
        }

        // Placed in the buttonpanel
        public void PlayerChoiceOfAction(ActionType index)
        {
            this.gameObject.SetActive(false);
            InteractingPopups.GetInstance.StartInteractions(index);
        }


    }
}
