using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Login : MonoBehaviour
{
    public InputField username_field;
    public string user;
    public string FirstName;
    string errormsg;
    // Start is called before the first frame update

    public GameObject UI;
    public GameObject Scene1;
    public Text error;
    public GameObject obj1;
    public GameObject obj2;
    public GameObject obj3;
    public GameObject alert1;
    public GameObject alert2;
    public GameObject alert3;

    public void loadscene()
    {
        obj3.SetActive(false);
        obj2.SetActive(false);
        obj1.SetActive(false);
        alert1.SetActive(false);
        alert2.SetActive(false);
        alert3.SetActive(false);

        user = username_field.text.ToString();

        if(user.ToLower() == "goats123")
        {
            FirstName = "Kyle C";
            obj1.SetActive(true);
            alert1.SetActive(true);
        }
        else if(user.ToLower() == "bbcereal123")
        {
            FirstName = "Bailey B";
            obj2.SetActive(true);
            alert2.SetActive(true);
        }
        else if(user.ToLower() == "snoopy")
        {
            FirstName = "Cody W";
            obj3.SetActive(true);
            alert3.SetActive(true);
        }
        else
        {
            FirstName = null;
        }

        if(FirstName == null)
        {
            error.text = "No user with that username!";
        }
        else
        {
            UI.SetActive(false);
            Scene1.SetActive(true);
        }

    }

}
