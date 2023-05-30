using UnityEngine;
using UnityEngine.UI;

public class aaa : MonoBehaviour
{
    public Image timeGauge;
    public float time = 100.0f;

    // Start is called before the first frame update
    void Start()
    {
        // Time_gaugeのImageコンポーネントを取得
        timeGauge = GameObject.Find("Time_gauge").GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        // 時間の減少処理
        time -= Time.deltaTime;
        this.timeGauge.GetComponent<Image>().fillAmount = time / 100.0f; // タイムゲージの表示を更新
    }
}