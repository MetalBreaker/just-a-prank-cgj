using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using TMPro;
public class DialogueManager : MonoBehaviour
{
    public DialogueSO CurrentDialogue;
    public TextMeshProUGUI Text;
    public Image CharHead;

    public static DialogueManager Instance;

    public bool DialogueCompleted = false;

    void Awake ()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(this.gameObject);
        } else {
            Instance = this;
        }
        gameObject.SetActive(false);
    }

    public void UpdateDialogue(DialogueSO newDialogue)
    {
        PlayerController.Player.PlayerControllable = false;
        CurrentDialogue = newDialogue;
        Text.maxVisibleCharacters = 0;
        gameObject.SetActive(true);

        StartCoroutine(PlayDialogue());
    }

    IEnumerator PlayDialogue()
	{

        // that's a handful of loops, spaghetti code
		foreach (ListWrapper lw in CurrentDialogue.Dialogue) 
		{
            for (int i = 0; i < lw.Text.Count; i++)
            {
                string s = lw.Text[i];
                Text.SetText(s);
                CharHead.sprite = lw.HeadImage[Mathf.Min(lw.HeadImage.Count - 1, i)];
                while (Text.maxVisibleCharacters < s.Length)
                {
                    Text.maxVisibleCharacters++;
                    yield return new WaitForSeconds (0.075f);
                }
                yield return new WaitForSeconds (1.5f);
                Text.maxVisibleCharacters = 0;
            }
		}
        gameObject.SetActive(false);
        PlayerController.Player.PlayerControllable = true;
        DialogueCompleted = true;
	}
}
