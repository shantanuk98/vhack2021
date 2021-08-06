using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class manrun : MonoBehaviour
{
    Vector3 start;
    Vector3 end;
    Vector3 step;
    public GameObject fw, bw;
    int rot = 0;
    int points = 0;
    public Text txt,cal,dst;
    int dstm = 0;
    int calm = 0;
    // Start is called before the first frame update
    void Start()
    {
        start = new Vector3(25.5f, 0f, 27f);
        end = new Vector3(16.0f, 0f, 35.5f);
        step =  (end - start) / 1000;
        fw.active = true;
        bw.active = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (rot > 0)
        {
            transform.Rotate(0, 0.6f, 0);
            rot -= 1;
            if (rot == 0)
            {
                this.gameObject.GetComponent<Animation>().enabled = true;
            }
        }
        else if(transform.position.x < end.x)
        {
            rot = 300;
            bw.active = true;
            fw.active = false;
            points += 1;
            txt.text = "points : " + points.ToString();
            this.gameObject.GetComponent<Animation>().enabled = false;
            step = -1 * step;
        }
        else if (transform.position.x > start.x)
        {
            rot = 300;
            fw.active = true;
            bw.active = false;
            points += 1;
            txt.text = "points : " + points.ToString();
            step = -1 * step;
        }
        if(rot<=0)
        {
            transform.position += step;
            dstm += 1;
            calm += 1;
            dst.text = "distance : " + (dstm / 200).ToString()+" m";
            cal.text = "calories : " + (calm / 500).ToString()+" cal";
        }
        
    }
}
