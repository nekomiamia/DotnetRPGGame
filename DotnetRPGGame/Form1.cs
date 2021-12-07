using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using DotnetRPGGame.Player;
using DotnetRPGGame.SaveFloder;

using DotnetRPGGame.EventFolder;
using RPGGameBLL;
using RPGGameModel.DataBase;

namespace DotnetRPGGame
{
    public partial class Form1 : Form
    {
        GameSaveData gamesavedata;
        private int maxiCountDownNumber = 30;
        private int roundNumber = 0;
        private int ackNumber = 0;
        private int charNumber = 4;
        private string username = "admin";
        private GameDataAccess _gameDataAccess = new GameDataAccess();
        internal SendMessge _sendMessge = new SendMessge();

        private gamedata _gamedata;
        
        
        public Form1()
        {
            InitializeComponent();
            InitializeGame();
        }

        private void InitializeData()
        {
            
        }
        
        private void InitializeGame()
        {
            roundNumber = 0;
            ackNumber = 0;
            _sendMessge.PassIntToFrmMainEvent += new SendMessge.PassIntToFrmMainEventHandler(GetUsername);
            this.Text = username;
            this.countDownlbl.Text = maxiCountDownNumber.ToString();
            InitializeCharacters();//初始化界面
            UpdateInformation();//初始化信息
            UpdateRoundNumber();//更新回合数
            UpdateHealthBar();//更新血条
            InitializePoint();//更新图片位置
        }

        private void InitializePoint()
        {
            heroOnePic.Location = new Point(26,77);
            heroTwoPic.Location = new Point(26,233);
            monsterOnePic.Location = new Point(432,77);
            monsterTwoPic.Location = new Point(432,233);
        }
        
        
        private void InitializeCharacters()
        {
            this.heroOne = new SeaDoge(this.heroOnePic.Location,this.heroOnePic.Location);
            this.heroTwo = new SleepDoge(this.heroTwoPic.Location,this.heroTwoPic.Location);
            this.monsterOne = new FireDragon(this.monsterOnePic.Location,this.monsterOnePic.Location);
            this.monsterTwo = new GunDragon(this.monsterTwoPic.Location,this.monsterTwoPic.Location);
            dic = new Dictionary<string, NPC>();
            dic.Add("heroOne",this.heroOne);
            dic.Add("heroTwo",this.heroTwo);
            dic.Add("monsterOne",this.monsterOne);
            dic.Add("monsterTwo",this.monsterTwo);
            _list = new List<NPC>();
            _list.Add(this.heroOne);
            _list.Add(this.heroTwo);
            _list.Add(this.monsterOne);
            _list.Add(this.monsterTwo);
            ListSort(_list);
        }

        private void ListSort(List<NPC> list)
        {
            int len = list.Count;
            list.Sort();
            foreach (NPC npc in list)
            {
                Debug.WriteLine(npc.Nickname+" "+npc.Speed);
            }
        }

        public void GetUsername(string username)
        {
            this.username = username;
            this.Text = username;
        }
        
        private void UpdateInformation()
        {
            this.heroOneNamelbl.Text = heroOne.Nickname + "     " + heroOne.Nowhp + "/" + heroOne.Maxhp;
            this.heroTwoNamelbl.Text = heroTwo.Nickname + "     " + heroTwo.Nowhp + "/" + heroTwo.Maxhp;
            this.monsterOneNamelbl.Text = monsterOne.Nickname + "     " + monsterOne.Nowhp + "/" + monsterOne.Maxhp;
            this.monsterTwoNamelbl.Text = monsterTwo.Nickname + "     " + monsterTwo.Nowhp + "/" + monsterTwo.Maxhp;
        }

        private void UpdateRoundNumber()
        {
            this.roundNumlbl.Text = "第" + (roundNumber+1) + "回合";
            this.whoNowRoundActinglbl.Text = "轮到你了 " + _list[roundNumber % 4].Nickname;
        }

        private void UpdateHealthBar()
        {
            
            heroOneHPlbl.Width = (int) (130 * (heroOne.Nowhp / heroOne.Maxhp));
            heroTwoHPlbl.Width = (int) (130 * (heroTwo.Nowhp / heroTwo.Maxhp));
            monsterOneHPlbl.Width = (int) (130 * (monsterOne.Nowhp / monsterOne.Maxhp));
            monsterTwoHPlbl.Width = (int) (130 * (monsterTwo.Nowhp / monsterTwo.Maxhp));

        }
        
