using System.Collections;
using System.Collections.Generic;
using Assets.Scripts;
using UnityEngine;
using UnityEngine.UI;
using Button = UnityEngine.UIElements.Button;

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
            _dialogModel.Show += Show;
            _dialogModel.Hide += Hide;
            
        }

        public void Disable()
        {
            _dialogModel.Hide -= Hide;
            _dialogModel.Show -= Show;
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