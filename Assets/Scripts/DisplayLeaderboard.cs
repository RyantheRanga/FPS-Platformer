using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Firebase.Database;

public class DisplayLeaderboard : MonoBehaviour
{
    public TextMeshProUGUI Highscore0, Highscore1, Highscore2, Highscore3, Highscore4;
    private string High0, High1, High2, High3, High4;
    private static string HighScoreUser0, HighScoreUser1, HighScoreUser2, HighScoreUser3, HighScoreUser4;
    private bool worked;

    async void Awake()
    {
        //Define Database reference
        var dbReference = FirebaseDatabase.DefaultInstance.RootReference;

        //Get snapshot of highscore values in Database
        var HS0 = await dbReference.Child("User").Child("Level0High").GetValueAsync();
        var HS1 = await dbReference.Child("User").Child("Level1High").GetValueAsync();
        var HS2 = await dbReference.Child("User").Child("Level2High").GetValueAsync();
        var HS3 = await dbReference.Child("User").Child("Level3High").GetValueAsync();
        var HS4 = await dbReference.Child("User").Child("Level4High").GetValueAsync();

        //Get snapshot of User display name of highscore holder from Database
        var UserHS0 = await dbReference.Child("User").Child("HighScoreUser0").GetValueAsync();
        var UserHS1 = await dbReference.Child("User").Child("HighScoreUser1").GetValueAsync();
        var UserHS2 = await dbReference.Child("User").Child("HighScoreUser2").GetValueAsync();
        var UserHS3 = await dbReference.Child("User").Child("HighScoreUser3").GetValueAsync();
        var UserHS4 = await dbReference.Child("User").Child("HighScoreUser4").GetValueAsync();
  
        worked = true;
        if(worked)
        {   
            //Get string of highscore snapshot value
            High0 = HS0.Value.ToString();
            High1 = HS1.Value.ToString();
            High2 = HS2.Value.ToString();
            High3 = HS3.Value.ToString();
            High4 = HS4.Value.ToString();

            //get string of display name snapshot value
            HighScoreUser0 = UserHS0.Value.ToString();
            HighScoreUser1 = UserHS1.Value.ToString();
            HighScoreUser2 = UserHS2.Value.ToString();
            HighScoreUser3 = UserHS3.Value.ToString();
            HighScoreUser4 = UserHS4.Value.ToString();
            
            //Display highscores and display name in leaderboard tab
            Highscore0.text = High0 + " " + displayedName0;
            Highscore1.text = High1 + " " + displayedName1;
            Highscore2.text = High2 + " " + displayedName2;
            Highscore3.text = High3 + " " + displayedName3;
            Highscore4.text = High4 + " " + displayedName4;
        }
    }
}
