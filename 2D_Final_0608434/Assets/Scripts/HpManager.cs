using UnityEngine;
using UnityEngine.UI;
using System.Collections;


public class HpManager : MonoBehaviour
{
    public Image bar;
    public RectTransform rectDamage;

    public void UpdateHpBar(float hp,float hpMax)
    {

        bar.fillAmount = hp / hpMax;

    }


    public IEnumerator ShowDamage(float damage)
    {
        RectTransform rect =Instantiate(rectDamage, transform);
        rect.anchoredPosition = new Vector2(0, -240);
        rect.GetComponent<Text>().text = damage.ToString();

        float y = rect.anchoredPosition.y;
        while (y<-100)
        {
            y += 20;
            rect.anchoredPosition = new Vector2(0, y);
            yield return new WaitForSeconds(0.02f);


        }
        Destroy(rect.gameObject);
    }

}
