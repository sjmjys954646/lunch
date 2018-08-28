using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Database : MonoBehaviour
{
    public List<Info> Shop = new List<Info>();

    //1.몇번 2.식당이름 3.음식종류 4.위치 5.가격 6.배달음식
    public class Info
    {
        public int Num;
        public string Storename, Foodkind, Pos, Price;
        public bool Deliever;

        public Info(int a, string b, string c, string d, string e, bool f)
        {
            Num = a;
            Storename = b;
            Foodkind = c;
            Pos = d;
            Price = e;
            Deliever = f;
        }
    }

    private void Start()
    {
        WriteInfo();
    }
   
    public void WriteInfo()
    {
        Shop.Add(new Info(1,"스피드반점", "중식", "쪽문", "하", false));
        Shop.Add(new Info(2, "밥스", "퓨전", "쪽문", "하", false));
        Shop.Add(new Info(3, "털보하우스", "퓨전", "쪽문", "하", false));
        Shop.Add(new Info(4, "용봉골", "한식", "쪽문", "하", false));
        Shop.Add(new Info(5, "얌얌", "양식", "쪽문", "중", false));
        Shop.Add(new Info(6, "석쇠쌈밥", "한식", "쪽문", "하", false));
        Shop.Add(new Info(7, "부리또", "양식", "쪽문", "하", false));
        Shop.Add(new Info(8, "사랑방하우스", "한식", "쪽문", "하", false));
        Shop.Add(new Info(9, "나들목국밥", "한식", "쪽문", "중", false));
        Shop.Add(new Info(10, "파리에다녀온치킨", "치킨", "쪽문", "상", false));
    }
}


