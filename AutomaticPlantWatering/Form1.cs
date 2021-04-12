using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DotFuzzy;

namespace AutomaticPlantWatering
{
    public partial class Form1 : Form
    {
        private FuzzyEngine fuzzyEngine;
        private LinguisticVariable moisture;
        private LinguisticVariable temperature;
        private LinguisticVariable water;

        public Form1()
        {
            InitializeComponent();
            fuzzyEngine = new FuzzyEngine();
            SetMembers();
            SetRules();
        }

        private void panelMoisture_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            //int width = panelMoisture.Width/3;
            //int height = panelMoisture.Height;
            //g.FillRectangle(new SolidBrush(Color.FromArgb(231, 76, 60)), 0, 0, width, height);
            //g.FillRectangle(new SolidBrush(Color.FromArgb(46, 204, 113)), 0 + width, 0, width, height);
            //g.FillRectangle(new SolidBrush(Color.FromArgb(52, 152, 219)), 0 + width * 2, 0, width, height);
            LinearGradientBrush brush = new LinearGradientBrush(
                panelTemperature.ClientRectangle,
                Color.FromArgb(231, 76, 60),
                Color.FromArgb(52, 152, 219), 
                0.0);
            ColorBlend cblend = new ColorBlend(3);
            cblend.Colors = new Color[3] { 
                Color.FromArgb(231, 76, 60),
                Color.FromArgb(46, 204, 113),
                Color.FromArgb(52, 152, 219) };
            cblend.Positions = new float[3] { 0f, 0.5f, 1f };
            brush.InterpolationColors = cblend;
            g.FillRectangle(brush, this.ClientRectangle);
        }

        private void panelTemperature_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            LinearGradientBrush brush = new LinearGradientBrush(
                panelTemperature.ClientRectangle,
                Color.FromArgb(52, 152, 219),
                Color.FromArgb(231, 76, 60),
                0.0);
            g.FillRectangle(brush, this.ClientRectangle);
        }

        private void panelWater_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            LinearGradientBrush brush = new LinearGradientBrush(
                panelTemperature.ClientRectangle,
                Color.FromArgb(187, 222, 251),
                Color.FromArgb(52, 152, 219),
                0.0);
            g.FillRectangle(brush, this.ClientRectangle);
        }

        private void trackBarMoisture_ValueChanged(object sender, EventArgs e)
        {
            labelMoisture.Text = trackBarMoisture.Value + "";
        }

        private void trackBarTemperature_ValueChanged(object sender, EventArgs e)
        {
            labelTemperature.Text = trackBarTemperature.Value + "°C";
        }

        private void trackBarWater_ValueChanged(object sender, EventArgs e)
        {
            labelWater.Text = trackBarWater.Value + "";
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            SetInputs();
            GetOutputs();
        }

        private void SetMembers()
        {
            moisture = new LinguisticVariable("Moisture");
            moisture.MembershipFunctionCollection.Add(new MembershipFunction("Dry", 1, 1, 2, 4));
            moisture.MembershipFunctionCollection.Add(new MembershipFunction("Moist", 3, 4, 7, 8));
            moisture.MembershipFunctionCollection.Add(new MembershipFunction("Wet", 7, 9, 10, 10));

            temperature = new LinguisticVariable("Temperature");
            temperature.MembershipFunctionCollection.Add(new MembershipFunction("Cold", 1, 1, 10, 20));
            temperature.MembershipFunctionCollection.Add(new MembershipFunction("Warm", 15, 20, 25, 30));
            temperature.MembershipFunctionCollection.Add(new MembershipFunction("Hot", 25, 35, 50, 50));

            water = new LinguisticVariable("Water");
            water.MembershipFunctionCollection.Add(new MembershipFunction("Low", 1, 1, 2, 3));
            water.MembershipFunctionCollection.Add(new MembershipFunction("LowMedium", 2, 3, 4, 5));
            water.MembershipFunctionCollection.Add(new MembershipFunction("Medium", 4, 5, 6, 7));
            water.MembershipFunctionCollection.Add(new MembershipFunction("MediumHigh", 6, 7, 8, 9));
            water.MembershipFunctionCollection.Add(new MembershipFunction("High", 8, 9, 10, 10));

            fuzzyEngine.LinguisticVariableCollection.Add(moisture);
            fuzzyEngine.LinguisticVariableCollection.Add(temperature);
            fuzzyEngine.LinguisticVariableCollection.Add(water);
            fuzzyEngine.Consequent = "Water";
        }

        private void SetRules()
        {
            fuzzyEngine.FuzzyRuleCollection.Add(
                new FuzzyRule("IF (Moisture IS Dry) AND (Temperature IS Cold) THEN Water IS Medium"));
            fuzzyEngine.FuzzyRuleCollection.Add(
                new FuzzyRule("IF (Moisture IS Dry) AND (Temperature IS Warm) THEN Water IS MediumHigh"));
            fuzzyEngine.FuzzyRuleCollection.Add(
                new FuzzyRule("IF (Moisture IS Dry) AND (Temperature IS Hot) THEN Water IS High"));
            fuzzyEngine.FuzzyRuleCollection.Add(
                new FuzzyRule("IF (Moisture IS Moist) AND (Temperature IS Cold) THEN Water IS LowMedium"));
            fuzzyEngine.FuzzyRuleCollection.Add(
                new FuzzyRule("IF (Moisture IS Moist) AND (Temperature IS Warm) THEN Water IS Medium"));
            fuzzyEngine.FuzzyRuleCollection.Add(
                new FuzzyRule("IF (Moisture IS Moist) AND (Temperature IS Hot) THEN Water IS MediumHigh"));
            fuzzyEngine.FuzzyRuleCollection.Add(
                new FuzzyRule("IF (Moisture IS Wet) AND (Temperature IS Cold) THEN Water IS Low"));
            fuzzyEngine.FuzzyRuleCollection.Add(
                new FuzzyRule("IF (Moisture IS Wet) AND (Temperature IS Warm) THEN Water IS Low"));
            fuzzyEngine.FuzzyRuleCollection.Add(
                new FuzzyRule("IF (Moisture IS Wet) AND (Temperature IS Hot) THEN Water IS Low"));
        }

        private void SetInputs()
        {
            moisture.InputValue = trackBarMoisture.Value;
            moisture.Fuzzify("Moist");
            temperature.InputValue = trackBarTemperature.Value;
            temperature.Fuzzify("Warm");
        }

        private void GetOutputs()
        {
            trackBarWater.Value = (int)fuzzyEngine.Defuzzify();
            trackBarMoisture.Value = (int)GetNewMoisture();
        }

        private double GetNewMoisture()
        {
            double temperature = trackBarTemperature.Value;
            double oldMoisture = trackBarMoisture.Value;
            double water = trackBarWater.Value;
            double newMoisture = oldMoisture + water / 5 - temperature / 100;
            if (oldMoisture < 5)
               newMoisture = Math.Round(newMoisture, 0, MidpointRounding.AwayFromZero);
            //MessageBox.Show(newMoisture + "");
            return newMoisture;
        }
    }
}
