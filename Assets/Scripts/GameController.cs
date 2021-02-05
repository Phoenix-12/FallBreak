using System.Collections;
using System.Collections.Generic;
using Assets.Scripts;
using UnityEngine;

public class GameController : MonoBehaviour
{
    private DialogModel _dialogModel;
    private DialogPresenter _dialogPresenter;
    [SerializeField] public DialogView _dialogView;

    [SerializeField] private GameObject _probePrefab;
    [SerializeField] private Vector3 _spawnPointProbe = new Vector3(0, -2.5f,0);

    public GameObject planet;
    
    public void Start()
    {
        _dialogModel = new DialogModel();
        _dialogPresenter = new DialogPresenter(_dialogModel, _dialogView);
        
        _dialogView.FillButtonDictionary();
        _dialogView.FillRootsDictionary();
        _dialogPresenter.Enable();

        planet = GameObject.Find("Planet");
    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(_probePrefab, _spawnPointProbe, Quaternion.identity);
        }
    }
}
