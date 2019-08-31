using System.Collections.Generic;
using UnityEngine;

public class InitDiag : MonoBehaviour
{
    public DialogueSO NewDialogue;

    public bool OnStart = true;
    public void Start()
    {
        if (OnStart)
            DialogueManager.Instance.UpdateDialogue(NewDialogue);
    }

    public void OnTriggerEnter2D()
    {
        if (!OnStart)
            DialogueManager.Instance.UpdateDialogue(NewDialogue);
    }
}
