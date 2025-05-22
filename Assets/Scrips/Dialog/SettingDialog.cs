using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingDialog : BaseDialog
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnClose()
    {
        DialogManager.instance.HideDialog(dialogIndex);
    }
}
