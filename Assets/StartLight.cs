using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartLight : MonoBehaviour
{
    private SpriteRenderer Light01;
    private SpriteRenderer Light02;
    private SpriteRenderer Light11;
    private SpriteRenderer Light12;
    private SpriteRenderer Light21;
    private SpriteRenderer Light22;
    private SpriteRenderer Light31;
    private SpriteRenderer Light32;
    private SpriteRenderer Light41;
    private SpriteRenderer Light42;
    public int lightStatus = 2;
    public float lTimer = 7;
    public ButtonClick bClick;
    public bool isZero = true;
    public float Counter = 0;

    // Start is called before the first frame update
    void Start()
    {
        Light01 = transform.Find("Lights").transform.Find("ThirdLight").GetComponent<SpriteRenderer>();
        Light02 = transform.Find("Lights").transform.Find("FourtLight").GetComponent<SpriteRenderer>();
        Light11 = transform.Find("Lights1").transform.Find("ThirdLight").GetComponent<SpriteRenderer>();
        Light12 = transform.Find("Lights1").transform.Find("FourtLight").GetComponent<SpriteRenderer>();
        Light21 = transform.Find("Lights2").transform.Find("ThirdLight").GetComponent<SpriteRenderer>();
        Light22 = transform.Find("Lights2").transform.Find("FourtLight").GetComponent<SpriteRenderer>();
        Light31 = transform.Find("Lights3").transform.Find("ThirdLight").GetComponent<SpriteRenderer>();
        Light32 = transform.Find("Lights3").transform.Find("FourtLight").GetComponent<SpriteRenderer>();
        Light41 = transform.Find("Lights4").transform.Find("ThirdLight").GetComponent<SpriteRenderer>();
        Light42 = transform.Find("Lights4").transform.Find("FourtLight").GetComponent<SpriteRenderer>();
        
    }

    // Update is called once per frame

    private void Update()
    {
        if (bClick.status == 1)
        {
            lTimer = lTimer - Time.deltaTime;
            lightStatus = 1;
            if (lTimer < 7)
            {
                Light01.color = new Color(1, 0, 0, 1);
                Light02.color = new Color(1, 0, 0, 1);
            }
            if (lTimer < 6)
            {
                Light11.color = new Color(1, 0, 0, 1);
                Light12.color = new Color(1, 0, 0, 1);
            }
             if (lTimer < 5)
            {
                Light21.color = new Color(1, 0, 0, 1);
                Light22.color = new Color(1, 0, 0, 1);
            }
             if (lTimer < 4)
            {
                Light31.color = new Color(1, 0, 0, 1);
                Light32.color = new Color(1, 0, 0, 1);
            }
             if (lTimer < 3)
            {
                Light41.color = new Color(1, 0, 0, 1);
                Light42.color = new Color(1, 0, 0, 1);
            }
             if (lTimer <0.1)
            {
                Light01.color = new Color(1, 1, 1, 0.2f);
                Light02.color = new Color(1, 1, 1, 0.2f);
                Light11.color = new Color(1, 1, 1, 0.2f);
                Light12.color = new Color(1, 1, 1, 0.2f);
                Light21.color = new Color(1, 1, 1, 0.2f);
                Light22.color = new Color(1, 1, 1, 0.2f);
                Light31.color = new Color(1, 1, 1, 0.28f);
                Light32.color = new Color(1, 1, 1, 0.2f);
                Light41.color = new Color(1, 1, 1, 0.2f);
                Light42.color = new Color(1, 1, 1, 0.2f);
            }

            if (lTimer <= 0)
            {
                lightStatus = 0;
                lTimer = 0;
                if (isZero)
                {
                    Counter = Counter + Time.time;
                    isZero = false;
                }
            }
        } 
    }
}
