using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestItemControl : MonoBehaviour
{
    public bool isDone = false;
    /// <summary>
    /// index quest 1,2,3
    /// </summary>
    public int index = 0;
   // public QuestData questData;
    public ConfigQuestMissionRecord configQuest;
   // Start is called before the first frame update
    public virtual void Setup(ConfigQuestMissionRecord configQuest)
    {
        this.configQuest = configQuest;
       // questData = DataAPIController.instance.GetQuestData(configQuest.ID);
    }
    public virtual void LogQuest(QuestLogData logData)
    {

    }
    public virtual bool CheckQuest()
    {
        return false;
    }
}
