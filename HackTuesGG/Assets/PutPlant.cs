
using UnityEngine;
using UnityEngine.Animations;

public class PutPlant : MonoBehaviour
{
    public GameObject Soil; 
    public float axisX;
    public float axisY;
    public float axisZ;
    Color m_MouseOverSprite = Color.red;
    Color m_OriginalColor;
    SpriteRenderer s_Renderer;

    void Start()
    {
        Soil = GameObject.Find("ponikvashto_cvete");
        s_Renderer = GetComponent<SpriteRenderer>();
        m_OriginalColor = s_Renderer.material.color;
        Soil.transform.localScale = new Vector3(0, 1, 1);
    }


    public void OnMouseDown()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Soil.transform.position = new Vector3(axisX, axisY, axisZ);
            Soil.transform.localScale = new Vector3(1, 1, 1); 
        }
    }

    
   
    
       
   
    void OnMouseOver()
    {
        s_Renderer.material.color = m_MouseOverSprite;
    }

    private void OnMouseExit()
    {
        s_Renderer.material.color = m_OriginalColor; 
    }
}
