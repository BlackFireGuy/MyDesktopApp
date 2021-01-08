using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
/// <summary>
/// 1时间
/// 开机自启启动时间
/// 2计时
/// 3倒计时
/// /倒计时有开始和结束两种状态
/// /手动录入倒计的时长和要干的事情 开始不可重来 但是可以暂停
/// /每分钟保存一次倒计时的时间
/// /开始自动读取上次倒计的时长和剩余时长
/// /还有子倒计时
/// </summary>
public class Timer : MonoBehaviour
{
    public Text time;

    private float timer = 0f;

    private int h = 0;

    private int m = 0;

    private int s = 0;

    private string timeStr = string.Empty;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= 1f)
        {
            s++;
            timer = 0;
        }
        if (s >= 60)
        {
            m++;
            s = 0;
        }
        if (m >= 60)
        {
            h++;
            m = 0;
        }
        if (h >= 99)
        {
            h = 0;
        }
        //计时器
        time.text = timeStr;
        //倒计时器
    }



}
