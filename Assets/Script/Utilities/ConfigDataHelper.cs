using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class ConfigDataHelper
{
    private static GameConfig gameConfig = null;
    public static GameConfig GameConfig
    {
        get
        {
            if (gameConfig == null)
                gameConfig = JsonConvert.DeserializeObject<GameConfig>(Resources.Load<TextAsset>("Data/GameConfig").text);
            return gameConfig;
        }
    }
    //private static HeroData heroData = null;
    //public static HeroData HeroData
    //{
    //    get
    //    {
    //        //heroData = GetHeroData();
    //        //ES3.Save("HeroDatas", GetHeroData());

    //        if (!ES3.KeyExists("HeroDatas"))
    //        {
    //            heroData = GetHeroData();
    //            ES3.Save("HeroDatas", GetHeroData());
    //        }
    //        else
    //        {
    //            heroData = ES3.Load<HeroData>("HeroDatas");
    //        }
    //        return heroData;
    //    }
    //    set => ES3.Save("HeroDatas", value);
    //}
}
