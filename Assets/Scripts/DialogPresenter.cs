using System.Collections;
using System.Collections.Generic;
using Assets.Scripts;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts
{
    public class DialogPresenter
    {
        private DialogView _dialogView;
        private DialogModel _dialogModel;

        public DialogPresenter(DialogModel dialogModel, DialogView dialogView)
        {
            _dialogModel = dialogModel;
            _dialogView = dialogView;
        }

        public void Enable()
        {
            Debug.Log(_dialogView.Buttons[DialogType.Gift]);
            _dialogModel.Show += Show;
            _dialogModel.Hide += Hide;
            _dialogView.Buttons[DialogType.Gift].onClick.AddListener(OnGift);
            _dialogView.Buttons[DialogType.Shop].onClick.AddListener(OnShop);
            _dialogView.Buttons[DialogType.Settings].onClick.AddListener(OnSettings);
            _dialogView.Buttons[DialogType.Rating].onClick.AddListener(OnRating);
        }

        public void Disable()
        {
            _dialogModel.Hide -= Hide;
            _dialogModel.Show -= Show;
            _dialogView.Buttons[DialogType.Gift].onClick.RemoveListener(OnGift);
            _dialogView.Buttons[DialogType.Shop].onClick.RemoveListener(OnShop);
            _dialogView.Buttons[DialogType.Settings].onClick.RemoveListener(OnSettings);
            _dialogView.Buttons[DialogType.Rating].onClick.RemoveListener(OnRating);
        }

        private void Show(){
            _dialogView.Roots[_dialogModel.CurrentDialog].SetActive(true);
        }

        private void Hide(){
            _dialogView.Roots[_dialogModel.CurrentDialog].SetActive(false);
        }
        private void OnSettings(){
            _dialogModel.ChangeDialog(DialogType.Settings);
        }
        
        private void OnRating(){
            _dialogModel.ChangeDialog(DialogType.Rating);
        }
        
        private void OnShop(){
            _dialogModel.ChangeDialog(DialogType.Shop);
        }
        private void OnGift(){
            _dialogModel.ChangeDialog(DialogType.Gift);
        }
    }
}