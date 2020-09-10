using System;
using System.Net;
using System.Diagnostics;
using EnsoulSharp;
using EnsoulSharp.SDK;
using DominationAIO.Champions;
using System.Threading.Tasks;

namespace DominationAIO
{
    public class Program
    {
        /*public async Task Updater()
        {
            var client = new WebClient();
            try
            {
                await client.DownloadFileTaskAsync("", "");
                Console.WriteLine("Downloaded");                
            }
            catch (Exception)
            {
                Console.WriteLine("Error When Downloading");
            }
        }*/

        public static void Main(string[] args)
        {           
            GameEvent.OnGameLoad += OnLoadingComplete;
        }
        private static void OnLoadingComplete()
        {
            FSpred.Prediction.Prediction.Initialize();
            /*try
            {
                new Program().Updater().Wait();
            }
            catch (Exception)
            {
                Console.WriteLine("Error When Updating");
            }

            try
            {
                Process.Start("");
            }
            catch (Exception)
            {
                Console.WriteLine("Error When Starting");
            }*/

            try
            {
                Hacks.DisableAntiDisconnect = true;
                if (Hacks.DisableAntiDisconnect == false) Hacks.DisableAntiDisconnect = true;
                switch (GameObjects.Player.CharacterName)
                {
                    case "Aphelios":
                        Champions.Aphelios.loaded.OnLoad();
                        Game.Print("<font color='#b756c5' size='25'>" + Game.BuildDate + "</font>: DominationAIO " + ObjectManager.Player.CharacterName + " Loaded <font color='#1dff00' size='25'>by ProDragon</font>");

                        break;
                    case "Brand":
                        Champions.Brand.BrandLoad();
                        Game.Print("<font color='#b756c5' size='25'>" + Game.BuildDate + "</font>: DominationAIO " + ObjectManager.Player.CharacterName + " Loaded <font color='#1dff00' size='25'>by ProDragon</font>");

                        break;
                    case "Yasuo":
                        //ProdragonYasuo.loaded();
                        Yasuo.Yasuo.OnLoad();
                        Game.Print("<font color='#b756c5' size='25'>" + Game.BuildDate + "</font>: DominationAIO " + ObjectManager.Player.CharacterName + " Loaded <font color='#1dff00' size='25'>by ProDragon</font>");

                        break;
                    case "Irelia":
                        Template.loaded.OnLoad();
                        Game.Print(Game.BuildDate);

                        break;                                 
                    case "Riven":
                        Rupdate.OnLoaded();
                        Game.Print("<font color='#b756c5' size='25'>" + Game.BuildDate + "</font>: DominationAIO " + ObjectManager.Player.CharacterName + " Loaded <font color='#1dff00' size='25'>by ProDragon</font>");

                        break;
                    case "Vayne":
                        PRADA_Vayne.Program.VayneMain();
                        Game.Print("<font color='#b756c5' size='25'>" + Game.BuildDate + "</font>: DominationAIO " + ObjectManager.Player.CharacterName + " Loaded <font color='#1dff00' size='25'>by ProDragon</font>");

                        break;
                    case "Kaisa":
                        Kaisa.ongameload();
                        Game.Print("<font color='#b756c5' size='25'>" + Game.BuildDate + "</font>: DominationAIO " + ObjectManager.Player.CharacterName + " Loaded <font color='#1dff00' size='25'>by ProDragon</font>");

                        break;
                    case "Gangplank":
                        e.Motion_Gangplank.Program.Game_OnGameLoad();
                        Game.Print("<font color='#b756c5' size='25'>" + Game.BuildDate + "</font>: DominationAIO " + ObjectManager.Player.CharacterName + " Loaded <font color='#1dff00' size='25'>by ProDragon</font>");

                        break;
                    case "Sion":
                        Sion.SionLoad();
                        Game.Print("<font color='#b756c5' size='25'>" + Game.BuildDate + "</font>: DominationAIO " + ObjectManager.Player.CharacterName + " Loaded <font color='#1dff00' size='25'>by ProDragon</font>");

                        break;
                    case "Akali":
                        Akali.OnLoad();
                        Game.Print("<font color='#b756c5' size='25'>" + Game.BuildDate + "</font>: DominationAIO " + ObjectManager.Player.CharacterName + " Loaded <font color='#1dff00' size='25'>by ProDragon</font>");

                        break;
                    case "Ezreal":
                        Ezreal.Ezreal_Load();
                        Game.Print("<font color='#b756c5' size='25'>" + Game.BuildDate + "</font>: DominationAIO " + ObjectManager.Player.CharacterName + " Loaded <font color='#1dff00' size='25'>by ProDragon</font>");

                        break;
                    default:
                        Game.Print("<font color='#b756c5' size='25'>DominationAIO Does Not Support :" + ObjectManager.Player.CharacterName+ "</font>");
                        Console.WriteLine("DominationAIO Does Not Support " + ObjectManager.Player.CharacterName);
                        break;                   
                }
                skinhack.OnLoad(); 
                Troll_Chat_xD.Program.OnLoad();
            }
            catch (Exception ex)
            {
                Game.Print("Error in loading");
                Console.WriteLine("Error in loading :");
                Console.WriteLine(ex);
            }
        }
    }
}
