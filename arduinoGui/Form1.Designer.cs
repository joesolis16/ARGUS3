
namespace arduinoGui
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.panelHumidity = new System.Windows.Forms.Panel();
            this.circularHumidityBar = new CircularProgressBar.CircularProgressBar();
            this.labelHumidity = new System.Windows.Forms.Label();
            this.panelInnerTemp = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.InTempNum = new System.Windows.Forms.Label();
            this.inTempBar = new System.Windows.Forms.PictureBox();
            this.inTempBarOutline = new System.Windows.Forms.PictureBox();
            this.labelInnerTemp = new System.Windows.Forms.Label();
            this.tempHumChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.comportGroupBox = new System.Windows.Forms.GroupBox();
            this.connectionLabel = new System.Windows.Forms.Label();
            this.connectStatusLabel = new System.Windows.Forms.Label();
            this.stopButton = new System.Windows.Forms.Button();
            this.startButton = new System.Windows.Forms.Button();
            this.BaudRateBox = new System.Windows.Forms.ComboBox();
            this.comPortBox = new System.Windows.Forms.ComboBox();
            this.labelBaud = new System.Windows.Forms.Label();
            this.labelCOMPORT = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.OutTempNum = new System.Windows.Forms.Label();
            this.outTempBar = new System.Windows.Forms.PictureBox();
            this.outTempBarOutline = new System.Windows.Forms.PictureBox();
            this.outTempLabel = new System.Windows.Forms.Label();
            this.serialGroupBox = new System.Windows.Forms.GroupBox();
            this.serialTextBox = new System.Windows.Forms.RichTextBox();
            this.fireGroupBox = new System.Windows.Forms.GroupBox();
            this.numFireDetectLabel = new System.Windows.Forms.Label();
            this.fireStatusLabel = new System.Windows.Forms.Label();
            this.fireDetectLabel = new System.Windows.Forms.Label();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.panelHumidity.SuspendLayout();
            this.panelInnerTemp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inTempBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inTempBarOutline)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tempHumChart)).BeginInit();
            this.comportGroupBox.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.outTempBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.outTempBarOutline)).BeginInit();
            this.serialGroupBox.SuspendLayout();
            this.fireGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHumidity
            // 
            this.panelHumidity.BackColor = System.Drawing.Color.White;
            this.panelHumidity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelHumidity.Controls.Add(this.circularHumidityBar);
            this.panelHumidity.Controls.Add(this.labelHumidity);
            this.panelHumidity.Location = new System.Drawing.Point(937, 427);
            this.panelHumidity.Name = "panelHumidity";
            this.panelHumidity.Size = new System.Drawing.Size(235, 191);
            this.panelHumidity.TabIndex = 0;
            // 
            // circularHumidityBar
            // 
            this.circularHumidityBar.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.circularHumidityBar.AnimationSpeed = 500;
            this.circularHumidityBar.BackColor = System.Drawing.Color.Transparent;
            this.circularHumidityBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.circularHumidityBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.circularHumidityBar.InnerColor = System.Drawing.Color.White;
            this.circularHumidityBar.InnerMargin = 2;
            this.circularHumidityBar.InnerWidth = -1;
            this.circularHumidityBar.Location = new System.Drawing.Point(43, 32);
            this.circularHumidityBar.MarqueeAnimationSpeed = 2000;
            this.circularHumidityBar.Name = "circularHumidityBar";
            this.circularHumidityBar.OuterColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.circularHumidityBar.OuterMargin = -25;
            this.circularHumidityBar.OuterWidth = 26;
            this.circularHumidityBar.ProgressColor = System.Drawing.Color.Blue;
            this.circularHumidityBar.ProgressWidth = 25;
            this.circularHumidityBar.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.circularHumidityBar.Size = new System.Drawing.Size(159, 150);
            this.circularHumidityBar.StartAngle = 90;
            this.circularHumidityBar.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularHumidityBar.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.circularHumidityBar.SubscriptText = "";
            this.circularHumidityBar.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularHumidityBar.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.circularHumidityBar.SuperscriptText = "";
            this.circularHumidityBar.TabIndex = 1;
            this.circularHumidityBar.Text = "00%";
            this.circularHumidityBar.TextMargin = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.circularHumidityBar.Value = 68;
            this.circularHumidityBar.Click += new System.EventHandler(this.circularHumidityBar_Click);
            // 
            // labelHumidity
            // 
            this.labelHumidity.AutoSize = true;
            this.labelHumidity.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHumidity.ForeColor = System.Drawing.Color.Blue;
            this.labelHumidity.Location = new System.Drawing.Point(83, 10);
            this.labelHumidity.Name = "labelHumidity";
            this.labelHumidity.Size = new System.Drawing.Size(77, 19);
            this.labelHumidity.TabIndex = 0;
            this.labelHumidity.Text = "Humidity";
            // 
            // panelInnerTemp
            // 
            this.panelInnerTemp.BackColor = System.Drawing.Color.White;
            this.panelInnerTemp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelInnerTemp.Controls.Add(this.label6);
            this.panelInnerTemp.Controls.Add(this.label5);
            this.panelInnerTemp.Controls.Add(this.label2);
            this.panelInnerTemp.Controls.Add(this.InTempNum);
            this.panelInnerTemp.Controls.Add(this.inTempBar);
            this.panelInnerTemp.Controls.Add(this.inTempBarOutline);
            this.panelInnerTemp.Controls.Add(this.labelInnerTemp);
            this.panelInnerTemp.Location = new System.Drawing.Point(937, 219);
            this.panelInnerTemp.Name = "panelInnerTemp";
            this.panelInnerTemp.Size = new System.Drawing.Size(235, 189);
            this.panelInnerTemp.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(85, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "100 °C ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(85, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "0 °C ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(146, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = " °C";
            // 
            // InTempNum
            // 
            this.InTempNum.AutoSize = true;
            this.InTempNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InTempNum.Location = new System.Drawing.Point(112, 88);
            this.InTempNum.Name = "InTempNum";
            this.InTempNum.Size = new System.Drawing.Size(48, 29);
            this.InTempNum.TabIndex = 3;
            this.InTempNum.Text = "0.0";
            // 
            // inTempBar
            // 
            this.inTempBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.inTempBar.Location = new System.Drawing.Point(31, 66);
            this.inTempBar.Name = "inTempBar";
            this.inTempBar.Size = new System.Drawing.Size(48, 100);
            this.inTempBar.TabIndex = 2;
            this.inTempBar.TabStop = false;
            // 
            // inTempBarOutline
            // 
            this.inTempBarOutline.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inTempBarOutline.Location = new System.Drawing.Point(31, 35);
            this.inTempBarOutline.Name = "inTempBarOutline";
            this.inTempBarOutline.Size = new System.Drawing.Size(48, 130);
            this.inTempBarOutline.TabIndex = 1;
            this.inTempBarOutline.TabStop = false;
            // 
            // labelInnerTemp
            // 
            this.labelInnerTemp.AutoSize = true;
            this.labelInnerTemp.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInnerTemp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.labelInnerTemp.Location = new System.Drawing.Point(55, 0);
            this.labelInnerTemp.Name = "labelInnerTemp";
            this.labelInnerTemp.Size = new System.Drawing.Size(138, 20);
            this.labelInnerTemp.TabIndex = 0;
            this.labelInnerTemp.Text = "Internal Temperature";
            this.labelInnerTemp.Click += new System.EventHandler(this.labelInnerTemp_Click);
            // 
            // tempHumChart
            // 
            chartArea1.Name = "ChartArea1";
            this.tempHumChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.tempHumChart.Legends.Add(legend1);
            this.tempHumChart.Location = new System.Drawing.Point(12, 232);
            this.tempHumChart.Name = "tempHumChart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Humidity";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "Internal Temperature";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Legend = "Legend1";
            series3.Name = "Outside Temperature";
            this.tempHumChart.Series.Add(series1);
            this.tempHumChart.Series.Add(series2);
            this.tempHumChart.Series.Add(series3);
            this.tempHumChart.Size = new System.Drawing.Size(919, 386);
            this.tempHumChart.TabIndex = 2;
            this.tempHumChart.Text = "chart1";
            title1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.Name = "Title1";
            title1.Text = "Internal and Outside Temperatures & Humidity Live Graph";
            this.tempHumChart.Titles.Add(title1);
            this.tempHumChart.Click += new System.EventHandler(this.chart1_Click);
            // 
            // comportGroupBox
            // 
            this.comportGroupBox.Controls.Add(this.connectionLabel);
            this.comportGroupBox.Controls.Add(this.connectStatusLabel);
            this.comportGroupBox.Controls.Add(this.stopButton);
            this.comportGroupBox.Controls.Add(this.startButton);
            this.comportGroupBox.Controls.Add(this.BaudRateBox);
            this.comportGroupBox.Controls.Add(this.comPortBox);
            this.comportGroupBox.Controls.Add(this.labelBaud);
            this.comportGroupBox.Controls.Add(this.labelCOMPORT);
            this.comportGroupBox.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comportGroupBox.Location = new System.Drawing.Point(12, 12);
            this.comportGroupBox.Name = "comportGroupBox";
            this.comportGroupBox.Size = new System.Drawing.Size(249, 214);
            this.comportGroupBox.TabIndex = 3;
            this.comportGroupBox.TabStop = false;
            this.comportGroupBox.Text = "COM PORT SETTINGS";
            // 
            // connectionLabel
            // 
            this.connectionLabel.AutoSize = true;
            this.connectionLabel.ForeColor = System.Drawing.Color.Red;
            this.connectionLabel.Location = new System.Drawing.Point(118, 124);
            this.connectionLabel.Name = "connectionLabel";
            this.connectionLabel.Size = new System.Drawing.Size(112, 20);
            this.connectionLabel.TabIndex = 7;
            this.connectionLabel.Text = "DISCONNECTED";
            // 
            // connectStatusLabel
            // 
            this.connectStatusLabel.AutoSize = true;
            this.connectStatusLabel.Location = new System.Drawing.Point(28, 124);
            this.connectStatusLabel.Name = "connectStatusLabel";
            this.connectStatusLabel.Size = new System.Drawing.Size(61, 20);
            this.connectStatusLabel.TabIndex = 6;
            this.connectStatusLabel.Text = "STATUS";
            // 
            // stopButton
            // 
            this.stopButton.Location = new System.Drawing.Point(142, 172);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(75, 36);
            this.stopButton.TabIndex = 5;
            this.stopButton.Text = "STOP";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(32, 172);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 36);
            this.startButton.TabIndex = 4;
            this.startButton.Text = "START";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // BaudRateBox
            // 
            this.BaudRateBox.FormattingEnabled = true;
            this.BaudRateBox.Items.AddRange(new object[] {
            "9600",
            "115200"});
            this.BaudRateBox.Location = new System.Drawing.Point(122, 79);
            this.BaudRateBox.Name = "BaudRateBox";
            this.BaudRateBox.Size = new System.Drawing.Size(115, 28);
            this.BaudRateBox.TabIndex = 3;
            // 
            // comPortBox
            // 
            this.comPortBox.FormattingEnabled = true;
            this.comPortBox.Location = new System.Drawing.Point(122, 35);
            this.comPortBox.Name = "comPortBox";
            this.comPortBox.Size = new System.Drawing.Size(116, 28);
            this.comPortBox.TabIndex = 2;
            // 
            // labelBaud
            // 
            this.labelBaud.AutoSize = true;
            this.labelBaud.Location = new System.Drawing.Point(28, 82);
            this.labelBaud.Name = "labelBaud";
            this.labelBaud.Size = new System.Drawing.Size(72, 20);
            this.labelBaud.TabIndex = 1;
            this.labelBaud.Text = "Baud Rate";
            this.labelBaud.Click += new System.EventHandler(this.label2_Click);
            // 
            // labelCOMPORT
            // 
            this.labelCOMPORT.AutoSize = true;
            this.labelCOMPORT.Location = new System.Drawing.Point(28, 38);
            this.labelCOMPORT.Name = "labelCOMPORT";
            this.labelCOMPORT.Size = new System.Drawing.Size(79, 20);
            this.labelCOMPORT.TabIndex = 0;
            this.labelCOMPORT.Text = "COM PORT";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.OutTempNum);
            this.panel1.Controls.Add(this.outTempBar);
            this.panel1.Controls.Add(this.outTempBarOutline);
            this.panel1.Controls.Add(this.outTempLabel);
            this.panel1.Location = new System.Drawing.Point(937, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(235, 184);
            this.panel1.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(84, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "0 °C ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(84, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "100 °C ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(127, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = " °C";
            // 
            // OutTempNum
            // 
            this.OutTempNum.AutoSize = true;
            this.OutTempNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutTempNum.Location = new System.Drawing.Point(112, 78);
            this.OutTempNum.Name = "OutTempNum";
            this.OutTempNum.Size = new System.Drawing.Size(48, 29);
            this.OutTempNum.TabIndex = 3;
            this.OutTempNum.Text = "0.0";
            // 
            // outTempBar
            // 
            this.outTempBar.BackColor = System.Drawing.Color.Red;
            this.outTempBar.Location = new System.Drawing.Point(31, 66);
            this.outTempBar.Name = "outTempBar";
            this.outTempBar.Size = new System.Drawing.Size(48, 100);
            this.outTempBar.TabIndex = 2;
            this.outTempBar.TabStop = false;
            // 
            // outTempBarOutline
            // 
            this.outTempBarOutline.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.outTempBarOutline.Location = new System.Drawing.Point(31, 36);
            this.outTempBarOutline.Name = "outTempBarOutline";
            this.outTempBarOutline.Size = new System.Drawing.Size(48, 130);
            this.outTempBarOutline.TabIndex = 1;
            this.outTempBarOutline.TabStop = false;
            // 
            // outTempLabel
            // 
            this.outTempLabel.AutoSize = true;
            this.outTempLabel.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outTempLabel.ForeColor = System.Drawing.Color.Red;
            this.outTempLabel.Location = new System.Drawing.Point(54, 0);
            this.outTempLabel.Name = "outTempLabel";
            this.outTempLabel.Size = new System.Drawing.Size(139, 20);
            this.outTempLabel.TabIndex = 0;
            this.outTempLabel.Text = "Outside Temperature";
            // 
            // serialGroupBox
            // 
            this.serialGroupBox.Controls.Add(this.serialTextBox);
            this.serialGroupBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serialGroupBox.Location = new System.Drawing.Point(267, 12);
            this.serialGroupBox.Name = "serialGroupBox";
            this.serialGroupBox.Size = new System.Drawing.Size(392, 214);
            this.serialGroupBox.TabIndex = 5;
            this.serialGroupBox.TabStop = false;
            this.serialGroupBox.Text = "Serial Output";
            // 
            // serialTextBox
            // 
            this.serialTextBox.Location = new System.Drawing.Point(6, 25);
            this.serialTextBox.Name = "serialTextBox";
            this.serialTextBox.Size = new System.Drawing.Size(380, 183);
            this.serialTextBox.TabIndex = 0;
            this.serialTextBox.Text = "";
            this.serialTextBox.TextChanged += new System.EventHandler(this.serialTextBox_TextChanged);
            // 
            // fireGroupBox
            // 
            this.fireGroupBox.Controls.Add(this.numFireDetectLabel);
            this.fireGroupBox.Controls.Add(this.fireStatusLabel);
            this.fireGroupBox.Controls.Add(this.fireDetectLabel);
            this.fireGroupBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fireGroupBox.Location = new System.Drawing.Point(665, 12);
            this.fireGroupBox.Name = "fireGroupBox";
            this.fireGroupBox.Size = new System.Drawing.Size(266, 213);
            this.fireGroupBox.TabIndex = 6;
            this.fireGroupBox.TabStop = false;
            this.fireGroupBox.Text = "Fire Detection";
            // 
            // numFireDetectLabel
            // 
            this.numFireDetectLabel.AutoSize = true;
            this.numFireDetectLabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numFireDetectLabel.Location = new System.Drawing.Point(7, 151);
            this.numFireDetectLabel.Name = "numFireDetectLabel";
            this.numFireDetectLabel.Size = new System.Drawing.Size(241, 16);
            this.numFireDetectLabel.TabIndex = 2;
            this.numFireDetectLabel.Text = "0 out of 4 Flame sensors detect a fire";
            // 
            // fireStatusLabel
            // 
            this.fireStatusLabel.AutoSize = true;
            this.fireStatusLabel.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fireStatusLabel.ForeColor = System.Drawing.Color.Green;
            this.fireStatusLabel.Location = new System.Drawing.Point(18, 82);
            this.fireStatusLabel.Name = "fireStatusLabel";
            this.fireStatusLabel.Size = new System.Drawing.Size(127, 32);
            this.fireStatusLabel.TabIndex = 1;
            this.fireStatusLabel.Text = "NO FIRE";
            // 
            // fireDetectLabel
            // 
            this.fireDetectLabel.AutoSize = true;
            this.fireDetectLabel.Location = new System.Drawing.Point(20, 35);
            this.fireDetectLabel.Name = "fireDetectLabel";
            this.fireDetectLabel.Size = new System.Drawing.Size(217, 19);
            this.fireDetectLabel.TabIndex = 0;
            this.fireDetectLabel.Text = "FIRE DETECTION STATUS:";
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 630);
            this.Controls.Add(this.fireGroupBox);
            this.Controls.Add(this.serialGroupBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.comportGroupBox);
            this.Controls.Add(this.tempHumChart);
            this.Controls.Add(this.panelInnerTemp);
            this.Controls.Add(this.panelHumidity);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelHumidity.ResumeLayout(false);
            this.panelHumidity.PerformLayout();
            this.panelInnerTemp.ResumeLayout(false);
            this.panelInnerTemp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inTempBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inTempBarOutline)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tempHumChart)).EndInit();
            this.comportGroupBox.ResumeLayout(false);
            this.comportGroupBox.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.outTempBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.outTempBarOutline)).EndInit();
            this.serialGroupBox.ResumeLayout(false);
            this.fireGroupBox.ResumeLayout(false);
            this.fireGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHumidity;
        private CircularProgressBar.CircularProgressBar circularHumidityBar;
        private System.Windows.Forms.Label labelHumidity;
        private System.Windows.Forms.Panel panelInnerTemp;
        private System.Windows.Forms.Label labelInnerTemp;
        private System.Windows.Forms.PictureBox inTempBarOutline;
        private System.Windows.Forms.DataVisualization.Charting.Chart tempHumChart;
        private System.Windows.Forms.GroupBox comportGroupBox;
        private System.Windows.Forms.Label labelCOMPORT;
        private System.Windows.Forms.ComboBox BaudRateBox;
        private System.Windows.Forms.ComboBox comPortBox;
        private System.Windows.Forms.Label labelBaud;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label outTempLabel;
        private System.Windows.Forms.PictureBox inTempBar;
        private System.Windows.Forms.PictureBox outTempBar;
        private System.Windows.Forms.PictureBox outTempBarOutline;
        private System.Windows.Forms.Label InTempNum;
        private System.Windows.Forms.Label OutTempNum;
        private System.Windows.Forms.GroupBox serialGroupBox;
        private System.Windows.Forms.RichTextBox serialTextBox;
        private System.Windows.Forms.GroupBox fireGroupBox;
        private System.Windows.Forms.Label fireStatusLabel;
        private System.Windows.Forms.Label fireDetectLabel;
        private System.Windows.Forms.Label connectionLabel;
        private System.Windows.Forms.Label connectStatusLabel;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label numFireDetectLabel;
    }
}

