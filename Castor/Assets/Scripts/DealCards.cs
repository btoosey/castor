using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DealCards : MonoBehaviour
{

    public GameObject Card;
    public GameObject PlayerArea;

    public void OnClick()
	{
		for (int i = 0; i < 4; i++)
		{
            GameObject card = Instantiate(Card, new Vector2(0, 0), Quaternion.identity);
            card.transform.SetParent(PlayerArea.transform, true);
            card.transform.position = Vector2.down * 320;
		}
	}

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
