using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using DotnetRPGGame.Player;

namespace DotnetRPGGame
{
    public partial class Form1 : Form
    {

        private int maxiCountDownNumber = 10;
        private int roundNumber = 0;
        private int charNumber = 4;
        public Form1()
        {
            InitializeComponent();
            InitializeGame();
        }

        private void InitializeGame()
        {
            this.countDownlbl.Text = maxiCountDownNumber.ToString();
            InitializeCharacters();//初始化界面
            UpdateInformation();//初始化信息
            UpdateRoundNumber();//更新回合数
        }

        private void InitializeCharacters()
        {
            this.heroOne = new SeaDoge(this.heroOnePic.Location,this.heroOnePic.Location);
            this.heroTwo = new SleepDoge(this.heroTwoPic.Location,this.heroTwoPic.Location);
            this.monsterOne = new FireDragon(this.monsterOnePic.Location,this.monsterOnePic.Location);
            this.monsterTwo = new GunDragon(this.monsterTwoPic.Location,this.monsterTwoPic.Location);
            dic.Add("heroOne",this.heroOne);
            dic.Add("heroTwo",this.heroTwo);
            dic.Add("monsterOne",this.monsterOne);
            dic.Add("monsterTwo",this.monsterTwo);
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
        
        private void UpdateInformation()
        {
            this.heroOneNamelbl.Text = heroOne.Nickname + "         " + heroOne.Nowhp + "/" + heroOne.Maxhp;
            this.heroTwoNamelbl.Text = heroTwo.Nickname + "         " + heroTwo.Nowhp + "/" + heroTwo.Maxhp;
            this.monsterOneNamelbl.Text = monsterOne.Nickname + "         " + monsterOne.Nowhp + "/" + monsterOne.Maxhp;
            this.monsterTwoNamelbl.Text = monsterTwo.Nickname + "         " + monsterTwo.Nowhp + "/" + monsterTwo.Maxhp;
        }

        private void UpdateRoundNumber()
        {
            this.roundNumlbl.Text = "第" + (roundNumber+1) + "回合";
            this.whoNowRoundActinglbl.Text = "轮到你了 " + _list[roundNumber % 4].Nickname;
        }

        private void UpdateHealthBar()
        {
            Debug.WriteLine(label1.Width);
            Debug.WriteLine(heroOneHPlbl.Width);
            Debug.WriteLine("↓");
            heroOneHPlbl.Width = (int) (130 * (heroOne.Nowhp / heroOne.Maxhp));
            heroTwoHPlbl.Width = (int) (130 * (heroTwo.Nowhp / heroTwo.Maxhp));
            monsterOneHPlbl.Width = (int) (130 * (monsterOne.Nowhp / monsterOne.Maxhp));
            monsterTwoHPlbl.Width = (int) (130 * (monsterTwo.Nowhp / monsterTwo.Maxhp));
            Debug.WriteLine(heroOneHPlbl.Width);
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

        private void skillName_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void selectOnebtn_Click(object sender, EventArgs e)
        {
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
            double hurtDamage = thisNpc.Hurt(targeNpc);
            CreatDamageLable(thisNpc.Nickname,targeNpc.Nickname,skillName.Text,hurtDamage,true);
            UpdateHealthBar();
            UpdateInformation();
            roundNumber++;
            countDownlbl.Text = maxiCountDownNumber.ToString();
            UpdateRoundNumber();
            selectPanel.Visible = false;
        }

        private void CreatDamageLable(string thisNpcName,string targeNpcName,string skill,double damage,bool isHurt)
        {
            string str1 = "造成了", str2 = "点伤害";
            if (!isHurt)
            {
                str1 = "恢复了";
                str2 = "点血量";
            }
            damageTextlbl.Text = thisNpcName + "使用" + skill +"对" + targeNpcName + str1 + damage + str2;
        }

        private void damageTimer1_Elapsed(object sender, ElapsedEventArgs e)
        {
            throw new System.NotImplementedException();
        }
    }
}