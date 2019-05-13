namespace PID_fine_tuining11_5_2019
{
    partial class PID
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PID));
            this.serialport = new System.Windows.Forms.GroupBox();
            this.portopen = new System.Windows.Forms.Button();
            this.portclose = new System.Windows.Forms.Button();
            this.portdetect = new System.Windows.Forms.Button();
            this.baudratebox = new System.Windows.Forms.ComboBox();
            this.Portbox = new System.Windows.Forms.ComboBox();
            this.Baudrate = new System.Windows.Forms.Label();
            this.Port = new System.Windows.Forms.Label();
            this.groupbox1 = new System.Windows.Forms.GroupBox();
            this.speedramp = new System.Windows.Forms.GroupBox();
            this.durationyes = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.durationlabel = new System.Windows.Forms.Label();
            this.rampspeedlabel = new System.Windows.Forms.Label();
            this.durationbox = new System.Windows.Forms.TextBox();
            this.rampspeedbox = new System.Windows.Forms.TextBox();
            this.rampfinalspeed = new System.Windows.Forms.TrackBar();
            this.stop = new System.Windows.Forms.Button();
            this.run = new System.Windows.Forms.Button();
            this.currentloop = new System.Windows.Forms.GroupBox();
            this.idloop = new System.Windows.Forms.GroupBox();
            this.idkdbox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.idkibox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.idkpbox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.idkd = new System.Windows.Forms.Label();
            this.idkpbar = new System.Windows.Forms.TrackBar();
            this.idki = new System.Windows.Forms.Label();
            this.idkibar = new System.Windows.Forms.TrackBar();
            this.idkp = new System.Windows.Forms.Label();
            this.idkdbar = new System.Windows.Forms.TrackBar();
            this.iqloop = new System.Windows.Forms.GroupBox();
            this.iqkdbox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.iqkibox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.iqkpbox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.iqkd = new System.Windows.Forms.Label();
            this.iqkpbar = new System.Windows.Forms.TrackBar();
            this.iqki = new System.Windows.Forms.Label();
            this.iqkibar = new System.Windows.Forms.TrackBar();
            this.iqkp = new System.Windows.Forms.Label();
            this.iqkdbar = new System.Windows.Forms.TrackBar();
            this.speedloop = new System.Windows.Forms.GroupBox();
            this.skdbox = new System.Windows.Forms.TextBox();
            this.skibox = new System.Windows.Forms.TextBox();
            this.skpbox = new System.Windows.Forms.TextBox();
            this.skd = new System.Windows.Forms.Label();
            this.ski = new System.Windows.Forms.Label();
            this.skp = new System.Windows.Forms.Label();
            this.skdbar = new System.Windows.Forms.TrackBar();
            this.skibar = new System.Windows.Forms.TrackBar();
            this.skpbar = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.s_kp = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.datapathbox = new System.Windows.Forms.TextBox();
            this.datapathyes = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.speedcurve = new HslCommunication.Controls.UserCurve();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.speeddiff = new HslCommunication.Controls.UserCurve();
            this.serialport.SuspendLayout();
            this.groupbox1.SuspendLayout();
            this.speedramp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rampfinalspeed)).BeginInit();
            this.currentloop.SuspendLayout();
            this.idloop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.idkpbar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.idkibar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.idkdbar)).BeginInit();
            this.iqloop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iqkpbar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iqkibar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iqkdbar)).BeginInit();
            this.speedloop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.skdbar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skibar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skpbar)).BeginInit();
            this.SuspendLayout();
            // 
            // serialport
            // 
            this.serialport.BackColor = System.Drawing.SystemColors.Control;
            this.serialport.Controls.Add(this.portopen);
            this.serialport.Controls.Add(this.portclose);
            this.serialport.Controls.Add(this.portdetect);
            this.serialport.Controls.Add(this.baudratebox);
            this.serialport.Controls.Add(this.Portbox);
            this.serialport.Controls.Add(this.Baudrate);
            this.serialport.Controls.Add(this.Port);
            this.serialport.Location = new System.Drawing.Point(28, 22);
            this.serialport.Name = "serialport";
            this.serialport.Size = new System.Drawing.Size(531, 117);
            this.serialport.TabIndex = 0;
            this.serialport.TabStop = false;
            this.serialport.Text = "Serial port";
            // 
            // portopen
            // 
            this.portopen.Location = new System.Drawing.Point(387, 23);
            this.portopen.Name = "portopen";
            this.portopen.Size = new System.Drawing.Size(116, 37);
            this.portopen.TabIndex = 4;
            this.portopen.Text = "Connect";
            this.portopen.UseVisualStyleBackColor = true;
            this.portopen.Click += new System.EventHandler(this.portopen_Click);
            // 
            // portclose
            // 
            this.portclose.Location = new System.Drawing.Point(386, 70);
            this.portclose.Name = "portclose";
            this.portclose.Size = new System.Drawing.Size(117, 37);
            this.portclose.TabIndex = 4;
            this.portclose.Text = "Disconnect";
            this.portclose.UseVisualStyleBackColor = true;
            this.portclose.Click += new System.EventHandler(this.portclose_Click);
            // 
            // portdetect
            // 
            this.portdetect.Location = new System.Drawing.Point(268, 35);
            this.portdetect.Name = "portdetect";
            this.portdetect.Size = new System.Drawing.Size(80, 29);
            this.portdetect.TabIndex = 3;
            this.portdetect.Text = "Detect";
            this.portdetect.UseVisualStyleBackColor = true;
            this.portdetect.Click += new System.EventHandler(this.portdetect_Click);
            // 
            // baudratebox
            // 
            this.baudratebox.FormattingEnabled = true;
            this.baudratebox.Items.AddRange(new object[] {
            "4800",
            "9600",
            "38400",
            "57600",
            "115200"});
            this.baudratebox.Location = new System.Drawing.Point(125, 71);
            this.baudratebox.Name = "baudratebox";
            this.baudratebox.Size = new System.Drawing.Size(121, 29);
            this.baudratebox.TabIndex = 2;
            // 
            // Portbox
            // 
            this.Portbox.FormattingEnabled = true;
            this.Portbox.Location = new System.Drawing.Point(125, 35);
            this.Portbox.Name = "Portbox";
            this.Portbox.Size = new System.Drawing.Size(121, 29);
            this.Portbox.TabIndex = 2;
            // 
            // Baudrate
            // 
            this.Baudrate.AutoSize = true;
            this.Baudrate.Location = new System.Drawing.Point(21, 78);
            this.Baudrate.Name = "Baudrate";
            this.Baudrate.Size = new System.Drawing.Size(86, 22);
            this.Baudrate.TabIndex = 1;
            this.Baudrate.Text = "Baudrate";
            // 
            // Port
            // 
            this.Port.AutoSize = true;
            this.Port.Location = new System.Drawing.Point(21, 38);
            this.Port.Name = "Port";
            this.Port.Size = new System.Drawing.Size(45, 22);
            this.Port.TabIndex = 0;
            this.Port.Text = "Port";
            // 
            // groupbox1
            // 
            this.groupbox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupbox1.Controls.Add(this.speedramp);
            this.groupbox1.Controls.Add(this.stop);
            this.groupbox1.Controls.Add(this.run);
            this.groupbox1.Location = new System.Drawing.Point(615, 22);
            this.groupbox1.Name = "groupbox1";
            this.groupbox1.Size = new System.Drawing.Size(502, 176);
            this.groupbox1.TabIndex = 1;
            this.groupbox1.TabStop = false;
            this.groupbox1.Text = "Motror Control";
            // 
            // speedramp
            // 
            this.speedramp.Controls.Add(this.durationyes);
            this.speedramp.Controls.Add(this.label2);
            this.speedramp.Controls.Add(this.durationlabel);
            this.speedramp.Controls.Add(this.rampspeedlabel);
            this.speedramp.Controls.Add(this.durationbox);
            this.speedramp.Controls.Add(this.rampspeedbox);
            this.speedramp.Controls.Add(this.rampfinalspeed);
            this.speedramp.Location = new System.Drawing.Point(224, 17);
            this.speedramp.Name = "speedramp";
            this.speedramp.Size = new System.Drawing.Size(214, 153);
            this.speedramp.TabIndex = 1;
            this.speedramp.TabStop = false;
            this.speedramp.Text = "SpeedRamp(rpm)";
            // 
            // durationyes
            // 
            this.durationyes.Location = new System.Drawing.Point(133, 111);
            this.durationyes.Name = "durationyes";
            this.durationyes.Size = new System.Drawing.Size(75, 34);
            this.durationyes.TabIndex = 3;
            this.durationyes.Text = "Yes";
            this.durationyes.UseVisualStyleBackColor = true;
            this.durationyes.Click += new System.EventHandler(this.durationyes_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Duration(ms)";
            // 
            // durationlabel
            // 
            this.durationlabel.AutoSize = true;
            this.durationlabel.Location = new System.Drawing.Point(131, 86);
            this.durationlabel.Name = "durationlabel";
            this.durationlabel.Size = new System.Drawing.Size(43, 22);
            this.durationlabel.TabIndex = 2;
            this.durationlabel.Text = "100";
            // 
            // rampspeedlabel
            // 
            this.rampspeedlabel.AutoSize = true;
            this.rampspeedlabel.Location = new System.Drawing.Point(131, 58);
            this.rampspeedlabel.Name = "rampspeedlabel";
            this.rampspeedlabel.Size = new System.Drawing.Size(21, 22);
            this.rampspeedlabel.TabIndex = 2;
            this.rampspeedlabel.Text = "0";
            // 
            // durationbox
            // 
            this.durationbox.Location = new System.Drawing.Point(16, 115);
            this.durationbox.Name = "durationbox";
            this.durationbox.Size = new System.Drawing.Size(100, 28);
            this.durationbox.TabIndex = 1;
            this.durationbox.Text = "100";
            // 
            // rampspeedbox
            // 
            this.rampspeedbox.Location = new System.Drawing.Point(16, 55);
            this.rampspeedbox.Name = "rampspeedbox";
            this.rampspeedbox.Size = new System.Drawing.Size(100, 28);
            this.rampspeedbox.TabIndex = 1;
            this.rampspeedbox.Text = "0";
            // 
            // rampfinalspeed
            // 
            this.rampfinalspeed.LargeChange = 1;
            this.rampfinalspeed.Location = new System.Drawing.Point(6, 27);
            this.rampfinalspeed.Maximum = 5000;
            this.rampfinalspeed.Name = "rampfinalspeed";
            this.rampfinalspeed.Size = new System.Drawing.Size(202, 56);
            this.rampfinalspeed.TabIndex = 0;
            this.rampfinalspeed.Scroll += new System.EventHandler(this.rampfinalspeed_Scroll);
            // 
            // stop
            // 
            this.stop.Location = new System.Drawing.Point(25, 107);
            this.stop.Name = "stop";
            this.stop.Size = new System.Drawing.Size(98, 52);
            this.stop.TabIndex = 0;
            this.stop.Text = "Stop";
            this.stop.UseVisualStyleBackColor = true;
            this.stop.Click += new System.EventHandler(this.stop_Click);
            // 
            // run
            // 
            this.run.Location = new System.Drawing.Point(25, 37);
            this.run.Name = "run";
            this.run.Size = new System.Drawing.Size(98, 52);
            this.run.TabIndex = 0;
            this.run.Text = "Run";
            this.run.UseVisualStyleBackColor = true;
            this.run.Click += new System.EventHandler(this.run_Click);
            // 
            // currentloop
            // 
            this.currentloop.Controls.Add(this.idloop);
            this.currentloop.Controls.Add(this.iqloop);
            this.currentloop.Location = new System.Drawing.Point(429, 204);
            this.currentloop.Name = "currentloop";
            this.currentloop.Size = new System.Drawing.Size(793, 244);
            this.currentloop.TabIndex = 2;
            this.currentloop.TabStop = false;
            this.currentloop.Text = "Current Loop";
            // 
            // idloop
            // 
            this.idloop.Controls.Add(this.idkdbox);
            this.idloop.Controls.Add(this.label11);
            this.idloop.Controls.Add(this.idkibox);
            this.idloop.Controls.Add(this.label12);
            this.idloop.Controls.Add(this.idkpbox);
            this.idloop.Controls.Add(this.label13);
            this.idloop.Controls.Add(this.idkd);
            this.idloop.Controls.Add(this.idkpbar);
            this.idloop.Controls.Add(this.idki);
            this.idloop.Controls.Add(this.idkibar);
            this.idloop.Controls.Add(this.idkp);
            this.idloop.Controls.Add(this.idkdbar);
            this.idloop.Location = new System.Drawing.Point(406, 27);
            this.idloop.Name = "idloop";
            this.idloop.Size = new System.Drawing.Size(378, 209);
            this.idloop.TabIndex = 6;
            this.idloop.TabStop = false;
            this.idloop.Text = "Id Loop";
            // 
            // idkdbox
            // 
            this.idkdbox.Location = new System.Drawing.Point(288, 144);
            this.idkdbox.Name = "idkdbox";
            this.idkdbox.Size = new System.Drawing.Size(86, 28);
            this.idkdbox.TabIndex = 5;
            this.idkdbox.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(20, 34);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(34, 22);
            this.label11.TabIndex = 2;
            this.label11.Text = "Kp";
            // 
            // idkibox
            // 
            this.idkibox.Location = new System.Drawing.Point(288, 88);
            this.idkibox.Name = "idkibox";
            this.idkibox.Size = new System.Drawing.Size(86, 28);
            this.idkibox.TabIndex = 5;
            this.idkibox.Text = "2049";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(20, 91);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(27, 22);
            this.label12.TabIndex = 2;
            this.label12.Text = "Ki";
            // 
            // idkpbox
            // 
            this.idkpbox.Location = new System.Drawing.Point(288, 32);
            this.idkpbox.Name = "idkpbox";
            this.idkpbox.Size = new System.Drawing.Size(86, 28);
            this.idkpbox.TabIndex = 5;
            this.idkpbox.Text = "2700";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(20, 144);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(34, 22);
            this.label13.TabIndex = 2;
            this.label13.Text = "Kd";
            // 
            // idkd
            // 
            this.idkd.AutoSize = true;
            this.idkd.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idkd.Location = new System.Drawing.Point(284, 175);
            this.idkd.Name = "idkd";
            this.idkd.Size = new System.Drawing.Size(21, 22);
            this.idkd.TabIndex = 4;
            this.idkd.Text = "0";
            // 
            // idkpbar
            // 
            this.idkpbar.Location = new System.Drawing.Point(60, 34);
            this.idkpbar.Maximum = 5000;
            this.idkpbar.Name = "idkpbar";
            this.idkpbar.Size = new System.Drawing.Size(222, 56);
            this.idkpbar.TabIndex = 3;
            this.idkpbar.Value = 2700;
            this.idkpbar.Scroll += new System.EventHandler(this.idkpbar_Scroll);
            // 
            // idki
            // 
            this.idki.AutoSize = true;
            this.idki.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idki.Location = new System.Drawing.Point(284, 119);
            this.idki.Name = "idki";
            this.idki.Size = new System.Drawing.Size(54, 22);
            this.idki.TabIndex = 4;
            this.idki.Text = "2049";
            // 
            // idkibar
            // 
            this.idkibar.Location = new System.Drawing.Point(60, 88);
            this.idkibar.Maximum = 3000;
            this.idkibar.Name = "idkibar";
            this.idkibar.Size = new System.Drawing.Size(222, 56);
            this.idkibar.TabIndex = 3;
            this.idkibar.Value = 2049;
            this.idkibar.Scroll += new System.EventHandler(this.idkibar_Scroll);
            // 
            // idkp
            // 
            this.idkp.AutoSize = true;
            this.idkp.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idkp.Location = new System.Drawing.Point(284, 63);
            this.idkp.Name = "idkp";
            this.idkp.Size = new System.Drawing.Size(54, 22);
            this.idkp.TabIndex = 4;
            this.idkp.Text = "2700";
            // 
            // idkdbar
            // 
            this.idkdbar.Location = new System.Drawing.Point(60, 144);
            this.idkdbar.Maximum = 100;
            this.idkdbar.Name = "idkdbar";
            this.idkdbar.Size = new System.Drawing.Size(222, 56);
            this.idkdbar.TabIndex = 3;
            this.idkdbar.Scroll += new System.EventHandler(this.idkdbar_Scroll);
            // 
            // iqloop
            // 
            this.iqloop.Controls.Add(this.iqkdbox);
            this.iqloop.Controls.Add(this.label10);
            this.iqloop.Controls.Add(this.iqkibox);
            this.iqloop.Controls.Add(this.label9);
            this.iqloop.Controls.Add(this.iqkpbox);
            this.iqloop.Controls.Add(this.label8);
            this.iqloop.Controls.Add(this.iqkd);
            this.iqloop.Controls.Add(this.iqkpbar);
            this.iqloop.Controls.Add(this.iqki);
            this.iqloop.Controls.Add(this.iqkibar);
            this.iqloop.Controls.Add(this.iqkp);
            this.iqloop.Controls.Add(this.iqkdbar);
            this.iqloop.Location = new System.Drawing.Point(16, 27);
            this.iqloop.Name = "iqloop";
            this.iqloop.Size = new System.Drawing.Size(384, 209);
            this.iqloop.TabIndex = 6;
            this.iqloop.TabStop = false;
            this.iqloop.Text = "Iq Loop";
            // 
            // iqkdbox
            // 
            this.iqkdbox.Location = new System.Drawing.Point(288, 144);
            this.iqkdbox.Name = "iqkdbox";
            this.iqkdbox.Size = new System.Drawing.Size(86, 28);
            this.iqkdbox.TabIndex = 5;
            this.iqkdbox.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(20, 34);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 22);
            this.label10.TabIndex = 2;
            this.label10.Text = "Kp";
            // 
            // iqkibox
            // 
            this.iqkibox.Location = new System.Drawing.Point(288, 88);
            this.iqkibox.Name = "iqkibox";
            this.iqkibox.Size = new System.Drawing.Size(86, 28);
            this.iqkibox.TabIndex = 5;
            this.iqkibox.Text = "2049";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(20, 91);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(27, 22);
            this.label9.TabIndex = 2;
            this.label9.Text = "Ki";
            // 
            // iqkpbox
            // 
            this.iqkpbox.Location = new System.Drawing.Point(288, 32);
            this.iqkpbox.Name = "iqkpbox";
            this.iqkpbox.Size = new System.Drawing.Size(86, 28);
            this.iqkpbox.TabIndex = 5;
            this.iqkpbox.Text = "2700";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 147);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 22);
            this.label8.TabIndex = 2;
            this.label8.Text = "Kd";
            // 
            // iqkd
            // 
            this.iqkd.AutoSize = true;
            this.iqkd.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iqkd.Location = new System.Drawing.Point(288, 175);
            this.iqkd.Name = "iqkd";
            this.iqkd.Size = new System.Drawing.Size(21, 22);
            this.iqkd.TabIndex = 4;
            this.iqkd.Text = "0";
            // 
            // iqkpbar
            // 
            this.iqkpbar.Location = new System.Drawing.Point(60, 34);
            this.iqkpbar.Maximum = 5000;
            this.iqkpbar.Name = "iqkpbar";
            this.iqkpbar.Size = new System.Drawing.Size(222, 56);
            this.iqkpbar.TabIndex = 3;
            this.iqkpbar.Value = 2700;
            this.iqkpbar.Scroll += new System.EventHandler(this.iqkpbar_Scroll);
            // 
            // iqki
            // 
            this.iqki.AutoSize = true;
            this.iqki.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iqki.Location = new System.Drawing.Point(288, 119);
            this.iqki.Name = "iqki";
            this.iqki.Size = new System.Drawing.Size(54, 22);
            this.iqki.TabIndex = 4;
            this.iqki.Text = "2049";
            // 
            // iqkibar
            // 
            this.iqkibar.Location = new System.Drawing.Point(60, 88);
            this.iqkibar.Maximum = 3000;
            this.iqkibar.Name = "iqkibar";
            this.iqkibar.Size = new System.Drawing.Size(222, 56);
            this.iqkibar.TabIndex = 3;
            this.iqkibar.Value = 2049;
            this.iqkibar.Scroll += new System.EventHandler(this.iqkibar_Scroll);
            // 
            // iqkp
            // 
            this.iqkp.AutoSize = true;
            this.iqkp.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iqkp.Location = new System.Drawing.Point(288, 63);
            this.iqkp.Name = "iqkp";
            this.iqkp.Size = new System.Drawing.Size(54, 22);
            this.iqkp.TabIndex = 4;
            this.iqkp.Text = "2700";
            // 
            // iqkdbar
            // 
            this.iqkdbar.Location = new System.Drawing.Point(60, 144);
            this.iqkdbar.Maximum = 100;
            this.iqkdbar.Name = "iqkdbar";
            this.iqkdbar.Size = new System.Drawing.Size(222, 56);
            this.iqkdbar.TabIndex = 3;
            this.iqkdbar.Scroll += new System.EventHandler(this.iqkdbar_Scroll);
            // 
            // speedloop
            // 
            this.speedloop.Controls.Add(this.skdbox);
            this.speedloop.Controls.Add(this.skibox);
            this.speedloop.Controls.Add(this.skpbox);
            this.speedloop.Controls.Add(this.skd);
            this.speedloop.Controls.Add(this.ski);
            this.speedloop.Controls.Add(this.skp);
            this.speedloop.Controls.Add(this.skdbar);
            this.speedloop.Controls.Add(this.skibar);
            this.speedloop.Controls.Add(this.skpbar);
            this.speedloop.Controls.Add(this.label4);
            this.speedloop.Controls.Add(this.label3);
            this.speedloop.Controls.Add(this.s_kp);
            this.speedloop.Location = new System.Drawing.Point(28, 204);
            this.speedloop.Name = "speedloop";
            this.speedloop.Size = new System.Drawing.Size(395, 244);
            this.speedloop.TabIndex = 2;
            this.speedloop.TabStop = false;
            this.speedloop.Text = "Speed Loop";
            // 
            // skdbox
            // 
            this.skdbox.Location = new System.Drawing.Point(287, 163);
            this.skdbox.Name = "skdbox";
            this.skdbox.Size = new System.Drawing.Size(86, 28);
            this.skdbox.TabIndex = 5;
            this.skdbox.Text = "0";
            // 
            // skibox
            // 
            this.skibox.Location = new System.Drawing.Point(287, 107);
            this.skibox.Name = "skibox";
            this.skibox.Size = new System.Drawing.Size(86, 28);
            this.skibox.TabIndex = 5;
            this.skibox.Text = "100";
            // 
            // skpbox
            // 
            this.skpbox.Location = new System.Drawing.Point(287, 51);
            this.skpbox.Name = "skpbox";
            this.skpbox.Size = new System.Drawing.Size(86, 28);
            this.skpbox.TabIndex = 5;
            this.skpbox.Text = "3000";
            // 
            // skd
            // 
            this.skd.AutoSize = true;
            this.skd.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.skd.Location = new System.Drawing.Point(283, 197);
            this.skd.Name = "skd";
            this.skd.Size = new System.Drawing.Size(21, 22);
            this.skd.TabIndex = 4;
            this.skd.Text = "0";
            // 
            // ski
            // 
            this.ski.AutoSize = true;
            this.ski.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ski.Location = new System.Drawing.Point(283, 138);
            this.ski.Name = "ski";
            this.ski.Size = new System.Drawing.Size(43, 22);
            this.ski.TabIndex = 4;
            this.ski.Text = "100";
            // 
            // skp
            // 
            this.skp.AutoSize = true;
            this.skp.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.skp.Location = new System.Drawing.Point(283, 82);
            this.skp.Name = "skp";
            this.skp.Size = new System.Drawing.Size(54, 22);
            this.skp.TabIndex = 4;
            this.skp.Text = "3000";
            // 
            // skdbar
            // 
            this.skdbar.Location = new System.Drawing.Point(59, 163);
            this.skdbar.Maximum = 100;
            this.skdbar.Name = "skdbar";
            this.skdbar.Size = new System.Drawing.Size(222, 56);
            this.skdbar.TabIndex = 3;
            this.skdbar.Scroll += new System.EventHandler(this.skdbar_Scroll);
            // 
            // skibar
            // 
            this.skibar.Location = new System.Drawing.Point(59, 107);
            this.skibar.Maximum = 3000;
            this.skibar.Name = "skibar";
            this.skibar.Size = new System.Drawing.Size(222, 56);
            this.skibar.TabIndex = 3;
            this.skibar.Value = 100;
            this.skibar.Scroll += new System.EventHandler(this.skibar_Scroll);
            // 
            // skpbar
            // 
            this.skpbar.Location = new System.Drawing.Point(59, 53);
            this.skpbar.Maximum = 5000;
            this.skpbar.Name = "skpbar";
            this.skpbar.Size = new System.Drawing.Size(222, 56);
            this.skpbar.TabIndex = 3;
            this.skpbar.Value = 3000;
            this.skpbar.Scroll += new System.EventHandler(this.skpbar_Scroll);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 22);
            this.label4.TabIndex = 2;
            this.label4.Text = "Kd";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ki";
            // 
            // s_kp
            // 
            this.s_kp.AutoSize = true;
            this.s_kp.Location = new System.Drawing.Point(19, 53);
            this.s_kp.Name = "s_kp";
            this.s_kp.Size = new System.Drawing.Size(34, 22);
            this.s_kp.TabIndex = 2;
            this.s_kp.Text = "Kp";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Data save to path";
            // 
            // datapathbox
            // 
            this.datapathbox.Location = new System.Drawing.Point(187, 147);
            this.datapathbox.Name = "datapathbox";
            this.datapathbox.Size = new System.Drawing.Size(287, 28);
            this.datapathbox.TabIndex = 3;
            // 
            // datapathyes
            // 
            this.datapathyes.Location = new System.Drawing.Point(485, 147);
            this.datapathyes.Name = "datapathyes";
            this.datapathyes.Size = new System.Drawing.Size(74, 28);
            this.datapathyes.TabIndex = 4;
            this.datapathyes.Text = "Yes";
            this.datapathyes.UseVisualStyleBackColor = true;
            this.datapathyes.Click += new System.EventHandler(this.datapath_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // speedcurve
            // 
            this.speedcurve.BackColor = System.Drawing.Color.White;
            this.speedcurve.ColorDashLines = System.Drawing.Color.Black;
            this.speedcurve.ColorLinesAndText = System.Drawing.Color.Black;
            this.speedcurve.IsAbscissaStrech = true;
            this.speedcurve.Location = new System.Drawing.Point(28, 456);
            this.speedcurve.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.speedcurve.Name = "speedcurve";
            this.speedcurve.Size = new System.Drawing.Size(608, 316);
            this.speedcurve.StrechDataCountMax = 1000;
            this.speedcurve.TabIndex = 5;
            this.speedcurve.TextAddFormat = "ss.ff";
            this.speedcurve.Title = "Motor Speed";
            this.speedcurve.ValueMaxLeft = 2500F;
            this.speedcurve.ValueMaxRight = 2500F;
            this.speedcurve.ValueSegment = 10;
            this.speedcurve.Load += new System.EventHandler(this.speedcurve_Load);
            // 
            // timer2
            // 
            this.timer2.Interval = 5;
            // 
            // speeddiff
            // 
            this.speeddiff.BackColor = System.Drawing.Color.White;
            this.speeddiff.ColorDashLines = System.Drawing.Color.Black;
            this.speeddiff.ColorLinesAndText = System.Drawing.Color.Black;
            this.speeddiff.IsAbscissaStrech = true;
            this.speeddiff.Location = new System.Drawing.Point(655, 456);
            this.speeddiff.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.speeddiff.Name = "speeddiff";
            this.speeddiff.Size = new System.Drawing.Size(594, 314);
            this.speeddiff.StrechDataCountMax = 1000;
            this.speeddiff.TabIndex = 6;
            this.speeddiff.TextAddFormat = "ss.ff";
            this.speeddiff.Title = "Speed Difference";
            this.speeddiff.ValueMaxLeft = 1000F;
            this.speeddiff.ValueMaxRight = 1F;
            this.speeddiff.ValueMinRight = -1F;
            this.speeddiff.ValueSegment = 20;
            this.speeddiff.Load += new System.EventHandler(this.speeddiff_Load);
            // 
            // PID
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1514, 785);
            this.Controls.Add(this.speeddiff);
            this.Controls.Add(this.speedcurve);
            this.Controls.Add(this.speedloop);
            this.Controls.Add(this.currentloop);
            this.Controls.Add(this.datapathyes);
            this.Controls.Add(this.datapathbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupbox1);
            this.Controls.Add(this.serialport);
            this.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PID";
            this.Text = "PID fine tuning";
            this.Load += new System.EventHandler(this.PID_Load);
            this.serialport.ResumeLayout(false);
            this.serialport.PerformLayout();
            this.groupbox1.ResumeLayout(false);
            this.speedramp.ResumeLayout(false);
            this.speedramp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rampfinalspeed)).EndInit();
            this.currentloop.ResumeLayout(false);
            this.idloop.ResumeLayout(false);
            this.idloop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.idkpbar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.idkibar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.idkdbar)).EndInit();
            this.iqloop.ResumeLayout(false);
            this.iqloop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iqkpbar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iqkibar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iqkdbar)).EndInit();
            this.speedloop.ResumeLayout(false);
            this.speedloop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.skdbar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skibar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skpbar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox serialport;
        private System.Windows.Forms.Button portdetect;
        private System.Windows.Forms.ComboBox baudratebox;
        private System.Windows.Forms.ComboBox Portbox;
        private System.Windows.Forms.Label Baudrate;
        private System.Windows.Forms.Label Port;
        private System.Windows.Forms.Button portopen;
        private System.Windows.Forms.Button portclose;
        private System.Windows.Forms.GroupBox groupbox1;
        private System.Windows.Forms.GroupBox currentloop;
        private System.Windows.Forms.GroupBox idloop;
        private System.Windows.Forms.TextBox idkdbox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox idkibox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox idkpbox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label idkd;
        private System.Windows.Forms.TrackBar idkpbar;
        private System.Windows.Forms.Label idki;
        private System.Windows.Forms.TrackBar idkibar;
        private System.Windows.Forms.Label idkp;
        private System.Windows.Forms.TrackBar idkdbar;
        private System.Windows.Forms.GroupBox iqloop;
        private System.Windows.Forms.TextBox iqkdbox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox iqkibox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox iqkpbox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label iqkd;
        private System.Windows.Forms.TrackBar iqkpbar;
        private System.Windows.Forms.Label iqki;
        private System.Windows.Forms.TrackBar iqkibar;
        private System.Windows.Forms.Label iqkp;
        private System.Windows.Forms.TrackBar iqkdbar;
        private System.Windows.Forms.GroupBox speedloop;
        private System.Windows.Forms.TextBox skdbox;
        private System.Windows.Forms.TextBox skibox;
        private System.Windows.Forms.TextBox skpbox;
        private System.Windows.Forms.Label skd;
        private System.Windows.Forms.Label ski;
        private System.Windows.Forms.Label skp;
        private System.Windows.Forms.TrackBar skdbar;
        private System.Windows.Forms.TrackBar skibar;
        private System.Windows.Forms.TrackBar skpbar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label s_kp;
        private System.Windows.Forms.GroupBox speedramp;
        private System.Windows.Forms.Button durationyes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label durationlabel;
        private System.Windows.Forms.Label rampspeedlabel;
        private System.Windows.Forms.TextBox durationbox;
        private System.Windows.Forms.TextBox rampspeedbox;
        private System.Windows.Forms.TrackBar rampfinalspeed;
        private System.Windows.Forms.Button stop;
        private System.Windows.Forms.Button run;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox datapathbox;
        private System.Windows.Forms.Button datapathyes;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Timer timer1;
        private HslCommunication.Controls.UserCurve speedcurve;
        private System.Windows.Forms.Timer timer2;
        private HslCommunication.Controls.UserCurve speeddiff;
    }
}

