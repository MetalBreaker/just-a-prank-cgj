using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Dialogue", menuName = "DialogueSO", order = 1)]
public class DialogueSO : ScriptableObject
{
    [SerializeField]
    public List<ListWrapper> Dialogue;
    [SerializeField]
    public bool IsPlayerControllableAfterDialogue = true;
}

[System.Serializable]
 public class ListWrapper
 {
      public List<Sprite> HeadImage;
      public List<string> Text;
 }