        private void label1_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }
        
     
        
        
        private void heroOnePic_MouseEnter(object sender, EventArgs e)
        {
            PictureBox pic = sender as PictureBox;
            try
            {
                string charName = pic.Name.Replace("Pic", "");
                NPC npc = dic[charName];
                inforName.Text = "名字：" + npc.Nickname;
                inforAtk.Text = "攻击力：" + npc.Atk + "+" + npc.Weapon.WeaponAtk;
                inforAc.Text = "护甲值：" + npc.Ac + "+" + npc.Weapon.WeaponAc ;
                inforHP.Text = "血量：" + npc.Nowhp + "/" + npc.Maxhp;
                inforWeapon.Text = "武器：" + npc.Weapon.WeaponName;
                inforLucky.Text = "暴击率：" + npc.Weapon.Lucky + "%";
                inforSpeed.Text = "速度：" + npc.Speed;

            }
            catch (NotImplementedException notImplementedException)
            {
                Console.WriteLine(notImplementedException);
                throw;
            }
        }


        private void inforHP_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void countDownTimer_Elapsed(object sender, ElapsedEventArgs e)
        {
            int i;
            if (countDownlbl.Text.Equals("0"))
            {
                countDownlbl.Text = maxiCountDownNumber.ToString();
                roundNumber++;
                ackNumber++;
                selectPanel.Visible = false;
                UpdateRoundNumber();
            }
            else
            {
                int.TryParse(countDownlbl.Text, out i);
                i--;
                countDownlbl.Text = i.ToString();
            }
        }

        private void skillOnebtn_Click(object sender, EventArgs e)
        {
            if (ackNumber == roundNumber)
            {
                Button btn = (Button) sender;
                skillName.Text = btn.Text;
                NPC npc = _list[roundNumber % charNumber];
                if (npc.GetType() == typeof(SeaDoge)||npc.GetType() == typeof(SleepDoge))
                {
                    selectOnebtn.Text = monsterOne.Nickname;
                    selectTwobtn.Text = monsterTwo.Nickname;
                }
                else
                {
                    selectOnebtn.Text = heroOne.Nickname;
                    selectTwobtn.Text = heroTwo.Nickname;
                }
                selectPanel.Visible = true;
            }
        }

        
        
        private void skillName_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void selectOnebtn_Click(object sender, EventArgs e)
        {
            Debug.WriteLine(ackNumber+" "+roundNumber);
            Button btn = (Button) sender;
            string targetCharNickname = btn.Text;
            switch (btn.Text)
            {
                case "火龙" :
                    targetCharNickname = "monsterOne";
                    break;
                case "枪龙" :
                    targetCharNickname = "monsterTwo";
                    break;
                case "海狗" :
                    targetCharNickname = "heroOne";
                    break;
                case "睡狗" :
                    targetCharNickname = "heroTwo";
                    break;
                default: break;
            }
            Debug.WriteLine(targetCharNickname);
            NPC targeNpc = dic[targetCharNickname];
            NPC thisNpc = _list[roundNumber % charNumber];
            MovePicture(thisNpc,targeNpc);
            selectPanel.Visible = false;
            
        }

        private void MovePicture(NPC npc1, NPC npc2)
        {
            npc1.InAcking = true;
            Tuple<bool,double> hurtDamageTuple = npc1.SuperAck(npc2);
            Debug.WriteLine(npc2.Nickname);
            Debug.WriteLine("海狗血量:"+heroOne.Nowhp);
            CreatDamageLable(npc1.Nickname,npc2.Nickname,skillName.Text,hurtDamageTuple.Item2,true, hurtDamageTuple.Item1);
            ackNumber = roundNumber + 1;
            charMoveTimer.Start();
        }
        
        private void CreatDamageLable(string thisNpcName,string targeNpcName,string skill,double damage,bool isHurt,bool isSuper)
        {
            string str1 = "造成了", str2 = "点";
            string str3 = "伤害", str4 = "";
            if (!isHurt)
            {
                str1 = "恢复了";
                str2 = "点";
            }

            if (isSuper)
            {
                str4 = "暴击";
            }
            damageTextlbl.Text = thisNpcName + "使用" + skill +"对" + targeNpcName + str1 + damage + str2 + str4 + str3;
        }

