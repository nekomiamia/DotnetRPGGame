using System.Collections.Generic;
using DotnetRPGGame.Player;

namespace DotnetRPGGame
{
  partial class Form1
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.lable1 = new System.Windows.Forms.Label();
      this.heroOneHPlbl = new System.Windows.Forms.Label();
      this.heroOneNamelbl = new System.Windows.Forms.Label();
      this.heroTwoNamelbl = new System.Windows.Forms.Label();
      this.heroTwoHPlbl = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.heroTwoPic = new System.Windows.Forms.PictureBox();
      this.monsterOneNamelbl = new System.Windows.Forms.Label();
      this.monsterOneHPlbl = new System.Windows.Forms.Label();
      this.label7 = new System.Windows.Forms.Label();
      this.monsterOnePic = new System.Windows.Forms.PictureBox();
      this.monsterTwoNamelbl = new System.Windows.Forms.Label();
      this.monsterTwoHPlbl = new System.Windows.Forms.Label();
      this.label10 = new System.Windows.Forms.Label();
      this.monsterTwoPic = new System.Windows.Forms.PictureBox();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.panel5 = new System.Windows.Forms.Panel();
      this.readbtn = new System.Windows.Forms.Button();
      this.savebtn = new System.Windows.Forms.Button();
      this.whoNowRoundActinglbl = new System.Windows.Forms.Label();
      this.skillOnebtn = new System.Windows.Forms.Button();
      this.roundNumlbl = new System.Windows.Forms.Label();
      this.countDownlbl = new System.Windows.Forms.Label();
      this.InforPanel = new System.Windows.Forms.Panel();
      this.damageTextlbl = new System.Windows.Forms.Label();
      this.inforSpeed = new System.Windows.Forms.Label();
      this.inforLucky = new System.Windows.Forms.Label();
      this.inforWeapon = new System.Windows.Forms.Label();
      this.inforHP = new System.Windows.Forms.Label();
      this.inforAc = new System.Windows.Forms.Label();
      this.inforAtk = new System.Windows.Forms.Label();
      this.inforName = new System.Windows.Forms.Label();
      this.selectPanel = new System.Windows.Forms.Panel();
      this.selectTwobtn = new System.Windows.Forms.Button();
      this.selectOnebtn = new System.Windows.Forms.Button();
      this.skillName = new System.Windows.Forms.Label();
      this.countDownTimer = new System.Timers.Timer();
      this.charMoveTimer = new System.Timers.Timer();
      this.heroOnePic = new System.Windows.Forms.PictureBox();
      ((System.ComponentModel.ISupportInitialize) (this.heroTwoPic)).BeginInit();
      ((System.ComponentModel.ISupportInitialize) (this.monsterOnePic)).BeginInit();
      ((System.ComponentModel.ISupportInitialize) (this.monsterTwoPic)).BeginInit();
      this.panel5.SuspendLayout();
      this.InforPanel.SuspendLayout();
      this.selectPanel.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize) (this.countDownTimer)).BeginInit();
      ((System.ComponentModel.ISupportInitialize) (this.charMoveTimer)).BeginInit();
      ((System.ComponentModel.ISupportInitialize) (this.heroOnePic)).BeginInit();
      this.SuspendLayout();
      // 
      // lable1
      // 
      this.lable1.BackColor = System.Drawing.Color.OrangeRed;
      this.lable1.Location = new System.Drawing.Point(34, 81);
      this.lable1.Margin = new System.Windows.Forms.Padding(0);
      this.lable1.Name = "lable1";
      this.lable1.Size = new System.Drawing.Size(173, 12);
      this.lable1.TabIndex = 0;
      // 
      // heroOneHPlbl
      // 
      this.heroOneHPlbl.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (128)))), ((int) (((byte) (255)))), ((int) (((byte) (128)))));
      this.heroOneHPlbl.Location = new System.Drawing.Point(34, 81);
      this.heroOneHPlbl.Margin = new System.Windows.Forms.Padding(0);
      this.heroOneHPlbl.Name = "heroOneHPlbl";
      this.heroOneHPlbl.Size = new System.Drawing.Size(173, 12);
      this.heroOneHPlbl.TabIndex = 2;
      this.heroOneHPlbl.Resize += new System.EventHandler(this.heroOneHPlbl_Resize);
      // 
      // heroOneNamelbl
      // 
      this.heroOneNamelbl.Location = new System.Drawing.Point(34, 63);
      this.heroOneNamelbl.Name = "heroOneNamelbl";
      this.heroOneNamelbl.Size = new System.Drawing.Size(173, 18);
      this.heroOneNamelbl.TabIndex = 9;
      this.heroOneNamelbl.Text = "狗狗";
      // 
      // heroTwoNamelbl
      // 
      this.heroTwoNamelbl.Location = new System.Drawing.Point(34, 257);
      this.heroTwoNamelbl.Name = "heroTwoNamelbl";
      this.heroTwoNamelbl.Size = new System.Drawing.Size(173, 18);
      this.heroTwoNamelbl.TabIndex = 13;
      this.heroTwoNamelbl.Text = "狗狗";
      // 
      // heroTwoHPlbl
      // 
      this.heroTwoHPlbl.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (128)))), ((int) (((byte) (255)))), ((int) (((byte) (128)))));
      this.heroTwoHPlbl.Location = new System.Drawing.Point(34, 275);
      this.heroTwoHPlbl.Margin = new System.Windows.Forms.Padding(0);
      this.heroTwoHPlbl.Name = "heroTwoHPlbl";
      this.heroTwoHPlbl.Size = new System.Drawing.Size(173, 12);
      this.heroTwoHPlbl.TabIndex = 12;
      // 
      // label4
      // 
      this.label4.BackColor = System.Drawing.Color.OrangeRed;
      this.label4.Location = new System.Drawing.Point(34, 275);
      this.label4.Margin = new System.Windows.Forms.Padding(0);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(173, 12);
      this.label4.TabIndex = 10;
      // 
      // heroTwoPic
      // 
      this.heroTwoPic.Image = global::DotnetRPGGame.Properties.Resources.困狗;
      this.heroTwoPic.Location = new System.Drawing.Point(34, 291);
      this.heroTwoPic.Name = "heroTwoPic";
      this.heroTwoPic.Size = new System.Drawing.Size(173, 131);
      this.heroTwoPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
      this.heroTwoPic.TabIndex = 3;
      this.heroTwoPic.TabStop = false;
      this.heroTwoPic.MouseEnter += new System.EventHandler(this.heroOnePic_MouseEnter);
      // 
      // monsterOneNamelbl
      // 
      this.monsterOneNamelbl.Location = new System.Drawing.Point(576, 63);
      this.monsterOneNamelbl.Name = "monsterOneNamelbl";
      this.monsterOneNamelbl.Size = new System.Drawing.Size(173, 18);
      this.monsterOneNamelbl.TabIndex = 17;
      this.monsterOneNamelbl.Text = "狗狗";
      // 
      // monsterOneHPlbl
      // 
      this.monsterOneHPlbl.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (128)))), ((int) (((byte) (255)))), ((int) (((byte) (128)))));
      this.monsterOneHPlbl.Location = new System.Drawing.Point(576, 81);
      this.monsterOneHPlbl.Margin = new System.Windows.Forms.Padding(0);
      this.monsterOneHPlbl.Name = "monsterOneHPlbl";
      this.monsterOneHPlbl.Size = new System.Drawing.Size(173, 12);
      this.monsterOneHPlbl.TabIndex = 16;
      // 
      // label7
      // 
      this.label7.BackColor = System.Drawing.Color.OrangeRed;
      this.label7.Location = new System.Drawing.Point(576, 81);
      this.label7.Margin = new System.Windows.Forms.Padding(0);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(173, 12);
      this.label7.TabIndex = 14;
      // 
      // monsterOnePic
      // 
      this.monsterOnePic.Image = global::DotnetRPGGame.Properties.Resources.喷火龙3;
      this.monsterOnePic.Location = new System.Drawing.Point(576, 96);
      this.monsterOnePic.Name = "monsterOnePic";
      this.monsterOnePic.Size = new System.Drawing.Size(173, 131);
      this.monsterOnePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
      this.monsterOnePic.TabIndex = 2;
      this.monsterOnePic.TabStop = false;
      this.monsterOnePic.MouseEnter += new System.EventHandler(this.heroOnePic_MouseEnter);
      // 
      // monsterTwoNamelbl
      // 
      this.monsterTwoNamelbl.Location = new System.Drawing.Point(576, 257);
      this.monsterTwoNamelbl.Name = "monsterTwoNamelbl";
      this.monsterTwoNamelbl.Size = new System.Drawing.Size(173, 18);
      this.monsterTwoNamelbl.TabIndex = 21;
      this.monsterTwoNamelbl.Text = "狗狗";
      // 
      // monsterTwoHPlbl
      // 
      this.monsterTwoHPlbl.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (128)))), ((int) (((byte) (255)))), ((int) (((byte) (128)))));
      this.monsterTwoHPlbl.Location = new System.Drawing.Point(576, 275);
      this.monsterTwoHPlbl.Margin = new System.Windows.Forms.Padding(0);
      this.monsterTwoHPlbl.Name = "monsterTwoHPlbl";
      this.monsterTwoHPlbl.Size = new System.Drawing.Size(173, 12);
      this.monsterTwoHPlbl.TabIndex = 20;
      // 
      // label10
      // 
      this.label10.BackColor = System.Drawing.Color.OrangeRed;
      this.label10.Location = new System.Drawing.Point(576, 275);
      this.label10.Margin = new System.Windows.Forms.Padding(0);
      this.label10.Name = "label10";
      this.label10.Size = new System.Drawing.Size(173, 12);
      this.label10.TabIndex = 18;
      // 
      // monsterTwoPic
      // 
      this.monsterTwoPic.Image = global::DotnetRPGGame.Properties.Resources.时代变了_大人;
      this.monsterTwoPic.Location = new System.Drawing.Point(576, 291);
      this.monsterTwoPic.Name = "monsterTwoPic";
      this.monsterTwoPic.Size = new System.Drawing.Size(173, 131);
      this.monsterTwoPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
      this.monsterTwoPic.TabIndex = 4;
      this.monsterTwoPic.TabStop = false;
      this.monsterTwoPic.MouseEnter += new System.EventHandler(this.heroOnePic_MouseEnter);
      // 
      // label1
      // 
      this.label1.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
      this.label1.Location = new System.Drawing.Point(34, 21);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(209, 29);
      this.label1.TabIndex = 22;
      this.label1.Text = "狗狗英雄队";
      this.label1.Click += new System.EventHandler(this.label1_Click);
      // 
      // label2
      // 
      this.label2.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
      this.label2.Location = new System.Drawing.Point(576, 21);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(205, 29);
      this.label2.TabIndex = 23;
      this.label2.Text = "龙龙怪物队";
      this.label2.Click += new System.EventHandler(this.label2_Click);
      // 
      // panel5
      // 
      this.panel5.BackColor = System.Drawing.Color.MediumTurquoise;
      this.panel5.Controls.Add(this.readbtn);
      this.panel5.Controls.Add(this.savebtn);
      this.panel5.Controls.Add(this.whoNowRoundActinglbl);
      this.panel5.Controls.Add(this.skillOnebtn);
      this.panel5.Controls.Add(this.roundNumlbl);
      this.panel5.Location = new System.Drawing.Point(5, 473);
      this.panel5.Name = "panel5";
      this.panel5.Size = new System.Drawing.Size(776, 196);
      this.panel5.TabIndex = 24;
      // 
      // readbtn
      // 
      this.readbtn.BackColor = System.Drawing.Color.DarkCyan;
      this.readbtn.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
      this.readbtn.ForeColor = System.Drawing.SystemColors.Control;
      this.readbtn.Location = new System.Drawing.Point(597, 122);
      this.readbtn.Name = "readbtn";
      this.readbtn.Size = new System.Drawing.Size(124, 51);
      this.readbtn.TabIndex = 4;
      this.readbtn.Text = "读取进度";
      this.readbtn.UseVisualStyleBackColor = false;
      this.readbtn.Click += new System.EventHandler(this.readbtn_Click);
      // 
      // savebtn
      // 
      this.savebtn.BackColor = System.Drawing.Color.DarkCyan;
      this.savebtn.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
      this.savebtn.ForeColor = System.Drawing.SystemColors.Control;
      this.savebtn.Location = new System.Drawing.Point(597, 38);
      this.savebtn.Name = "savebtn";
      this.savebtn.Size = new System.Drawing.Size(124, 51);
      this.savebtn.TabIndex = 3;
      this.savebtn.Text = "保存进度";
      this.savebtn.UseVisualStyleBackColor = false;
      this.savebtn.Click += new System.EventHandler(this.savebtn_Click);
      // 
      // whoNowRoundActinglbl
      // 
      this.whoNowRoundActinglbl.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
      this.whoNowRoundActinglbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
      this.whoNowRoundActinglbl.Location = new System.Drawing.Point(168, 9);
      this.whoNowRoundActinglbl.Name = "whoNowRoundActinglbl";
      this.whoNowRoundActinglbl.Size = new System.Drawing.Size(437, 35);
      this.whoNowRoundActinglbl.TabIndex = 2;
      // 
      // skillOnebtn
      // 
      this.skillOnebtn.BackColor = System.Drawing.Color.DarkCyan;
      this.skillOnebtn.Font = new System.Drawing.Font("宋体", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
      this.skillOnebtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
      this.skillOnebtn.Location = new System.Drawing.Point(7, 47);
      this.skillOnebtn.Name = "skillOnebtn";
      this.skillOnebtn.Size = new System.Drawing.Size(195, 141);
      this.skillOnebtn.TabIndex = 1;
      this.skillOnebtn.Text = "普攻";
      this.skillOnebtn.UseVisualStyleBackColor = false;
      this.skillOnebtn.Click += new System.EventHandler(this.skillOnebtn_Click);
      // 
      // roundNumlbl
      // 
      this.roundNumlbl.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
      this.roundNumlbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
      this.roundNumlbl.Location = new System.Drawing.Point(7, 9);
      this.roundNumlbl.Name = "roundNumlbl";
      this.roundNumlbl.Size = new System.Drawing.Size(120, 35);
      this.roundNumlbl.TabIndex = 0;
      // 
      // countDownlbl
      // 
      this.countDownlbl.BackColor = System.Drawing.Color.Turquoise;
      this.countDownlbl.Font = new System.Drawing.Font("宋体", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
      this.countDownlbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
      this.countDownlbl.Location = new System.Drawing.Point(298, 9);
      this.countDownlbl.Name = "countDownlbl";
      this.countDownlbl.Size = new System.Drawing.Size(154, 44);
      this.countDownlbl.TabIndex = 25;
      this.countDownlbl.Text = "x";
      this.countDownlbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
      // 
      // InforPanel
      // 
      this.InforPanel.BackColor = System.Drawing.Color.MediumTurquoise;
      this.InforPanel.Controls.Add(this.damageTextlbl);
      this.InforPanel.Controls.Add(this.inforSpeed);
      this.InforPanel.Controls.Add(this.inforLucky);
      this.InforPanel.Controls.Add(this.inforWeapon);
      this.InforPanel.Controls.Add(this.inforHP);
      this.InforPanel.Controls.Add(this.inforAc);
      this.InforPanel.Controls.Add(this.inforAtk);
      this.InforPanel.Controls.Add(this.inforName);
      this.InforPanel.Location = new System.Drawing.Point(787, 12);
      this.InforPanel.Name = "InforPanel";
      this.InforPanel.Size = new System.Drawing.Size(344, 455);
      this.InforPanel.TabIndex = 26;
      // 
      // damageTextlbl
      // 
      this.damageTextlbl.BackColor = System.Drawing.Color.LightCyan;
      this.damageTextlbl.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
      this.damageTextlbl.Location = new System.Drawing.Point(7, 348);
      this.damageTextlbl.Name = "damageTextlbl";
      this.damageTextlbl.Size = new System.Drawing.Size(332, 96);
      this.damageTextlbl.TabIndex = 7;
      this.damageTextlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // inforSpeed
      // 
      this.inforSpeed.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
      this.inforSpeed.Location = new System.Drawing.Point(15, 320);
      this.inforSpeed.Name = "inforSpeed";
      this.inforSpeed.Size = new System.Drawing.Size(309, 28);
      this.inforSpeed.TabIndex = 6;
      // 
      // inforLucky
      // 
      this.inforLucky.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
      this.inforLucky.Location = new System.Drawing.Point(15, 270);
      this.inforLucky.Name = "inforLucky";
      this.inforLucky.Size = new System.Drawing.Size(309, 28);
      this.inforLucky.TabIndex = 5;
      // 
      // inforWeapon
      // 
      this.inforWeapon.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
      this.inforWeapon.Location = new System.Drawing.Point(15, 70);
      this.inforWeapon.Name = "inforWeapon";
      this.inforWeapon.Size = new System.Drawing.Size(309, 28);
      this.inforWeapon.TabIndex = 4;
      // 
      // inforHP
      // 
      this.inforHP.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
      this.inforHP.Location = new System.Drawing.Point(15, 220);
      this.inforHP.Name = "inforHP";
      this.inforHP.Size = new System.Drawing.Size(309, 28);
      this.inforHP.TabIndex = 3;
      this.inforHP.Click += new System.EventHandler(this.inforHP_Click);
      // 
      // inforAc
      // 
      this.inforAc.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
      this.inforAc.Location = new System.Drawing.Point(15, 170);
      this.inforAc.Name = "inforAc";
      this.inforAc.Size = new System.Drawing.Size(309, 28);
      this.inforAc.TabIndex = 2;
      // 
      // inforAtk
      // 
      this.inforAtk.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
      this.inforAtk.Location = new System.Drawing.Point(15, 120);
      this.inforAtk.Name = "inforAtk";
      this.inforAtk.Size = new System.Drawing.Size(309, 28);
      this.inforAtk.TabIndex = 1;
      // 
      // inforName
      // 
      this.inforName.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
      this.inforName.Location = new System.Drawing.Point(15, 20);
      this.inforName.Name = "inforName";
      this.inforName.Size = new System.Drawing.Size(309, 28);
      this.inforName.TabIndex = 0;
      // 
      // selectPanel
      // 
      this.selectPanel.BackColor = System.Drawing.Color.MediumAquamarine;
      this.selectPanel.Controls.Add(this.selectTwobtn);
      this.selectPanel.Controls.Add(this.selectOnebtn);
      this.selectPanel.Controls.Add(this.skillName);
      this.selectPanel.Location = new System.Drawing.Point(787, 473);
      this.selectPanel.Name = "selectPanel";
      this.selectPanel.Size = new System.Drawing.Size(344, 196);
      this.selectPanel.TabIndex = 27;
      this.selectPanel.Visible = false;
      // 
      // selectTwobtn
      // 
      this.selectTwobtn.BackColor = System.Drawing.Color.MediumSeaGreen;
      this.selectTwobtn.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
      this.selectTwobtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
      this.selectTwobtn.Location = new System.Drawing.Point(200, 82);
      this.selectTwobtn.Name = "selectTwobtn";
      this.selectTwobtn.Size = new System.Drawing.Size(124, 56);
      this.selectTwobtn.TabIndex = 2;
      this.selectTwobtn.Text = "角色2";
      this.selectTwobtn.UseVisualStyleBackColor = false;
      this.selectTwobtn.Click += new System.EventHandler(this.selectOnebtn_Click);
      // 
      // selectOnebtn
      // 
      this.selectOnebtn.BackColor = System.Drawing.Color.MediumSeaGreen;
      this.selectOnebtn.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
      this.selectOnebtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
      this.selectOnebtn.Location = new System.Drawing.Point(15, 82);
      this.selectOnebtn.Name = "selectOnebtn";
      this.selectOnebtn.Size = new System.Drawing.Size(124, 56);
      this.selectOnebtn.TabIndex = 1;
      this.selectOnebtn.Text = "角色1";
      this.selectOnebtn.UseVisualStyleBackColor = false;
      this.selectOnebtn.Click += new System.EventHandler(this.selectOnebtn_Click);
      // 
      // skillName
      // 
      this.skillName.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
      this.skillName.Location = new System.Drawing.Point(15, 17);
      this.skillName.Name = "skillName";
      this.skillName.Size = new System.Drawing.Size(93, 27);
      this.skillName.TabIndex = 0;
      this.skillName.Click += new System.EventHandler(this.skillName_Click);
      // 
      // countDownTimer
      // 
      this.countDownTimer.Enabled = true;
      this.countDownTimer.Interval = 1000D;
      this.countDownTimer.SynchronizingObject = this;
      this.countDownTimer.Elapsed += new System.Timers.ElapsedEventHandler(this.countDownTimer_Elapsed);
      // 
      // charMoveTimer
      // 
      this.charMoveTimer.Interval = 50D;
      this.charMoveTimer.SynchronizingObject = this;
      this.charMoveTimer.Elapsed += new System.Timers.ElapsedEventHandler(this.charMoveTimer_Elapsed);
      // 
      // heroOnePic
      // 
      this.heroOnePic.Image = global::DotnetRPGGame.Properties.Resources.狗;
      this.heroOnePic.Location = new System.Drawing.Point(34, 96);
      this.heroOnePic.Name = "heroOnePic";
      this.heroOnePic.Size = new System.Drawing.Size(173, 131);
      this.heroOnePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
      this.heroOnePic.TabIndex = 2;
      this.heroOnePic.TabStop = false;
      this.heroOnePic.MouseEnter += new System.EventHandler(this.heroOnePic_MouseEnter);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.Azure;
      this.ClientSize = new System.Drawing.Size(1138, 681);
      this.Controls.Add(this.monsterTwoPic);
      this.Controls.Add(this.monsterOnePic);
      this.Controls.Add(this.heroTwoPic);
      this.Controls.Add(this.heroOnePic);
      this.Controls.Add(this.selectPanel);
      this.Controls.Add(this.InforPanel);
      this.Controls.Add(this.countDownlbl);
      this.Controls.Add(this.panel5);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.monsterTwoNamelbl);
      this.Controls.Add(this.monsterTwoHPlbl);
      this.Controls.Add(this.label10);
      this.Controls.Add(this.monsterOneNamelbl);
      this.Controls.Add(this.monsterOneHPlbl);
      this.Controls.Add(this.label7);
      this.Controls.Add(this.heroTwoNamelbl);
      this.Controls.Add(this.heroTwoHPlbl);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.heroOneNamelbl);
      this.Controls.Add(this.heroOneHPlbl);
      this.Controls.Add(this.lable1);
      this.Location = new System.Drawing.Point(15, 15);
      this.Name = "Form1";
      ((System.ComponentModel.ISupportInitialize) (this.heroTwoPic)).EndInit();
      ((System.ComponentModel.ISupportInitialize) (this.monsterOnePic)).EndInit();
      ((System.ComponentModel.ISupportInitialize) (this.monsterTwoPic)).EndInit();
      this.panel5.ResumeLayout(false);
      this.InforPanel.ResumeLayout(false);
      this.selectPanel.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize) (this.countDownTimer)).EndInit();
      ((System.ComponentModel.ISupportInitialize) (this.charMoveTimer)).EndInit();
      ((System.ComponentModel.ISupportInitialize) (this.heroOnePic)).EndInit();
      this.ResumeLayout(false);
    }

    private System.Windows.Forms.Button readbtn;

    private System.Windows.Forms.Button savebtn;

    private System.Timers.Timer charMoveTimer;

    private System.Windows.Forms.Label damageTextlbl;

    private System.Windows.Forms.Label label3;

    private System.Windows.Forms.Label monsterTwoHPlbl;

    private System.Windows.Forms.Button selectOnebtn;

    private System.Windows.Forms.Panel selectPanel;
    private System.Windows.Forms.Label skillName;
    private System.Windows.Forms.Button selectTwobtn;

    private System.Windows.Forms.Label inforSpeed;

    private System.Windows.Forms.Label whoNowRoundActinglbl;

    private System.Timers.Timer countDownTimer;

    private System.Windows.Forms.Label inforLucky;

    private System.Windows.Forms.Label inforAc;
    private System.Windows.Forms.Label inforHP;
    private System.Windows.Forms.Label inforWeapon;

    private System.Windows.Forms.Label inforName;
    private System.Windows.Forms.Label inforAtk;
    private System.Windows.Forms.Label label5;

    private System.Windows.Forms.Panel panel7;

    private System.Windows.Forms.Panel InforPanel;

    private System.Windows.Forms.Label countDownlbl;

    private System.Windows.Forms.Button skillOnebtn;

    private System.Windows.Forms.Button button1;

    private System.Windows.Forms.Label roundNumlbl;

    private System.Windows.Forms.Panel panel5;

    private System.Windows.Forms.Label label2;

    private System.Windows.Forms.Label label1;

    private System.Windows.Forms.PictureBox monsterTwoPic;

    private System.Windows.Forms.PictureBox heroTwoPic;

    private System.Windows.Forms.PictureBox monsterOnePic;
    private System.Windows.Forms.Label heroOneHPlbl;
    private System.Windows.Forms.Label heroOneNamelbl;
    private System.Windows.Forms.Label label10;

    private System.Windows.Forms.Label heroTwoHPlbl;
    private System.Windows.Forms.Label heroTwoNamelbl;
    private System.Windows.Forms.Label label7;

    private System.Windows.Forms.Label monsterOneHPlbl;
    private System.Windows.Forms.Label monsterOneNamelbl;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label monsterTwoNamelbl;

    private System.Windows.Forms.Label lable1;

    private System.Windows.Forms.PictureBox heroOnePic;

    private System.Windows.Forms.Label monsterHPlbl;

    private Hero heroOne;
    private Hero heroTwo;
    private Monster monsterOne;
    private Monster monsterTwo;

    private Dictionary<string, NPC> dic = new Dictionary<string, NPC>();
    private List<NPC> _list = new List<NPC>();

    #endregion
  }
}

