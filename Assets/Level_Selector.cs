using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Level_Selector : MonoBehaviour
{
    //button array
    public Button[] levelButtons;

    //disable button interactibility
    void Start ()
    {
        //Act as datastorage with a default value of 1
        int levelReaced = PlayerPrefs.GetInt ("levelReached", 1);

        for (int i = 0; i < levelButtons.Length; i++)
        {
            //set button to uninteractable if previous levl not complete

            if (i + 1 > levelReaced)
            {
                levelButtons[i].interactable = false;
            }


        }
    }

    //SceneLoad
    public void Select (string LevelName)
    {
        SceneManager.LoadScene(LevelName);
    }
}
