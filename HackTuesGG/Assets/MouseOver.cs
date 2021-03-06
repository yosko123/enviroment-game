using UnityEngine;

public class MouseOver : MonoBehaviour
{
    Color m_MouseOverSprite = Color.red;
    Color m_OriginalColor;
    SpriteRenderer s_Renderer; 
    private void Start()
    {
        s_Renderer = GetComponent<SpriteRenderer>();
        //Fetch the original color of the GameObject
        m_OriginalColor = s_Renderer.material.color;
    }
    void OnMouseOver()
    {
        s_Renderer.material.color = m_MouseOverSprite;
      

    }

    void OnMouseExit()
    {
        s_Renderer.material.color = m_OriginalColor;
       

    }
}


