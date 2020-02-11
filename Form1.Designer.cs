﻿namespace PerceptronLearningVisualizer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.button_PlayPause = new System.Windows.Forms.Button();
            this.button_Reset = new System.Windows.Forms.Button();
            this.button_Run = new System.Windows.Forms.Button();
            this.groupBox_RunTimeData = new System.Windows.Forms.GroupBox();
            this.label_NewCalculatedLine = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.output_NewCalculatedLine = new System.Windows.Forms.Label();
            this.label_MSE = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.output_MSE = new System.Windows.Forms.Label();
            this.label_WeightError = new System.Windows.Forms.Label();
            this.label_BiasError = new System.Windows.Forms.Label();
            this.label_OldCalculatedLine = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.output_WeightError = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.output_BiasError = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.output_OldCalculatedLine = new System.Windows.Forms.Label();
            this.container = new System.Windows.Forms.Panel();
            this.output_Epoch = new System.Windows.Forms.Label();
            this.label_Epoch = new System.Windows.Forms.Label();
            this.groupBox_HyperParameters = new System.Windows.Forms.GroupBox();
            this.label_PointsPerEpoch = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.input_e = new System.Windows.Forms.TextBox();
            this.label_eEquals = new System.Windows.Forms.Label();
            this.label_GeneratedPoints = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.input_p = new System.Windows.Forms.TextBox();
            this.label_pEquals = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.input_r = new System.Windows.Forms.TextBox();
            this.label_rEquals = new System.Windows.Forms.Label();
            this.label_LearningRate = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.input_b = new System.Windows.Forms.TextBox();
            this.label_TimesXPlus = new System.Windows.Forms.Label();
            this.input_w = new System.Windows.Forms.TextBox();
            this.label_yEquals = new System.Windows.Forms.Label();
            this.label_GroundTruthLine = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.input_width = new System.Windows.Forms.TextBox();
            this.label_wEquals = new System.Windows.Forms.Label();
            this.label_SizeOfCanvas = new System.Windows.Forms.Label();
            this.input_height = new System.Windows.Forms.TextBox();
            this.label_hEquals = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox_RunTimeData.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.container.SuspendLayout();
            this.groupBox_HyperParameters.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.button_PlayPause);
            this.splitContainer1.Panel1.Controls.Add(this.button_Reset);
            this.splitContainer1.Panel1.Controls.Add(this.button_Run);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox_RunTimeData);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox_HyperParameters);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.Silver;
            this.splitContainer1.Size = new System.Drawing.Size(800, 493);
            this.splitContainer1.SplitterDistance = 266;
            this.splitContainer1.TabIndex = 0;
            // 
            // button_PlayPause
            // 
            this.button_PlayPause.Enabled = false;
            this.button_PlayPause.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_PlayPause.Location = new System.Drawing.Point(12, 413);
            this.button_PlayPause.Name = "button_PlayPause";
            this.button_PlayPause.Size = new System.Drawing.Size(242, 29);
            this.button_PlayPause.TabIndex = 4;
            this.button_PlayPause.Text = "Pause Simulation";
            this.button_PlayPause.UseVisualStyleBackColor = true;
            this.button_PlayPause.Click += new System.EventHandler(this.button_PlayPause_Click);
            // 
            // button_Reset
            // 
            this.button_Reset.Enabled = false;
            this.button_Reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Reset.Location = new System.Drawing.Point(12, 448);
            this.button_Reset.Name = "button_Reset";
            this.button_Reset.Size = new System.Drawing.Size(242, 29);
            this.button_Reset.TabIndex = 3;
            this.button_Reset.Text = "Reset Simulation";
            this.button_Reset.UseVisualStyleBackColor = true;
            this.button_Reset.Click += new System.EventHandler(this.button_Reset_Click);
            // 
            // button_Run
            // 
            this.button_Run.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Run.Location = new System.Drawing.Point(12, 375);
            this.button_Run.Name = "button_Run";
            this.button_Run.Size = new System.Drawing.Size(242, 32);
            this.button_Run.TabIndex = 0;
            this.button_Run.Text = "Run Simulation";
            this.button_Run.UseVisualStyleBackColor = true;
            this.button_Run.Click += new System.EventHandler(this.button_Run_Click);
            // 
            // groupBox_RunTimeData
            // 
            this.groupBox_RunTimeData.Controls.Add(this.label_NewCalculatedLine);
            this.groupBox_RunTimeData.Controls.Add(this.panel10);
            this.groupBox_RunTimeData.Controls.Add(this.label_MSE);
            this.groupBox_RunTimeData.Controls.Add(this.panel8);
            this.groupBox_RunTimeData.Controls.Add(this.label_WeightError);
            this.groupBox_RunTimeData.Controls.Add(this.label_BiasError);
            this.groupBox_RunTimeData.Controls.Add(this.label_OldCalculatedLine);
            this.groupBox_RunTimeData.Controls.Add(this.panel7);
            this.groupBox_RunTimeData.Controls.Add(this.panel6);
            this.groupBox_RunTimeData.Controls.Add(this.panel5);
            this.groupBox_RunTimeData.Controls.Add(this.container);
            this.groupBox_RunTimeData.Controls.Add(this.label_Epoch);
            this.groupBox_RunTimeData.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_RunTimeData.Location = new System.Drawing.Point(3, 175);
            this.groupBox_RunTimeData.Name = "groupBox_RunTimeData";
            this.groupBox_RunTimeData.Size = new System.Drawing.Size(260, 197);
            this.groupBox_RunTimeData.TabIndex = 1;
            this.groupBox_RunTimeData.TabStop = false;
            this.groupBox_RunTimeData.Text = "Run-Time Data";
            // 
            // label_NewCalculatedLine
            // 
            this.label_NewCalculatedLine.AutoSize = true;
            this.label_NewCalculatedLine.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_NewCalculatedLine.Location = new System.Drawing.Point(6, 171);
            this.label_NewCalculatedLine.Name = "label_NewCalculatedLine";
            this.label_NewCalculatedLine.Size = new System.Drawing.Size(108, 13);
            this.label_NewCalculatedLine.TabIndex = 17;
            this.label_NewCalculatedLine.Text = "New Calculated Line:";
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.output_NewCalculatedLine);
            this.panel10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel10.Location = new System.Drawing.Point(111, 163);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(143, 30);
            this.panel10.TabIndex = 16;
            // 
            // output_NewCalculatedLine
            // 
            this.output_NewCalculatedLine.AutoSize = true;
            this.output_NewCalculatedLine.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.output_NewCalculatedLine.Location = new System.Drawing.Point(3, 8);
            this.output_NewCalculatedLine.Name = "output_NewCalculatedLine";
            this.output_NewCalculatedLine.Size = new System.Drawing.Size(27, 13);
            this.output_NewCalculatedLine.TabIndex = 1;
            this.output_NewCalculatedLine.Text = "N/A";
            // 
            // label_MSE
            // 
            this.label_MSE.AutoSize = true;
            this.label_MSE.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_MSE.Location = new System.Drawing.Point(6, 140);
            this.label_MSE.Name = "label_MSE";
            this.label_MSE.Size = new System.Drawing.Size(30, 13);
            this.label_MSE.TabIndex = 15;
            this.label_MSE.Text = "MSE";
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.output_MSE);
            this.panel8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel8.Location = new System.Drawing.Point(111, 132);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(143, 30);
            this.panel8.TabIndex = 12;
            // 
            // output_MSE
            // 
            this.output_MSE.AutoSize = true;
            this.output_MSE.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.output_MSE.Location = new System.Drawing.Point(3, 8);
            this.output_MSE.Name = "output_MSE";
            this.output_MSE.Size = new System.Drawing.Size(27, 13);
            this.output_MSE.TabIndex = 1;
            this.output_MSE.Text = "N/A";
            // 
            // label_WeightError
            // 
            this.label_WeightError.AutoSize = true;
            this.label_WeightError.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_WeightError.Location = new System.Drawing.Point(6, 109);
            this.label_WeightError.Name = "label_WeightError";
            this.label_WeightError.Size = new System.Drawing.Size(69, 13);
            this.label_WeightError.TabIndex = 14;
            this.label_WeightError.Text = "Weight Error:";
            // 
            // label_BiasError
            // 
            this.label_BiasError.AutoSize = true;
            this.label_BiasError.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_BiasError.Location = new System.Drawing.Point(6, 78);
            this.label_BiasError.Name = "label_BiasError";
            this.label_BiasError.Size = new System.Drawing.Size(55, 13);
            this.label_BiasError.TabIndex = 13;
            this.label_BiasError.Text = "Bias Error:";
            // 
            // label_OldCalculatedLine
            // 
            this.label_OldCalculatedLine.AutoSize = true;
            this.label_OldCalculatedLine.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_OldCalculatedLine.Location = new System.Drawing.Point(6, 47);
            this.label_OldCalculatedLine.Name = "label_OldCalculatedLine";
            this.label_OldCalculatedLine.Size = new System.Drawing.Size(102, 13);
            this.label_OldCalculatedLine.TabIndex = 12;
            this.label_OldCalculatedLine.Text = "Old Calculated Line:";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.output_WeightError);
            this.panel7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel7.Location = new System.Drawing.Point(111, 101);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(143, 30);
            this.panel7.TabIndex = 11;
            // 
            // output_WeightError
            // 
            this.output_WeightError.AutoSize = true;
            this.output_WeightError.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.output_WeightError.Location = new System.Drawing.Point(3, 8);
            this.output_WeightError.Name = "output_WeightError";
            this.output_WeightError.Size = new System.Drawing.Size(27, 13);
            this.output_WeightError.TabIndex = 1;
            this.output_WeightError.Text = "N/A";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.output_BiasError);
            this.panel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel6.Location = new System.Drawing.Point(111, 70);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(143, 30);
            this.panel6.TabIndex = 10;
            // 
            // output_BiasError
            // 
            this.output_BiasError.AutoSize = true;
            this.output_BiasError.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.output_BiasError.Location = new System.Drawing.Point(3, 8);
            this.output_BiasError.Name = "output_BiasError";
            this.output_BiasError.Size = new System.Drawing.Size(27, 13);
            this.output_BiasError.TabIndex = 1;
            this.output_BiasError.Text = "N/A";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.output_OldCalculatedLine);
            this.panel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel5.Location = new System.Drawing.Point(111, 39);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(143, 30);
            this.panel5.TabIndex = 6;
            // 
            // output_OldCalculatedLine
            // 
            this.output_OldCalculatedLine.AutoSize = true;
            this.output_OldCalculatedLine.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.output_OldCalculatedLine.Location = new System.Drawing.Point(3, 8);
            this.output_OldCalculatedLine.Name = "output_OldCalculatedLine";
            this.output_OldCalculatedLine.Size = new System.Drawing.Size(27, 13);
            this.output_OldCalculatedLine.TabIndex = 1;
            this.output_OldCalculatedLine.Text = "N/A";
            // 
            // container
            // 
            this.container.Controls.Add(this.output_Epoch);
            this.container.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.container.Location = new System.Drawing.Point(111, 8);
            this.container.Name = "container";
            this.container.Size = new System.Drawing.Size(143, 30);
            this.container.TabIndex = 5;
            // 
            // output_Epoch
            // 
            this.output_Epoch.AutoSize = true;
            this.output_Epoch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.output_Epoch.Location = new System.Drawing.Point(3, 8);
            this.output_Epoch.Name = "output_Epoch";
            this.output_Epoch.Size = new System.Drawing.Size(27, 13);
            this.output_Epoch.TabIndex = 1;
            this.output_Epoch.Text = "N/A";
            // 
            // label_Epoch
            // 
            this.label_Epoch.AutoSize = true;
            this.label_Epoch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Epoch.Location = new System.Drawing.Point(6, 16);
            this.label_Epoch.Name = "label_Epoch";
            this.label_Epoch.Size = new System.Drawing.Size(41, 13);
            this.label_Epoch.TabIndex = 9;
            this.label_Epoch.Text = "Epoch:";
            // 
            // groupBox_HyperParameters
            // 
            this.groupBox_HyperParameters.Controls.Add(this.panel3);
            this.groupBox_HyperParameters.Controls.Add(this.label_SizeOfCanvas);
            this.groupBox_HyperParameters.Controls.Add(this.label_PointsPerEpoch);
            this.groupBox_HyperParameters.Controls.Add(this.panel9);
            this.groupBox_HyperParameters.Controls.Add(this.label_GeneratedPoints);
            this.groupBox_HyperParameters.Controls.Add(this.panel4);
            this.groupBox_HyperParameters.Controls.Add(this.panel2);
            this.groupBox_HyperParameters.Controls.Add(this.label_LearningRate);
            this.groupBox_HyperParameters.Controls.Add(this.panel1);
            this.groupBox_HyperParameters.Controls.Add(this.label_GroundTruthLine);
            this.groupBox_HyperParameters.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_HyperParameters.Location = new System.Drawing.Point(3, 3);
            this.groupBox_HyperParameters.Name = "groupBox_HyperParameters";
            this.groupBox_HyperParameters.Size = new System.Drawing.Size(260, 166);
            this.groupBox_HyperParameters.TabIndex = 0;
            this.groupBox_HyperParameters.TabStop = false;
            this.groupBox_HyperParameters.Text = "Hyper Parameters";
            // 
            // label_PointsPerEpoch
            // 
            this.label_PointsPerEpoch.AutoSize = true;
            this.label_PointsPerEpoch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_PointsPerEpoch.Location = new System.Drawing.Point(6, 141);
            this.label_PointsPerEpoch.Name = "label_PointsPerEpoch";
            this.label_PointsPerEpoch.Size = new System.Drawing.Size(92, 13);
            this.label_PointsPerEpoch.TabIndex = 10;
            this.label_PointsPerEpoch.Text = "Points Per Epoch:";
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.input_e);
            this.panel9.Controls.Add(this.label_eEquals);
            this.panel9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel9.Location = new System.Drawing.Point(111, 133);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(143, 30);
            this.panel9.TabIndex = 9;
            // 
            // input_e
            // 
            this.input_e.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input_e.Location = new System.Drawing.Point(24, 5);
            this.input_e.Name = "input_e";
            this.input_e.Size = new System.Drawing.Size(116, 20);
            this.input_e.TabIndex = 2;
            this.input_e.Text = "20";
            this.input_e.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.input_e.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            this.input_e.Leave += new System.EventHandler(this.textBoxDoubleCheck);
            // 
            // label_eEquals
            // 
            this.label_eEquals.AutoSize = true;
            this.label_eEquals.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_eEquals.Location = new System.Drawing.Point(3, 7);
            this.label_eEquals.Name = "label_eEquals";
            this.label_eEquals.Size = new System.Drawing.Size(22, 13);
            this.label_eEquals.TabIndex = 1;
            this.label_eEquals.Text = "e =";
            // 
            // label_GeneratedPoints
            // 
            this.label_GeneratedPoints.AutoSize = true;
            this.label_GeneratedPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_GeneratedPoints.Location = new System.Drawing.Point(6, 110);
            this.label_GeneratedPoints.Name = "label_GeneratedPoints";
            this.label_GeneratedPoints.Size = new System.Drawing.Size(92, 13);
            this.label_GeneratedPoints.TabIndex = 8;
            this.label_GeneratedPoints.Text = "Generated Points:";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.input_p);
            this.panel4.Controls.Add(this.label_pEquals);
            this.panel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel4.Location = new System.Drawing.Point(111, 102);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(143, 30);
            this.panel4.TabIndex = 7;
            // 
            // input_p
            // 
            this.input_p.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input_p.Location = new System.Drawing.Point(24, 5);
            this.input_p.Name = "input_p";
            this.input_p.Size = new System.Drawing.Size(116, 20);
            this.input_p.TabIndex = 2;
            this.input_p.Text = "20";
            this.input_p.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.input_p.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            this.input_p.Leave += new System.EventHandler(this.textBoxDoubleCheck);
            // 
            // label_pEquals
            // 
            this.label_pEquals.AutoSize = true;
            this.label_pEquals.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_pEquals.Location = new System.Drawing.Point(3, 7);
            this.label_pEquals.Name = "label_pEquals";
            this.label_pEquals.Size = new System.Drawing.Size(22, 13);
            this.label_pEquals.TabIndex = 1;
            this.label_pEquals.Text = "p =";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.input_r);
            this.panel2.Controls.Add(this.label_rEquals);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(111, 40);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(143, 30);
            this.panel2.TabIndex = 5;
            // 
            // input_r
            // 
            this.input_r.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input_r.Location = new System.Drawing.Point(24, 5);
            this.input_r.Name = "input_r";
            this.input_r.Size = new System.Drawing.Size(116, 20);
            this.input_r.TabIndex = 2;
            this.input_r.Text = "0.0001";
            this.input_r.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.input_r.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            this.input_r.Leave += new System.EventHandler(this.textBoxDoubleCheck);
            // 
            // label_rEquals
            // 
            this.label_rEquals.AutoSize = true;
            this.label_rEquals.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_rEquals.Location = new System.Drawing.Point(3, 7);
            this.label_rEquals.Name = "label_rEquals";
            this.label_rEquals.Size = new System.Drawing.Size(19, 13);
            this.label_rEquals.TabIndex = 1;
            this.label_rEquals.Text = "r =";
            // 
            // label_LearningRate
            // 
            this.label_LearningRate.AutoSize = true;
            this.label_LearningRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_LearningRate.Location = new System.Drawing.Point(6, 47);
            this.label_LearningRate.Name = "label_LearningRate";
            this.label_LearningRate.Size = new System.Drawing.Size(80, 13);
            this.label_LearningRate.TabIndex = 3;
            this.label_LearningRate.Text = "Learning Rate: ";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.input_b);
            this.panel1.Controls.Add(this.label_TimesXPlus);
            this.panel1.Controls.Add(this.input_w);
            this.panel1.Controls.Add(this.label_yEquals);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(111, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(143, 30);
            this.panel1.TabIndex = 2;
            // 
            // input_b
            // 
            this.input_b.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input_b.Location = new System.Drawing.Point(103, 5);
            this.input_b.Name = "input_b";
            this.input_b.Size = new System.Drawing.Size(37, 20);
            this.input_b.TabIndex = 4;
            this.input_b.Text = "3.0";
            this.input_b.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.input_b.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            this.input_b.Leave += new System.EventHandler(this.textBoxDoubleCheck);
            // 
            // label_TimesXPlus
            // 
            this.label_TimesXPlus.AutoSize = true;
            this.label_TimesXPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_TimesXPlus.Location = new System.Drawing.Point(69, 7);
            this.label_TimesXPlus.Name = "label_TimesXPlus";
            this.label_TimesXPlus.Size = new System.Drawing.Size(28, 13);
            this.label_TimesXPlus.TabIndex = 3;
            this.label_TimesXPlus.Text = "* x +";
            // 
            // input_w
            // 
            this.input_w.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input_w.Location = new System.Drawing.Point(24, 5);
            this.input_w.Name = "input_w";
            this.input_w.Size = new System.Drawing.Size(39, 20);
            this.input_w.TabIndex = 2;
            this.input_w.Text = "2.0";
            this.input_w.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.input_w.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            this.input_w.Leave += new System.EventHandler(this.textBoxDoubleCheck);
            // 
            // label_yEquals
            // 
            this.label_yEquals.AutoSize = true;
            this.label_yEquals.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_yEquals.Location = new System.Drawing.Point(3, 7);
            this.label_yEquals.Name = "label_yEquals";
            this.label_yEquals.Size = new System.Drawing.Size(21, 13);
            this.label_yEquals.TabIndex = 1;
            this.label_yEquals.Text = "y =";
            // 
            // label_GroundTruthLine
            // 
            this.label_GroundTruthLine.AutoSize = true;
            this.label_GroundTruthLine.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_GroundTruthLine.Location = new System.Drawing.Point(6, 16);
            this.label_GroundTruthLine.Name = "label_GroundTruthLine";
            this.label_GroundTruthLine.Size = new System.Drawing.Size(99, 13);
            this.label_GroundTruthLine.TabIndex = 0;
            this.label_GroundTruthLine.Text = "Ground Truth Line: ";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.input_height);
            this.panel3.Controls.Add(this.label_hEquals);
            this.panel3.Controls.Add(this.input_width);
            this.panel3.Controls.Add(this.label_wEquals);
            this.panel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(111, 71);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(143, 30);
            this.panel3.TabIndex = 12;
            // 
            // input_width
            // 
            this.input_width.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input_width.Location = new System.Drawing.Point(24, 5);
            this.input_width.Name = "input_width";
            this.input_width.Size = new System.Drawing.Size(39, 20);
            this.input_width.TabIndex = 2;
            this.input_width.Text = "1000";
            this.input_width.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label_wEquals
            // 
            this.label_wEquals.AutoSize = true;
            this.label_wEquals.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_wEquals.Location = new System.Drawing.Point(0, 7);
            this.label_wEquals.Name = "label_wEquals";
            this.label_wEquals.Size = new System.Drawing.Size(24, 13);
            this.label_wEquals.TabIndex = 1;
            this.label_wEquals.Text = "w =";
            // 
            // label_SizeOfCanvas
            // 
            this.label_SizeOfCanvas.AutoSize = true;
            this.label_SizeOfCanvas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_SizeOfCanvas.Location = new System.Drawing.Point(6, 78);
            this.label_SizeOfCanvas.Name = "label_SizeOfCanvas";
            this.label_SizeOfCanvas.Size = new System.Drawing.Size(81, 13);
            this.label_SizeOfCanvas.TabIndex = 11;
            this.label_SizeOfCanvas.Text = "Size of Canvas:";
            // 
            // input_height
            // 
            this.input_height.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input_height.Location = new System.Drawing.Point(101, 5);
            this.input_height.Name = "input_height";
            this.input_height.Size = new System.Drawing.Size(39, 20);
            this.input_height.TabIndex = 4;
            this.input_height.Text = "1000";
            this.input_height.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label_hEquals
            // 
            this.label_hEquals.AutoSize = true;
            this.label_hEquals.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_hEquals.Location = new System.Drawing.Point(77, 7);
            this.label_hEquals.Name = "label_hEquals";
            this.label_hEquals.Size = new System.Drawing.Size(22, 13);
            this.label_hEquals.TabIndex = 3;
            this.label_hEquals.Text = "h =";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 493);
            this.Controls.Add(this.splitContainer1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Perceptron Learning Visualization Tool";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox_RunTimeData.ResumeLayout(false);
            this.groupBox_RunTimeData.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.container.ResumeLayout(false);
            this.container.PerformLayout();
            this.groupBox_HyperParameters.ResumeLayout(false);
            this.groupBox_HyperParameters.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox_RunTimeData;
        private System.Windows.Forms.GroupBox groupBox_HyperParameters;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_yEquals;
        private System.Windows.Forms.Label label_GroundTruthLine;
        private System.Windows.Forms.Label label_LearningRate;
        private System.Windows.Forms.TextBox input_b;
        private System.Windows.Forms.Label label_TimesXPlus;
        private System.Windows.Forms.TextBox input_w;
        private System.Windows.Forms.Label label_GeneratedPoints;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox input_p;
        private System.Windows.Forms.Label label_pEquals;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox input_r;
        private System.Windows.Forms.Label label_rEquals;
        private System.Windows.Forms.Label label_Epoch;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label output_WeightError;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label output_BiasError;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label output_OldCalculatedLine;
        private System.Windows.Forms.Label label_OldCalculatedLine;
        private System.Windows.Forms.Label label_WeightError;
        private System.Windows.Forms.Label label_BiasError;
        private System.Windows.Forms.Label label_MSE;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label output_MSE;
        private System.Windows.Forms.Button button_Reset;
        private System.Windows.Forms.Button button_Run;
        private System.Windows.Forms.Label label_PointsPerEpoch;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.TextBox input_e;
        private System.Windows.Forms.Label label_eEquals;
        private System.Windows.Forms.Label label_NewCalculatedLine;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Label output_NewCalculatedLine;
        private System.Windows.Forms.Panel container;
        private System.Windows.Forms.Label output_Epoch;
        private System.Windows.Forms.Button button_PlayPause;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox input_height;
        private System.Windows.Forms.Label label_hEquals;
        private System.Windows.Forms.TextBox input_width;
        private System.Windows.Forms.Label label_wEquals;
        private System.Windows.Forms.Label label_SizeOfCanvas;
    }
}

