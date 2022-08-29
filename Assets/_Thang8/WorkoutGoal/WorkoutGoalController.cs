using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorkoutGoalController : MonoBehaviour
{
    [SerializeField] GameObject selectWorkoutGoal;
    [SerializeField] GameObject mainWorkoutGoal;

    // Start is called before the first frame update
    void Start()
    {
        selectWorkoutGoal.SetActive(true);
        mainWorkoutGoal.SetActive(false);
    }

    public void WorkoutGoalPress(int id)
    {
        selectWorkoutGoal.SetActive(false);
        mainWorkoutGoal.SetActive(false);

        if (id == 0)
        {
            selectWorkoutGoal.SetActive(true);
        }
        else if (id == 1)
        {
            mainWorkoutGoal.SetActive(true);
        }
    }
}
