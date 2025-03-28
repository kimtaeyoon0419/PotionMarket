using UnityEngine;

[CreateAssetMenu(fileName = "NatureExplorationAction", menuName = "Scriptable Objects/ScheduleAction")]
public class NatureExplorationAction : IScheduleAction
{
    public override void ExecuteSchedule()
    {
        Debug.Log("Ž�� ������ ���� �� �ش� ������ Ž��");
    }
}

[CreateAssetMenu(fileName = "ShopManagementAction", menuName = "Scriptable Objects/ScheduleAction")]
public class ShopManagementAction : IScheduleAction
{
    public override void ExecuteSchedule()
    {
        Debug.Log("�� ���� �� ������ ���� �� �Ǹ�");
    }
}

[CreateAssetMenu(fileName = "ShopUpGradeAction", menuName = "Scriptable Objects/ScheduleAction")]
public class ShopUpGradeAction : IScheduleAction
{
    public override void ExecuteSchedule()
    {
        Debug.Log("������ ���� ��� ��ȭ �� �ٹ̱�");
    }
}