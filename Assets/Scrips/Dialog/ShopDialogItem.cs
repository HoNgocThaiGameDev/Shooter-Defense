using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ShopDialogItem : MonoBehaviour
{
    public int id;

    public TMP_Text name_lb;
    public TMP_Text bonus_lb;
    public TMP_Text cost_lb;
    public TMP_Text value_lb;
    private ConfigShopRecord cf;
    // Start is called before the first frame update
    void Start()
    {
        cf = ConfigManager.instance.configShop.GetRecordByKeySearch(id);
        name_lb.text = cf.Name;
        bonus_lb.text = cf.Bonus > 0 ? cf.Bonus.ToString() + "%" : "";
        cost_lb.text = cf.Cost;
        value_lb.text = cf.Value.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnBuy()
    {
        DataAPIController.instance.OnBuyShop(id);
    }
}
