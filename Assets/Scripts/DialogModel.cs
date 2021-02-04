using System;

namespace Assets.Scripts
{
    public class DialogModel
    {
        public DialogType CurrentDialog;

        public event Action Show;
        public event Action Hide;


        public void OnShow()
        {
            Show?.Invoke();
        }
        
        public void OnHide()
        {
            Hide?.Invoke();
        }

        public void ChangeDialog(DialogType root)
        {
            OnHide();
            CurrentDialog = root;
            OnShow();
        }
    }
}