using System.Collections.Generic;
using Assets.Scripts;
using UnityEngine;
using UnityEngine.UI;


public class DialogView : MonoBehaviour
{ 
    [SerializeField] public List<DialogButton> _buttons;
    [SerializeField] public List<Dialog> _roots;

    public Dictionary<DialogType, Button> Buttons = new Dictionary<DialogType, Button>();
    public Dictionary<DialogType, GameObject> Roots = new Dictionary<DialogType, GameObject>();
    
    public void FillButtonDictionary()
    {
        foreach (var dialogButton in _buttons)
        {
            Buttons.Add(dialogButton.Type , dialogButton.Button);
            Debug.Log(dialogButton.Type);
            Debug.Log(dialogButton.Button);
        }
    }
    public void FillRootsDictionary()
    {
        foreach (var dialog in _roots)
        {
            Roots.Add(dialog.Type , dialog.Root);
        }
    }

}