        private void damageTimer1_Elapsed(object sender, ElapsedEventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void charMoveTimer_Elapsed(object sender, ElapsedEventArgs e)
        {
            string picName = "";
            foreach (string key in dic.Keys)
            {
                if (dic[key].Equals(_list[roundNumber%charNumber]))
                {
                    picName = key + "Pic";
                    break;
                }
            }
            
            Control npcpic = Controls.Find(picName, true)[0];
            NPC npc = _list[roundNumber % charNumber];
            int x_now = npc.SelfCoordinate.X, y_now = npc.SelfCoordinate.Y;
            int x_target = npc.TargetCoordinate.X, y_target = npc.TargetCoordinate.Y;
            int x_pic = npcpic.Location.X, y_pic = npcpic.Location.Y;
            int x_step = (x_target - x_now) / 10, y_step = (y_target - y_now) / 10;
            int maxY = y_target + 100, minY = y_target - 10;
            int maxX = x_target + 100, minX = x_target - 20;
            Debug.WriteLine(monsterOnePic.Location);
            if (npc.InAcking&&(x_pic < minX || x_pic > maxX))
            {
                npcpic.Location = new Point(x_pic + x_step, y_pic + y_step);
            }
            else if(x_pic >= minX && x_pic <= maxX)
            {
                UpdateHealthBar();
                UpdateInformation();
                if (npc.InAcking)
                {
                    npcpic.Location = new Point(x_pic - x_step, y_pic - y_step);
                }
                npc.InAcking = false;
            }else if (!npc.InAcking)
            {
                if (x_step>0 && x_pic > x_now)
                {
                    npcpic.Location = new Point(x_pic - x_step, y_pic - y_step);
                }
                else if (x_step < 0 && x_pic < x_now)
                {
                    npcpic.Location = new Point(x_pic - x_step, y_pic - y_step);
                } else
                {
                    roundNumber++;
                    countDownlbl.Text = maxiCountDownNumber.ToString();
                    UpdateRoundNumber();
                    charMoveTimer.Stop();
                }
            }
           
            
        }
        
        private void savebtn_Click(object sender, EventArgs e)
        {
            gamesavedata = new GameSaveData(roundNumber, ackNumber, monsterOne, monsterTwo, heroOne, heroTwo);
            _gamedata = new gamedata();
            _gamedata.Username = this.username;
            _gamedata.Data = new ByteTurnGameSaveData().GToByte(gamesavedata);
            if (_gameDataAccess.SaveGamedata(_gamedata))
            {
                MessageBox.Show("存档成功!");
            }
            else
            {
                MessageBox.Show("存档失败!");
            }
        }

        private void readbtn_Click(object sender, EventArgs e)
        {
            _gamedata = new gamedata();
            _gamedata.Username = this.username;
            _gamedata = _gameDataAccess.ReadGamedata(_gamedata);
            if (_gamedata==null)
            {
                MessageBox.Show("尚未拥有存档!");
            }
            else
            {
                gamesavedata = new ByteTurnGameSaveData().BToGameSaveData(_gamedata.Data);
                MessageBox.Show("读档成功!");
                this.heroOne = gamesavedata.H1;
                this.heroTwo = gamesavedata.H2;
                this.monsterOne = gamesavedata.M1;
                this.monsterTwo = gamesavedata.M2;
                this.roundNumber = gamesavedata.SaveRoundNumber;
                this.ackNumber = gamesavedata.SaveAckNumber;
                dic = new Dictionary<string, NPC>();
                dic.Add("heroOne", this.heroOne);
                dic.Add("heroTwo", this.heroTwo);
                dic.Add("monsterOne", this.monsterOne);
                dic.Add("monsterTwo", this.monsterTwo);
                _list = new List<NPC>();
                _list.Add(this.heroOne);
                _list.Add(this.heroTwo);
                _list.Add(this.monsterOne);
                _list.Add(this.monsterTwo);
                ListSort(_list);
                UpdateInformation();
                UpdateHealthBar();
                UpdateRoundNumber();
            }
        }

        private void heroOneHPlbl_Resize(object sender, EventArgs e)
        {
            Label lbl = (Label) sender;
            if (lbl.Width == 0)
            {
                MessageBox.Show("Game Over!");
                NPC npc = _list[roundNumber % charNumber];
                npc.InAcking = false;
                charMoveTimer.Enabled = false;
                InitializeGame();
                Debug.WriteLine("init-----------------");
                Debug.WriteLine(monsterOnePic.Location);
                Debug.WriteLine(monsterOne.SelfCoordinate);
                Debug.WriteLine("overInit-----------------");
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Environment.Exit(0);
        }
    }
}