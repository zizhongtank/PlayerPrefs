using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;


public class Scene1Script : MonoBehaviour
{

    //name  
    private string mName = "Tank";
    //age 
    private int mAge = 27;
    //grade 
    private float mGrade = 90F;

    void OnGUI()
    {
        GUILayout.Label("Unity3D data storage  program", GUILayout.Height(25));
        //name  
        GUILayout.Label("Please type in your name：", GUILayout.Height(25));
        mName = GUILayout.TextField(mName, GUILayout.Height(25));
        //age  
        GUILayout.Label("Please type in your age：", GUILayout.Height(25));
        mAge = int.Parse(GUILayout.TextField(mAge.ToString(), GUILayout.Height(25)));
        //grade  
        GUILayout.Label("Please type in your grade：", GUILayout.Height(25));
        mGrade = float.Parse(GUILayout.TextField(mGrade.ToString(), GUILayout.Height(25)));

        //submit data 
        if (GUILayout.Button("Submit Data", GUILayout.Height(25)))
        {
            //clear data 
            PlayerPrefs.SetString("Name", mName);
            PlayerPrefs.SetInt("Age", mAge);
            PlayerPrefs.SetFloat("Grade", mGrade);

            //switch to Scene2  
            SceneManager.LoadScene("Scene2");
        }
    }
}