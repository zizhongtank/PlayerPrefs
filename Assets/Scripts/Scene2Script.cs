using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Scene2Script : MonoBehaviour
{

    private string mName;
    private int mAge;
    private float mGrade;

    void Start()
    {
        //Read Datas 
        mName = PlayerPrefs.GetString("Name", "DefaultValue");
        mAge = PlayerPrefs.GetInt("Age", 0);
        mGrade = PlayerPrefs.GetFloat("Grade", 0F);
    }

    void OnGUI()
    {
        GUILayout.Label("Unity3D data storage  program", GUILayout.Height(25));
        //name 
        GUILayout.Label("Name：" + mName, GUILayout.Height(25));
        //age
        GUILayout.Label("Age：" + mAge, GUILayout.Height(25));
        //grade 
        GUILayout.Label("Grade：" + mGrade, GUILayout.Height(25));

        //clear data
        if (GUILayout.Button("Clear Data", GUILayout.Height(25)))
        {
            PlayerPrefs.DeleteAll();
        }

        //return Scene1 
        if (GUILayout.Button("Return Scene", GUILayout.Height(25)))
        {
           SceneManager.LoadScene("Scene1");
        }

    }
}