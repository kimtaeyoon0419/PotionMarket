using UnityEngine;

public enum ScheduleCategory
{
    Collection,
    Operation,
    Other
}

[CreateAssetMenu(fileName = "Schedule", menuName = "Scriptable Objects/Schedule")]
public class Schedule : ScriptableObject
{
    public ScheduleCategory category;
    public string ScheduleName;
    public string ScheduleDescription;
    public IScheduleAction scheduleAction;

    public void ExecuteSchedule()
    {
        scheduleAction.ExecuteSchedule();
    }
}
