using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemCollector : MonoBehaviour
{
    public int gems = 0;
    [SerializeField] private GameObject BigGem;
    [SerializeField] private Text gemsText;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("SmallGem"))
        {
            Destroy(collision.gameObject);
            gems++;
            gemsText.text = "Gems: " + gems;
            if (gems >= 2)
            {
                BigGem.SetActive(true);
            }
        } 
        else if (collision.gameObject.CompareTag("BigGem"))
        {
            Destroy(collision.gameObject);
            transform.localScale += new Vector3(1, 1, 1);
            gemsText.text = "Gems: 1";
        }

    }
}
