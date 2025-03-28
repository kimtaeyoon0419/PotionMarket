using UnityEngine;

[CreateAssetMenu(fileName = "NatureExplorationAction", menuName = "Scriptable Objects/ScheduleAction")]
public class NatureExplorationAction : IScheduleAction
{
    public override void ExecuteSchedule()
    {
        Debug.Log("탐사 지역을 선택 후 해당 지역을 탐사");
    }
}

[CreateAssetMenu(fileName = "ShopManagementAction", menuName = "Scriptable Objects/ScheduleAction")]
public class ShopManagementAction : IScheduleAction
{
    public override void ExecuteSchedule()
    {
        Debug.Log("고객 응대 및 아이템 제조 후 판매");
    }
}

[CreateAssetMenu(fileName = "ShopUpGradeAction", menuName = "Scriptable Objects/ScheduleAction")]
public class ShopUpGradeAction : IScheduleAction
{
    public override void ExecuteSchedule()
    {
        Debug.Log("상점의 여러 요소 강화 및 꾸미기");
    }
}