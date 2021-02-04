using System.Collections;
using System.Collections.Generic;
using Assets.Scripts;
using UnityEngine;

public class GameController : MonoBehaviour
{
    private DialogModel _dialogModel;
    private DialogPresenter _dialogPresenter;
    [SerializeField] private DialogView _dialogView;

    private void Start()
    {
        _dialogModel = new DialogModel();
        _dialogPresenter = new DialogPresenter(_dialogModel, _dialogView);
        
        _dialogView.FillButtonDictionary();
        _dialogView.FillRootsDictionary();
        _dialogPresenter.Enable();
    }
}
