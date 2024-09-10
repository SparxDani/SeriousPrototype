using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
public class MouseInteraction : MonoBehaviour
{
    public DialogueData dialogueData;  
    public TextMeshProUGUI dialogueUI;            
    private void OnMouseEnter()
    {
        
        if (dialogueUI != null && dialogueData != null)
        {
            dialogueUI.text = dialogueData.dialogueText;
        }
    }

    private void OnMouseExit()
    {
       
        if (dialogueUI != null)
        {
            dialogueUI.text = "";
        }
    }

    private void OnMouseDown()
    {
        
        if (dialogueData != null && !string.IsNullOrEmpty(dialogueData.sceneToLoad))
        {
            SceneManager.LoadScene(dialogueData.sceneToLoad);
        }
    }
}
